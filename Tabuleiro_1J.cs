using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Linha
{
    public partial class Tabuleiro_1J : Form
    {
        // Nº de linhas e colunas do tabuleiro (a imagem tem 5 linhas x 6 colunas de círculos)
        private int linhas = 5;     // 5 filas de bolinhas
        private int colunas = 6;    // 6 colunas de bolinhas

        // Largura e altura de cada “casa” lógica por cima da imagem
        private int larguraCasa;
        private int alturaCasa;

        // Indica se o jogo já terminou (alguém ganhou)
        private bool jogoTerminado = false;

        // Deslocamento (margem) da grelha em relação à imagem
        private int offsetX = 0;
        private int offsetY = 0;

        // Matriz que guarda as peças colocadas (null = vazio, Color = peça)
        private Color?[,] tabuleiro;

        // Jogador atual (começa o Vermelho)
        private Color jogadorAtual = Color.Red;

        private string nomeJogador1 = "Jogador 1";
        
        //Bot
        private Random bot = new Random();

        public Tabuleiro_1J(string nomeJogador1 = "Jogador 1")
        {
            InitializeComponent();
            this.nomeJogador1 = nomeJogador1;

            // Evita “flicker” ao desenhar
            this.DoubleBuffered = true;

            // Liga eventos
            this.Load += Tabuleiro_1J_Load;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.Paint += pictureBox1_Paint;
        }

        private void Tabuleiro_1J_Load(object sender, EventArgs e)
        {
            // Garante que o PictureBox usa o tamanho real da imagem (sem esticar)
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            // ---- CÁLCULO ALINHADO COM A IMAGEM ----
            // A imagem tem 433 x 342 px
            // Bolinhas: 6 colunas (largura) e 5 linhas (altura)

            // Largura aproximada de cada coluna (distância entre centros ≈ 72px)
            larguraCasa = pictureBox1.Image.Width / colunas;    // ~72 px

            // Altura aproximada de cada linha (distância entre centros ≈ 68px)
            alturaCasa = pictureBox1.Image.Height / linhas;     // ~68 px

            offsetX = 0;   // praticamente encostado à esquerda
            offsetY = 4;   // pequeno ajuste vertical (testado na imagem)

            // Cria a matriz lógica do tabuleiro com o novo nº de linhas/colunas
            tabuleiro = new Color?[linhas, colunas];
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int Coluna = (e.X - offsetX) / larguraCasa;
            int Linha = (e.Y - offsetY) / alturaCasa;

            // Verifica se está dentro da zona válida do tabuleiro
            if (Coluna >= 0 && Coluna < colunas && Linha >= 0 && Linha < linhas)
            {
                pictureBox1.Cursor = Cursors.Hand;
            }
            else
            {
                pictureBox1.Cursor = Cursors.Default;
            }

            // Se o jogo já terminou, ignora cliques
            if (jogoTerminado)
                return;

            // Converte coordenadas do rato em índice de coluna/linha
            int coluna = (e.X - offsetX) / larguraCasa;
            int linhaClique = (e.Y - offsetY) / alturaCasa;

            // Verifica se o clique foi dentro da grelha válida
            if (coluna < 0 || coluna >= colunas || linhaClique < 0 || linhaClique >= linhas)
                return;

            // Procura a primeira linha livre a partir de baixo (efeito "cair" da peça)
            int linhaLivre = -1;
            for (int l = linhas - 1; l >= 0; l--)
            {
                if (tabuleiro[l, coluna] == null)
                {
                    linhaLivre = l;
                    break;
                }
            }

            // Se a coluna está cheia, não faz nada
            if (linhaLivre == -1)
                return;

            // Coloca a peça do jogador atual na posição encontrada
            tabuleiro[linhaLivre, coluna] = jogadorAtual;

            // Verifica se este movimento deu vitória ANTES de trocar de jogador
            if (Vitoria(linhaLivre, coluna))
            {
                var resultado = MessageBox.Show(
                $"{nomeJogador1} ganhou!\nQueres jogar outra vez?", 
                "Vitória!",
                MessageBoxButtons.RetryCancel 
                );

                jogoTerminado = true; 

                if (resultado == DialogResult.Retry) 
                {
                    ReiniciarJogo();
                }
                else if (resultado == DialogResult.Cancel)
                {
                    this.Close();
                }

                pictureBox1.Invalidate(); 
                return; 

            }

            // Troca de jogador
            jogadorAtual = (jogadorAtual == Color.Red) ? Color.Yellow : Color.Red;

            // Se agora for o computador, ele joga imediatamente 
            if (jogadorAtual == Color.Yellow)
            {
                JogadaComputador(); 
                return;             
            }


            // Pede novo desenho do tabuleiro
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Percorre todas as linhas e colunas lógicas do tabuleiro
            for (int l = 0; l < linhas; l++)
            {
                for (int c = 0; c < colunas; c++)
                {
                    // Calcula a posição da célula em pixels dentro da PictureBox
                    int x = offsetX + c * larguraCasa;
                    int y = offsetY + l * alturaCasa;

                    // GRElha invisível
                    // A grelha não é desenhada, mas os cálculos lógicos continuam a usar

                    // Desenha a peça se existir
                    if (tabuleiro[l, c] != null)
                    {
                        using (Brush b = new SolidBrush(tabuleiro[l, c].Value))
                        {
                            // Preenche o círculo com margem interna de 5px
                            g.FillEllipse(b, x + 5, y + 5, larguraCasa - 10, alturaCasa - 10);
                        }
                    }
                }
            }
        }


        // Verifica se o último movimento deu 4 em linha
        private bool Vitoria(int linha, int coluna)
        {
            // Cor da peça colocada
            Color cor = tabuleiro[linha, coluna].Value;

            // Função local que conta quantas peças consecutivas há numa direção (dl, dc)
            int Contar(int dl, int dc)
            {
                int cont = 0;
                int l = linha + dl;
                int c = coluna + dc;

                // Avança na direção indicada enquanto a cor for igual
                while (l >= 0 && l < linhas && c >= 0 && c < colunas &&
                       tabuleiro[l, c] == cor)
                {
                    cont++;
                    l += dl;
                    c += dc;
                }

                return cont;
            }

            // Horizontal: esquerda + direita + a própria peça
            int horizontal = 1 + Contar(0, -1) + Contar(0, 1);
            if (horizontal >= 4) return true;

            // Vertical: só para baixo (as peças empilham de baixo para cima)
            int vertical = 1 + Contar(1, 0);
            if (vertical >= 4) return true;

            // Diagonal (\)
            int diagonal1 = 1 + Contar(1, 1) + Contar(-1, -1);
            if (diagonal1 >= 4) return true;

            // Diagonal (/)
            int diagonal2 = 1 + Contar(-1, 1) + Contar(1, -1);
            if (diagonal2 >= 4) return true;

            // Caso não tenha 4 em linha em nenhuma direção
            return false;
        }

        private void JogadaComputador() 
        {
            if (jogoTerminado) return;

            int coluna = -1;
            int linhaLivre = -1;

            // --- 1. Tentar ganhar ---
            for (int c = 0; c < colunas; c++)
            {
                int l = LinhahLivre(c);
                if (l == -1) continue;

                tabuleiro[l, c] = Color.Yellow;
                if (Vitoria(l, c))
                {
                    coluna = c;
                    linhaLivre = l;
                    break;
                }
                tabuleiro[l, c] = null;
            }

            // --- 2. Bloquear jogador ---
            if (coluna == -1)
            {
                for (int c = 0; c < colunas; c++)
                {
                    int l = LinhahLivre(c);
                    if (l == -1) continue;

                    tabuleiro[l, c] = Color.Red;
                    if (Vitoria(l, c))
                    {
                        coluna = c;
                        linhaLivre = l;
                        tabuleiro[l, c] = null;
                        break;
                    }
                    tabuleiro[l, c] = null;
                }
            }

            // --- 3. Escolha aleatória ---
            if (coluna == -1)
            {
                do
                {
                    coluna = bot.Next(0, colunas);
                    linhaLivre = LinhahLivre(coluna);
                } while (linhaLivre == -1);
            }
            else
            {
                // Já calculei linhaLivre nos passos 1 ou 2
                if (linhaLivre == -1) linhaLivre = LinhahLivre(coluna);
            }

            // Coloca peça do computador (amarelo)
            tabuleiro[linhaLivre, coluna] = Color.Yellow;

            // Verifica vitória
            if (Vitoria(linhaLivre, coluna))
            {
                var resultado = MessageBox.Show(
                "O computador ganhou!\nQueres jogar outra vez?",
                "Vitória!",
                MessageBoxButtons.RetryCancel 
                );

                jogoTerminado = true;

                if (resultado == DialogResult.Retry) 
                {
                    ReiniciarJogo(); 
                }
                else if (resultado == DialogResult.Cancel) 
                {
                    this.Close(); 
                }

                pictureBox1.Invalidate(); 
                return;
            }

            // Volta o turno ao jogador
            jogadorAtual = Color.Red;
            pictureBox1.Invalidate();
        }

        // Função auxiliar: devolve a primeira linha livre de uma coluna
        private int LinhahLivre(int coluna) 
        {
            for (int l = linhas - 1; l >= 0; l--)
            {
                if (tabuleiro[l, coluna] == null)
                    return l;
            }
            return -1;
        }

        private void ReiniciarJogo() 
        {
            tabuleiro = new Color?[linhas, colunas];
            jogadorAtual = Color.Red; 
            jogoTerminado = false; 
            pictureBox1.Invalidate(); 
        }

    }
}
