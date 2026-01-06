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
    public partial class Nomear_convidados : Form
    {
        // Propriedade privada para armazenar o username logado
        private string usuarioLogado;
        public static List<string> convidados = new List<string>();

        public Nomear_convidados(string usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
        }

        private void Nomear_convidados_Load(object sender, EventArgs e)
        {
            cbbxConv.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 1; i <=3; i++)
            {
                cbbxConv.Items.Add(i);
            }
            cbbxConv.SelectedIndex = 0;
        }

        private void btnDef_Click(object sender, EventArgs e)
        {
            int numConvidados = int.Parse(cbbxConv.SelectedItem.ToString());

            convidados.Clear();
            //Verifica a textbox e poem um default caso estaja vazia
            if(numConvidados >= 1)
                convidados.Add(string.IsNullOrWhiteSpace(txtconv1.Text) ? "Convidado 1" : txtconv1.Text);
            if (numConvidados >= 2)
                convidados.Add(string.IsNullOrWhiteSpace(txtconv2.Text) ? "Convidado 2" : txtconv2.Text);
            if(numConvidados == 3)
                convidados.Add(string.IsNullOrWhiteSpace(txtconv3.Text) ? "Convidado 3" : txtconv3.Text);

            Menu menu = new Menu(usuarioLogado, convidados);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Modo_Jogo modo_Jogo = new Modo_Jogo(usuarioLogado);
            modo_Jogo.ShowDialog();
        }

        private void cbbxConv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numConvidados = int.Parse(cbbxConv.SelectedItem.ToString());

            //Esconder as labels e as textboxes
            lbConv2.Visible = false;
            txtconv2.Visible = false;
            lbConv3.Visible = false;
            txtconv3.Visible = false;

            //Mostar as labels e as textboxes conforme o número de convidados selecionado
            if (numConvidados >= 2)
            {
                lbConv2.Visible = true;
                txtconv2.Visible = true;
            }
            if (numConvidados == 3)
            {
                lbConv3.Visible = true;
                txtconv3.Visible = true;

            }
        }
    }
}
