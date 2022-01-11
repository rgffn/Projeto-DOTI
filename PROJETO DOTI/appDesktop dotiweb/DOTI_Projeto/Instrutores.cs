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
    public partial class frmInstrutores : Form
    {
        int linhaAtual, codigo;
        string nome, status;
        public frmInstrutores()
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
            frmCadInstrutor cadInstrutor = new frmCadInstrutor();
            cadInstrutor.funcao = "ADICIONAR";
            cadInstrutor.Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadInstrutor cadInstrutor = new frmCadInstrutor();
            if (linhaAtual >= 0)
            {
                cadInstrutor.codigoFuncionario = Convert.ToInt32(dgvInstrutor[0, linhaAtual].Value);
            }

            cadInstrutor.funcao = "ALTERAR";
            cadInstrutor.Show();

            Hide();
        }
        private void ExcluirInstrutor()
        {
            try
            {
                Banco banco = new Banco();
                banco.Conectar();

                var sql = "DELETE FROM funcionario where idFuncionario = @codigo;";
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
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvInstrutor.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir? \n\n Essa ação não podera ser desfeita!", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirInstrutor();
                    txtBuscar.Select();
                }
                CarregarFuncionario();
                dgvInstrutor.ClearSelection();
                dgvInstrutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            
        }

        private void dgvInstrutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvInstrutor[0, linhaAtual].Value);
            }

        }

        private void frmInstrutores_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvInstrutor[0, linhaAtual].Value);
            }

        }

        private void dgvInstrutor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvInstrutor.Sort(dgvInstrutor.Columns[1], ListSortDirection.Ascending);
            dgvInstrutor.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            nome = txtBuscar.Text;
            CarregarBuscarFuncionario();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            if (status == "TODOS")
            {
                CarregarFuncionario();
            }
            else
            {
                CarregarFuncionarioStatus();
            }
            dgvInstrutor.ClearSelection();
            dgvInstrutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CarregarBuscarFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFuncionario,nomeFunc,cpf,email,senha,cargo,status,foto FROM funcionario WHERE nomeFunc LIKE '%" + nome + "%' ORDER BY nomeFunc";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvInstrutor.DataSource = dt;
            dgvInstrutor.Columns[0].HeaderText = "Código";
            dgvInstrutor.Columns[1].HeaderText = "Nome do Funcionário";
            dgvInstrutor.Columns[2].HeaderText = "Cpf";
            dgvInstrutor.Columns[3].HeaderText = "E-Mail";
            dgvInstrutor.Columns[4].HeaderText = "Senha";
            dgvInstrutor.Columns[5].HeaderText = "Cargo";
            dgvInstrutor.Columns[6].HeaderText = "Status";
            dgvInstrutor.Columns[7].HeaderText = "Foto";

            banco.Desconectar();
        }
        private void CarregarFuncionarioStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFuncionario,nomeFunc,cpf,email,senha,cargo,status,foto FROM funcionario WHERE status LIKE '%" + status + "%' ORDER BY nomeFunc";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvInstrutor.DataSource = dt;
            dgvInstrutor.Columns[0].HeaderText = "Código";
            dgvInstrutor.Columns[1].HeaderText = "Nome do Funcionário";
            dgvInstrutor.Columns[2].HeaderText = "Cpf";
            dgvInstrutor.Columns[3].HeaderText = "E-Mail";
            dgvInstrutor.Columns[4].HeaderText = "Senha";
            dgvInstrutor.Columns[5].HeaderText = "Cargo";
            dgvInstrutor.Columns[6].HeaderText = "Status";
            dgvInstrutor.Columns[7].HeaderText = "Foto";

            banco.Desconectar();
        }

        private void CarregarFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFuncionario,nomeFunc,cpf,email,senha,cargo,status,foto FROM funcionario ORDER BY nomeFunc";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvInstrutor.DataSource = dt;
            dgvInstrutor.Columns[0].HeaderText = "Código";
            dgvInstrutor.Columns[1].HeaderText = "Nome do Funcionário";
            dgvInstrutor.Columns[2].HeaderText = "Cpf";
            dgvInstrutor.Columns[3].HeaderText = "E-Mail";
            dgvInstrutor.Columns[4].HeaderText = "Senha";
            dgvInstrutor.Columns[5].HeaderText = "Cargo";
            dgvInstrutor.Columns[6].HeaderText = "Status";
            dgvInstrutor.Columns[7].HeaderText = "Foto";

            banco.Desconectar();
        }
    }
}
