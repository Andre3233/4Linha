using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Linha
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbCadastro.Cursor = Cursors.Hand;
            lbConvidado.Cursor = Cursors.Hand;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void lbConvidado_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string password = txtPass.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Preenche todos os campos.");
                return;
            }

            if (ValidarLogin(username, password))
            {
                // Abre o Form do menu
                Menu menu = new Menu();
                menu.Show();

                // Esconde o Form de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Utilizador ou password incorretos.");
            }
        }

        private string GerarHash(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private bool ValidarLogin(string username, string password)
        {
            string hashPassword = GerarHash(password); // gera hash da password inserida

            string connectionString = "server=localhost;database=jogo4linha;user=root;password=mysql;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM Utilizadores WHERE username = @user AND password_hash = @pass";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", hashPassword); // usa o hash

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0; // se for 1, o login está correto
                }
            }
        }
    }
}
