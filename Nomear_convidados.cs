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

            // Só cria a lista se estiver vazia (primeira vez)
            if (convidados == null)
                convidados = new List<string>();

            // Convidado 1
            if (!string.IsNullOrWhiteSpace(txtconv1.Text))
            {
                if (convidados.Count >= 1)
                    convidados[0] = txtconv1.Text; // altera o nome existente
                else
                    convidados.Add(txtconv1.Text); // adiciona novo nome
            }
            else
            {
                if (convidados.Count == 0)
                    convidados.Add("Convidado 1"); // default se não houver nenhum nome
                                                   // caso contrário mantém o nome anterior
            }

            // Convidado 2
            if (!string.IsNullOrWhiteSpace(txtconv2.Text))
            {
                if (convidados.Count >= 2)
                    convidados[1] = txtconv2.Text;
                else
                    convidados.Add(txtconv2.Text);
            }
            else
            {
                if (convidados.Count < 2)
                    convidados.Add("Convidado 2");
            }

            // Convidado 3
            if (!string.IsNullOrWhiteSpace(txtconv3.Text))
            {
                if (convidados.Count >= 3)
                    convidados[2] = txtconv3.Text;
                else
                    convidados.Add(txtconv3.Text);
            }
            else
            {
                if (convidados.Count < 3)
                    convidados.Add("Convidado 3");
            }

            // Volta ao menu passando a lista atualizada
            Menu menu = new Menu(usuarioLogado, convidados);
            menu.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //Se já tiver passado pelo menu,volta para lá 
            if (_4Linha.Menu.jaEntrouNoMenu)
            {
                Menu menu = new Menu(usuarioLogado, convidados);
                menu.Show();
                this.Close();
            }
            else
            {
                Modo_Jogo modo_Jogo = new Modo_Jogo(usuarioLogado);
                modo_Jogo.Show();
                this.Close();
            }

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
