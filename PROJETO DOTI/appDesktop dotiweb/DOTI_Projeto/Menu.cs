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
    public partial class frmMenu : Form
    {
        int linhaAtual, codigo;
        string BuscarAssunto;
        public frmMenu()
        {
            InitializeComponent();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Close();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            frmAluno aluno = new frmAluno();
            aluno.Show();
            Hide();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            frmAulas aulas = new frmAulas();
            aulas.Show();
            Hide();
        }

        private void btnProcessos_Click(object sender, EventArgs e)
        {
            frmVeiculos veiculos = new frmVeiculos();
            veiculos.Show();
            Hide();
        }

        private void btnInstrutores_Click(object sender, EventArgs e)
        {
            frmInstrutores instrutores = new frmInstrutores();
            instrutores.Show();
            Hide();

        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            frmServico servico = new frmServico();
            servico.Show();
            Hide();
        }
        private void CarregarContato()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT id,nome,email,assunto,fone,mens FROM contato ORDER BY id DESC";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBuscar.DataSource = dt;
            dgvBuscar.Columns[0].HeaderText = "Codigo";
            dgvBuscar.Columns[0].Visible = false;
            dgvBuscar.Columns[1].HeaderText = "Nome";
            dgvBuscar.Columns[2].HeaderText = "Email";
            dgvBuscar.Columns[3].HeaderText = "Assunto";
            dgvBuscar.Columns[4].HeaderText = "Telefone";
            dgvBuscar.Columns[5].HeaderText = "Mensagem";

            banco.Desconectar();
        }
        private void LIDO()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "DELETE FROM contato WHERE id = @codigo;";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Mensagem Excluida!");
        }

        private void btnLido_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(codigo.ToString());
            LIDO();
            CarregarContato();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            if (Banco.nivel == "ATENDENTE")
            {
                btnInstrutores.Enabled = false;
                btnAulas.Enabled = false;
                btnProcessos.Enabled = false;
                btnLogo.Enabled = false;
            }
            CarregarContato();
            dgvBuscar.ClearSelection();
            dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvBuscar_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvBuscar.Sort(dgvBuscar.Columns[1], ListSortDirection.Ascending);
            dgvBuscar.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAssunto = txtBuscar.Text;
            CarregarBuscar();
        }

        private void CarregarBuscar()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT id,nome,email,assunto,fone,mens FROM contato WHERE assunto LIKE '%" + BuscarAssunto + "%' ORDER BY nome";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBuscar.DataSource = dt;
            dgvBuscar.Columns[0].HeaderText = "Codigo";
            dgvBuscar.Columns[0].Visible = false;
            dgvBuscar.Columns[1].HeaderText = "Nome";
            dgvBuscar.Columns[2].HeaderText = "Email";
            dgvBuscar.Columns[3].HeaderText = "Assunto";
            dgvBuscar.Columns[4].HeaderText = "Telefone";
            dgvBuscar.Columns[5].HeaderText = "Mensagem";

            banco.Desconectar();
        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvBuscar[0, linhaAtual].Value);
            }

            //MessageBox.Show(codigo.ToString());
        }
    }
}
