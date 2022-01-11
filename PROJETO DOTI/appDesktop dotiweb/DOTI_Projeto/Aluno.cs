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
    public partial class frmAluno : Form
    {
        int linhaAtual, codigo;
        string status, nome;

        public frmAluno()
        {
            InitializeComponent();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadAluno cadAluno = new frmCadAluno();
            cadAluno.funcao = "ADICIONAR";
            cadAluno.Show();
            Hide();
        }

        private void CarregarAluno()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM matriculacfc ORDER BY nome";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAluno.DataSource = dt;
            dgvAluno.Columns[0].HeaderText = "Código";
            dgvAluno.Columns[1].HeaderText = "Nome do Aluno";
            dgvAluno.Columns[2].HeaderText = "CPF";
            dgvAluno.Columns[3].HeaderText = "E-Mail";
            dgvAluno.Columns[4].HeaderText = "Senha";
            dgvAluno.Columns[5].HeaderText = "Data de Cadastro";
            dgvAluno.Columns[6].HeaderText = "Status";
            dgvAluno.Columns[7].HeaderText = "Foto";

            banco.Desconectar();

        }
        private void dgvAluno_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvAluno.Sort(dgvAluno.Columns[1], ListSortDirection.Ascending);
            dgvAluno.ClearSelection();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadAluno cadAluno = new frmCadAluno();
            cadAluno.funcao = "ALTERAR";
            if (linhaAtual >= 0)
            {
                cadAluno.codigo = Convert.ToInt32(dgvAluno[0, linhaAtual].Value);
            }
            cadAluno.Show();
            Hide();
        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvAluno[0, linhaAtual].Value);
            }
        }

        private void CarregarAlunoStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM matriculacfc WHERE status=@status ORDER BY nome";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@status", status);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAluno.DataSource = dt;
            dgvAluno.Columns[0].HeaderText = "Código";
            dgvAluno.Columns[1].HeaderText = "Nome do Aluno";
            dgvAluno.Columns[2].HeaderText = "CPF";
            dgvAluno.Columns[3].HeaderText = "E-Mail";
            dgvAluno.Columns[4].HeaderText = "Senha";
            dgvAluno.Columns[5].HeaderText = "Data de Cadastro";
            dgvAluno.Columns[6].HeaderText = "Status";
            dgvAluno.Columns[7].HeaderText = "Foto";

            banco.Desconectar();

        }
        private void CarregarAlunoNome()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM matriculacfc WHERE nome LIKE '%" + nome + "%' ORDER BY nome";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            //cmd.Parameters.AddWithValue("@nome", nome);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAluno.DataSource = dt;
            dgvAluno.Columns[0].HeaderText = "Código";
            dgvAluno.Columns[1].HeaderText = "Nome do Aluno";
            dgvAluno.Columns[2].HeaderText = "CPF";
            dgvAluno.Columns[3].HeaderText = "E-Mail";
            dgvAluno.Columns[4].HeaderText = "Senha";
            dgvAluno.Columns[5].HeaderText = "Data de Cadastro";
            dgvAluno.Columns[6].HeaderText = "Status";
            dgvAluno.Columns[7].HeaderText = "Foto";

            banco.Desconectar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            nome = txtBuscar.Text;
            CarregarAlunoNome();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAluno.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir? \n\n Essa ação não podera ser desfeita!", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirAluno();
                    txtBuscar.Select();
                }
                CarregarAluno();
                dgvAluno.ClearSelection();
                dgvAluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void ExcluirAluno()
        {
            try
            {

                Banco banco = new Banco();
                banco.Conectar();

                var sql = "DELETE FROM matriculacfc where idAluno = @codigo;";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                banco.Desconectar();

            }
            catch
            {
                MessageBox.Show("Impossivel excluir. \n\n Ja foi vinculado a outra tabela.");
            }
        }


        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            if (status == "TODOS")
            {
                CarregarAluno();
            }
            else
            {
                CarregarAlunoStatus();
            }
            dgvAluno.ClearSelection();
            dgvAluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            CarregarAluno();
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvAluno[0, linhaAtual].Value);
            }
        }
    }
}
