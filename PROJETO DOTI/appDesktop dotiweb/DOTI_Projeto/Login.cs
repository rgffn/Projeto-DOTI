using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DOTI_Projeto
{
    public partial class frmLogin : Form
    {
        string email, senha;
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Encerrar o Sistema?", "ENCERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
                txtEmail.Select();
            }

        }

        private void Login()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT email, senha, cargo FROM funcionario WHERE email=@email AND senha=@senha";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Banco.nivel = reader.GetString(2);
                frmMenu menu = new frmMenu();
                menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario e senha invalidos");
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Select();
            }
            banco.Desconectar();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int i = txtEmail.Text.IndexOf('@');
            int j = txtEmail.Text.IndexOf('.');
            if ((i == -1) || (j == -1))
            {
                MessageBox.Show("Favor digitar um email valido");
                txtEmail.Clear();
                txtEmail.Select();
            }
            else
            {
                email = txtEmail.Text;
                senha = txtSenha.Text;
                Login();
            }


        }
    }
}
