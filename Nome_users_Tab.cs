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
    public partial class Nome_users_Tab : Form
    {
        public string NomeJogador2 { get; private set; } 
        public string NomeJogador3 { get; private set; }
        public string NomeJogador4 { get; private set; }

        public Nome_users_Tab()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nome_users_Tab_Load(object sender, EventArgs e)
        {

        }

        private void btnDef_Click(object sender, EventArgs e)
        {
            NomeJogador2 = txtUser2.Text.Trim();
            NomeJogador3 = txtUser3.Text.Trim();
            NomeJogador4 = txtUser4.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
