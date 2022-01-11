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
    public partial class frmServico : Form
    {
        int linhaAtual, codigo;
        public frmServico()
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
            frmCadServico cadServico = new frmCadServico();
            cadServico.funcao = "ADICIONAR";
            cadServico.Show();
            Hide();
        }

        private void dgvServico_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvServico.Sort(dgvServico.Columns[1], ListSortDirection.Ascending);
            dgvServico.ClearSelection();
        }

        private void CarregarServico()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idServico,nomeServico,valorServico,statusServico,fotoServico,fotoServico1,fotoServico2,fotoServico3,descServico,texto FROM servico ORDER BY nomeServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvServico.DataSource = dt;
            dgvServico.Columns[0].HeaderText = "Código";
            dgvServico.Columns[1].HeaderText = "Nome do Serviço";
            dgvServico.Columns[2].HeaderText = "Valor";
            dgvServico.Columns[3].HeaderText = "Status";
           // dgvServico.Columns[4].HeaderText = "Data de Cadastro";
            dgvServico.Columns[4].HeaderText = "Foto";
            dgvServico.Columns[5].HeaderText = "Foto1";
            dgvServico.Columns[6].HeaderText = "Foto2";
            dgvServico.Columns[7].HeaderText = "Foto3";
            dgvServico.Columns[8].HeaderText = "Descrição";
            dgvServico.Columns[9].HeaderText = "Texto";

            banco.Desconectar();

        }
        private void frmServico_Load(object sender, EventArgs e)
        {
            CarregarServico();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadServico cadServico = new frmCadServico();
            cadServico.funcao = "ALTERAR";
            if (linhaAtual >= 0)
            {
                cadServico.codigo = Convert.ToInt32(dgvServico[0, linhaAtual].Value);
            }

            cadServico.Show();
            Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvServico.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir? \n\n Essa ação não podera ser desfeita!", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirServico();
                    txtBuscar.Select();
                }
                CarregarServico();
                dgvServico.ClearSelection();
                dgvServico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void ExcluirServico()
        {
            try
            {
                Banco banco = new Banco();
                banco.Conectar();

                var sql = "DELETE FROM servico where idServico = @codigo;";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                banco.Desconectar();

            }
            catch
            {
                MessageBox.Show("Impossivel excluir. \n\n Ele ja foi vinculado a outra tabela.");
            }
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void txtBuscarServico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
