using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _4Linha
{
    public partial class Cadastro : Form
    {
        private string connectionString = "server=localhost;database=jogo4linha;user=root;password=mysql;";

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            CriarBaseDadosSeNaoExistir();
            lbVoltar.Cursor = Cursors.Hand;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string password = txtPass.Text;
            string confirm = txtConfPass.Text;

            // Verifica se os campos estão preenchidos
            if (username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Verifica se as passwords coincidem
            if (password != confirm)
            {
                MessageBox.Show("As passwords não coincidem!");
                return;
            }

            // Tenta criar a conta
            if (RegistrarUsuario(username, password))
            {
                MessageBox.Show("Conta criada com sucesso!");
                this.Close(); // fecha o form de cadastro
            }
            else
            {
                MessageBox.Show("Erro: esse nome de utilizador já existe.");
            }
        }

        private bool RegistrarUsuario(string username, string password)
        {
            string hashPassword = GerarHash(password); // gera hash

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "INSERT INTO Utilizadores (username, password_hash) VALUES (@user, @pass)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", hashPassword);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Se username já existe (erro 1062)
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        // Função para gerar hash SHA256 da password
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

        private void CriarBaseDadosSeNaoExistir()
        {
            // Conexão ao MySQL sem database
            string connStr = "server=localhost;user=root;password=mysql;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // Cria a base de dados se não existir
                string sqlDB = "CREATE DATABASE IF NOT EXISTS jogo4linha";
                using (MySqlCommand cmd = new MySqlCommand(sqlDB, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Seleciona a base de dados
                conn.ChangeDatabase("jogo4linha");

                // Cria tabela Utilizadores se não existir
                string sqlTable = @"
            CREATE TABLE IF NOT EXISTS Utilizadores (
                id INT AUTO_INCREMENT PRIMARY KEY,
                username VARCHAR(50) NOT NULL UNIQUE,
                password_hash VARCHAR(255) NOT NULL
            );";

                using (MySqlCommand cmd = new MySqlCommand(sqlTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
