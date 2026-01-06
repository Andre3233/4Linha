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
    public partial class Menu : Form
    {
        // Propriedade privada para armazenar o username logado
        private string usuarioLogado;
        List<string> convidados = Nomear_convidados.convidados;

        public Menu(string usuario, List<string> nomesConvidados)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            convidados = nomesConvidados;
        }

        private void btn2J_Click(object sender, EventArgs e)
        {
            Tabuleiro_2J tabuleiro_2 = new Tabuleiro_2J(usuarioLogado, convidados);
            tabuleiro_2.Show();
            this.Close();
        }

        private void btn3J_Click(object sender, EventArgs e)
        {
            Tabuleiro_3J tabuleiro_3 = new Tabuleiro_3J(usuarioLogado, convidados);
            tabuleiro_3.Show();
            this.Close();
        }

        private void btn1J_Click(object sender, EventArgs e)
        {
            Tabuleiro_1J tabuleiro_1 = new Tabuleiro_1J(usuarioLogado);
            tabuleiro_1.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn4J_Click(object sender, EventArgs e)
        {
            Tabuleiro_4J tabuleiro_4 = new Tabuleiro_4J(usuarioLogado, convidados);
            this.Hide();
            tabuleiro_4.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
