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
    public partial class Tabuleiro_2J : Form
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

        public Tabuleiro_2J()
        {
            InitializeComponent();

            // Evita “flicker” ao desenhar
            this.DoubleBuffered = true;

            // Liga eventos
            this.Load += Tabuleiro_2J_Load;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.Paint += pictureBox1_Paint;
        }

        private void Tabuleiro_2J_Load(object sender, EventArgs e)
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

            // A imagem tem uma moldura azul em cima, por isso
            // ajustamos um pouco para baixo para encaixar nas bolinhas
            offsetX = 0;   // praticamente encostado à esquerda
            offsetY = 4;   // pequeno ajuste vertical (testado na imagem)

            // Cria a matriz lógica do tabuleiro com o novo nº de linhas/colunas
            tabuleiro = new Color?[linhas, colunas];
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
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
                MessageBox.Show(
                    $"{(jogadorAtual == Color.Red ? "Jogador 1" : "Jogador 2")} ganhou!"
                );
                jogoTerminado = true;
                pictureBox1.Invalidate(); // Redesenha para mostrar a última peça
                return;
            }

            // Troca de jogador (Vermelho ↔ Amarelo)
            jogadorAtual = (jogadorAtual == Color.Red) ? Color.Yellow : Color.Red;

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
                    // g.DrawRectangle(Pens.Black, x, y, larguraCasa, alturaCasa);

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

            // Diagonal principal (\)
            int diagonal1 = 1 + Contar(1, 1) + Contar(-1, -1);
            if (diagonal1 >= 4) return true;

            // Diagonal secundária (/)
            int diagonal2 = 1 + Contar(-1, 1) + Contar(1, -1);
            if (diagonal2 >= 4) return true;

            // Caso não tenha 4 em linha em nenhuma direção
            return false;
        }
    }
}
