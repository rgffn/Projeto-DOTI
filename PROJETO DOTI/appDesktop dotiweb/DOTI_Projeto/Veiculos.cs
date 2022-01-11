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
    public partial class frmVeiculos : Form
    {
        int linhaAtual, codigo;
        public frmVeiculos()
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
            frmCadVeiculos cadVeiculos = new frmCadVeiculos();
            cadVeiculos.funcao = "ADICIONAR";
            cadVeiculos.Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadVeiculos cadVeiculos = new frmCadVeiculos();
            if (linhaAtual >= 0)
            {
                cadVeiculos.codigoVeiculo = Convert.ToInt32(dgvVeiculos[0, linhaAtual].Value);
            }

            cadVeiculos.funcao = "ALTERAR";
            cadVeiculos.Show();

            Hide();
        }
        private void ExcluirVeiculo()
        {
            try
            {
                Banco banco = new Banco();
                banco.Conectar();

                var sql = "DELETE FROM veiculos where idVeiculo = @codigo;";
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
            if (dgvVeiculos.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir? \n\n Essa ação não podera ser desfeita!", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirVeiculo();
                    txtBuscar.Select();
                }
                CarregarVeiculos();
                dgvVeiculos.ClearSelection();
                dgvVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

        }

        private void CarregarVeiculos()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idVeiculo,placa,modelo,ano,renavam,chassi FROM veiculos ORDER BY idVeiculo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvVeiculos.DataSource = dt;
            dgvVeiculos.Columns[0].HeaderText = "Código";
            dgvVeiculos.Columns[1].HeaderText = "Placa";
            dgvVeiculos.Columns[2].HeaderText = "Modelo";
            dgvVeiculos.Columns[3].HeaderText = "Ano";
            dgvVeiculos.Columns[4].HeaderText = "Renavem";
            dgvVeiculos.Columns[5].HeaderText = "Chassi";

            banco.Desconectar();
        }

        private void frmVeiculos_Load(object sender, EventArgs e)
        {
            CarregarVeiculos();
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvVeiculos[0, linhaAtual].Value);
            }

        }

        private void dgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigo = Convert.ToInt32(dgvVeiculos[0, linhaAtual].Value);
            }

        }

        private void dgvVeiculos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvVeiculos.Sort(dgvVeiculos.Columns[1], ListSortDirection.Ascending);
            dgvVeiculos.ClearSelection();
        }
    }
}
