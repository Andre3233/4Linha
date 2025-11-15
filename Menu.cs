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
        public Menu()
        {
            InitializeComponent();
        }

        private void btn2J_Click(object sender, EventArgs e)
        {
            Tabuleiro_2J tabuleiro_2 = new Tabuleiro_2J();
            tabuleiro_2.ShowDialog();
        }
    }
}
