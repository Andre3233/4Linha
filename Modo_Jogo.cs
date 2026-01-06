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
    public partial class Modo_Jogo : Form
    {
        // Propriedade privada para armazenar o username logado
        private string usuarioLogado;
        public Modo_Jogo(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void Modo_Jogo_Load(object sender, EventArgs e)
        {

        }

        private void btnSozinho_Click(object sender, EventArgs e)
        {
            Tabuleiro_1J tabuleiro_1J = new Tabuleiro_1J(usuarioLogado);
            this.Hide();
            tabuleiro_1J.ShowDialog();
        }

        //Botão para se jogar com varias pessoas
        private void btn_Vpessoas_Click(object sender, EventArgs e)
        {
            Nomear_convidados nomear_Convidados = new Nomear_convidados(usuarioLogado);
            this.Hide();
            nomear_Convidados.ShowDialog();
        }
    }
}
