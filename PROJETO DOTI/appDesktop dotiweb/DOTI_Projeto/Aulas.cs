using Google.Protobuf.WellKnownTypes;
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
    public partial class frmAulas : Form
    {
        int linhaAtualP, linhaAtualT, codigo, codigoT, codigoP;
        string status, nome;
        public frmAulas()
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
            frmCadAula cadAula = new frmCadAula();
            cadAula.funcao = "ADICIONAR";
            cadAula.Show();
            Hide();
        }

        private void dgvAulasT_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvAulasT.Sort(dgvAulasT.Columns[1], ListSortDirection.Ascending);
            dgvAulasT.ClearSelection();
        }
        private void dgvAulasP_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvAulasP.Sort(dgvAulasP.Columns[1], ListSortDirection.Ascending);
            dgvAulasP.ClearSelection();
        }

        private void CarregarAulasT()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAulaT,dataAulaT,statusAulaT,obs,nome,nomeFunc,nomeServico FROM aulat INNER JOIN funcionario ON aulat.idFuncionario = funcionario.idFuncionario INNER JOIN matriculacfc ON aulat.idAluno = matriculacfc.idAluno INNER JOIN servico ON aulat.idServico = servico.idServico ORDER BY dataAulaT";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAulasT.DataSource = dt;
            dgvAulasT.Columns[0].HeaderText = "Código";
            dgvAulasT.Columns[1].HeaderText = "Data";
            dgvAulasT.Columns[2].HeaderText = "Status";
            dgvAulasT.Columns[3].HeaderText = "obs";
            dgvAulasT.Columns[4].HeaderText = "Aluno";
            dgvAulasT.Columns[5].HeaderText = "Funcionario";
            dgvAulasT.Columns[6].HeaderText = "Servico";

            banco.Desconectar();
        }

        private void CarregarAulasP()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAulaP, dataAulaP, statusAulaP, obs, nome, nomeFunc, nomeServico, placa, modelo FROM aulap INNER JOIN funcionario ON aulap.idFuncionario = funcionario.idFuncionario INNER JOIN matriculacfc ON aulap.idAluno = matriculacfc.idAluno INNER JOIN servico ON aulap.idServico = servico.idServico INNER JOIN veiculos ON aulap.idVeiculo = veiculos.idVeiculo ORDER BY dataAulaP";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAulasP.DataSource = dt;
            dgvAulasP.Columns[0].HeaderText = "Código";
            dgvAulasP.Columns[1].HeaderText = "Data";
            dgvAulasP.Columns[2].HeaderText = "Status";
            dgvAulasP.Columns[3].HeaderText = "obs";
            dgvAulasP.Columns[4].HeaderText = "Aluno";
            dgvAulasP.Columns[5].HeaderText = "Funcionario";
            dgvAulasP.Columns[6].HeaderText = "Servico";
            dgvAulasP.Columns[7].HeaderText = "Placa";
            dgvAulasP.Columns[8].HeaderText = "Modelo";

            banco.Desconectar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadAula cadAula = new frmCadAula();
            cadAula.funcao = "ALTERAR";
            if (codigoP == 0)
            {
                if (linhaAtualT >= 0)
                {
                    cadAula.codigo = Convert.ToInt32(dgvAulasT[0, linhaAtualT].Value);
                }

                cadAula.aula = "TEORICA";
            }else if (codigoT == 0)
            {
                if (linhaAtualP >= 0)
                {
                    cadAula.codigo = Convert.ToInt32(dgvAulasP[0, linhaAtualP].Value);
                }

                cadAula.aula = "PRATICA";
            }
            cadAula.Show();
            Hide();
        }




        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAulasT.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir? \n\n Essa ação não podera ser desfeita!", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirAula();
                    txtBuscar.Select();
                }
                CarregarAulasP();
                CarregarAulasT();
                dgvAulasP.ClearSelection();
                dgvAulasT.ClearSelection();
                dgvAulasP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvAulasT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            nome = txtBuscar.Text;
            CarregarBuscarAulaP();
            CarregarBuscarAulaT();
            dgvAulasP.ClearSelection();
            dgvAulasP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAulasT.ClearSelection();
            dgvAulasT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = txtStatus.Text;
            if (status == "TODOS")
            {
                CarregarAulasT();
                CarregarAulasP();
            }
            else
            {
                CarregarAulaPStatus();
                CarregarAulaTStatus();
            }
            dgvAulasP.ClearSelection();
            dgvAulasP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAulasT.ClearSelection();
            dgvAulasT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CarregarBuscarAulaP()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAulaP, dataAulaP, statusAulaP, obs, nome, nomeFunc, nomeServico, placa, modelo FROM aulap INNER JOIN funcionario ON aulap.idFuncionario = funcionario.idFuncionario INNER JOIN matriculacfc ON aulap.idAluno = matriculacfc.idAluno INNER JOIN servico ON aulap.idServico = servico.idServico INNER JOIN veiculos ON aulap.idVeiculo = veiculos.idVeiculo WHERE nome LIKE '%" + nome + "%' ORDER BY dataAulaP";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAulasP.DataSource = dt;
            dgvAulasP.Columns[0].HeaderText = "Código";
            dgvAulasP.Columns[1].HeaderText = "Data";
            dgvAulasP.Columns[2].HeaderText = "Status";
            dgvAulasP.Columns[3].HeaderText = "obs";
            dgvAulasP.Columns[4].HeaderText = "Aluno";
            dgvAulasP.Columns[5].HeaderText = "Funcionario";
            dgvAulasP.Columns[6].HeaderText = "Servico";
            dgvAulasP.Columns[7].HeaderText = "Placa";
            dgvAulasP.Columns[8].HeaderText = "Modelo";

            banco.Desconectar();
        }
        private void CarregarBuscarAulaT()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAulaT,dataAulaT,statusAulaT,obs,nome,nomeFunc,nomeServico FROM aulat INNER JOIN funcionario ON aulat.idFuncionario = funcionario.idFuncionario INNER JOIN matriculacfc ON aulat.idAluno = matriculacfc.idAluno INNER JOIN servico ON aulat.idServico = servico.idServico WHERE nome LIKE '%" + nome + "%' ORDER BY dataAulaT";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAulasT.DataSource = dt;
            dgvAulasT.Columns[0].HeaderText = "Código";
            dgvAulasT.Columns[1].HeaderText = "Data";
            dgvAulasT.Columns[2].HeaderText = "Status";
            dgvAulasT.Columns[3].HeaderText = "obs";
            dgvAulasT.Columns[4].HeaderText = "Aluno";
            dgvAulasT.Columns[5].HeaderText = "Funcionario";
            dgvAulasT.Columns[6].HeaderText = "Servico";

            banco.Desconectar();
        }

        private void CarregarAulaPStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAulaP, dataAulaP, statusAulaP, obs, nome, nomeFunc, nomeServico, placa, modelo FROM aulap INNER JOIN funcionario ON aulap.idFuncionario = funcionario.idFuncionario INNER JOIN matriculacfc ON aulap.idAluno = matriculacfc.idAluno INNER JOIN servico ON aulap.idServico = servico.idServico INNER JOIN veiculos ON aulap.idVeiculo = veiculos.idVeiculo WHERE statusAulaP LIKE '%" + status + "%' ORDER BY dataAulaP";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAulasP.DataSource = dt;
            dgvAulasP.Columns[0].HeaderText = "Código";
            dgvAulasP.Columns[1].HeaderText = "Data";
            dgvAulasP.Columns[2].HeaderText = "Status";
            dgvAulasP.Columns[3].HeaderText = "obs";
            dgvAulasP.Columns[4].HeaderText = "Aluno";
            dgvAulasP.Columns[5].HeaderText = "Funcionario";
            dgvAulasP.Columns[6].HeaderText = "Servico";
            dgvAulasP.Columns[7].HeaderText = "Placa";
            dgvAulasP.Columns[8].HeaderText = "Modelo";

            banco.Desconectar();

        }

        private void CarregarAulaTStatus()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAulaT,dataAulaT,statusAulaT,obs,nome,nomeFunc,nomeServico FROM aulat INNER JOIN funcionario ON aulat.idFuncionario = funcionario.idFuncionario INNER JOIN matriculacfc ON aulat.idAluno = matriculacfc.idAluno INNER JOIN servico ON aulat.idServico = servico.idServico WHERE statusAulaT LIKE '%" + status + "%' ORDER BY dataAulaT";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAulasT.DataSource = dt;
            dgvAulasT.Columns[0].HeaderText = "Código";
            dgvAulasT.Columns[1].HeaderText = "Data";
            dgvAulasT.Columns[2].HeaderText = "Status";
            dgvAulasT.Columns[3].HeaderText = "obs";
            dgvAulasT.Columns[4].HeaderText = "Aluno";
            dgvAulasT.Columns[5].HeaderText = "Funcionario";
            dgvAulasT.Columns[6].HeaderText = "Servico";

            banco.Desconectar();
        }

        private void dgvAulasT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtualT = int.Parse(e.RowIndex.ToString());
            codigoP = 0;
            dgvAulasP.ClearSelection();
            if (linhaAtualT >= 0)
            {
                codigoT = Convert.ToInt32(dgvAulasT[0, linhaAtualT].Value);
            }

        }
        private void dgvAulasP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtualP = int.Parse(e.RowIndex.ToString());
            codigoT = 0;
            dgvAulasT.ClearSelection();
            if (linhaAtualP >= 0)
            {
                codigoP = Convert.ToInt32(dgvAulasP[0, linhaAtualP].Value);
            }

        }

        private void frmAulas_Load(object sender, EventArgs e)
        {
            CarregarAulasT();
            CarregarAulasP();
            dgvAulasP.ClearSelection();
            dgvAulasT.ClearSelection();
        }

        private void ExcluirAula()
        {
                try
                {
                    Banco banco = new Banco();
                    banco.Conectar();

                    var sql = "DELETE FROM aulat,aultap where idAulaT = @codigo OR idAulaP = @codigo;";
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
    }
}
