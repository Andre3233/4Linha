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

        public Menu(string usuario = "Jogador 1")
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void btn2J_Click(object sender, EventArgs e)
        {
            Tabuleiro_2J tabuleiro_2 = new Tabuleiro_2J(usuarioLogado);
            tabuleiro_2.ShowDialog();
        }

        private void btn3J_Click(object sender, EventArgs e)
        {
            Tabuleiro_3J tabuleiro_3 = new Tabuleiro_3J(usuarioLogado);
            tabuleiro_3.ShowDialog();
        }

        private void btn1J_Click(object sender, EventArgs e)
        {
            Tabuleiro_1J tabuleiro_1 = new Tabuleiro_1J(usuarioLogado);
            tabuleiro_1.ShowDialog();
        }
    }
}
