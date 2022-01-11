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
    public partial class frmCadAula : Form
    {
        public string funcao, aula;
        string status,servico,aluno,funcionario,obs,placa,veiculo, tipo;
        string data;
        public int codigo;
        int codigoAluno, codigoFuncionario, codigoServico, codigoVeiculo;

        private void InserirAulaP()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO aulap(idAulaP, dataAulaP, statusAulaP, obs, idAluno, idFuncionario, idServico, idVeiculo) VALUES (Default,@data,@status,@obs,@aluno,@funcionario,@servico,@veiculo)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@obs", obs);
            cmd.Parameters.AddWithValue("@aluno", codigoAluno);
            cmd.Parameters.AddWithValue("@funcionario", codigoFuncionario);
            cmd.Parameters.AddWithValue("@servico", codigoServico);
            cmd.Parameters.AddWithValue("@veiculo", codigoVeiculo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Cadastrado com sucesso!", "CADASTRO");
        }
        private void InserirAulaT()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO aulat(idAulaT, dataAulaT, statusAulaT, obs, idAluno, idFuncionario, idServico) VALUES (Default,@data,@status,@obs,@aluno,@funcionario,@servico)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@obs", obs);
            cmd.Parameters.AddWithValue("@aluno", codigoAluno);
            cmd.Parameters.AddWithValue("@funcionario", codigoFuncionario);
            cmd.Parameters.AddWithValue("@servico", codigoServico);

            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Cadastrado com sucesso!", "CADASTRO");
        }
        private void CarregarDadosAulaT()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAulaT, dataAulaT, statusAulaT, obs, nome, nomeFunc, nomeServico FROM aulat INNER JOIN matriculacfc ON aulat.idAluno = matriculacfc.idAluno INNER JOIN funcionario ON aulat.idFuncionario = funcionario.idFuncionario INNER JOIN servico ON aulat.idServico = servico.idServico WHERE idAulaT = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
                data = reader.GetString(1);
                status = reader.GetString(2);
                obs = reader.GetString(3);
                aluno = reader.GetString(4);
                funcionario = reader.GetString(5);
                servico = reader.GetString(6);

                txtCodigo.Text = codigo.ToString();
                txtDataInicio.Text = data.ToString();
                cmbStatus.Text = status;
                txtObs.Text = obs;
                cmbAluno.Text = aluno;
                cmbFuncionario.Text = funcionario;
                cmbServico.Text = servico;
                cmbTipo.Text = "TEORICA";

                banco.Desconectar();
            }
        }
        private void CarregarDadosAulaP()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAulaP, dataAulaP, statusAulaP, obs, nome, nomeFunc, nomeServico, placa FROM aulap INNER JOIN matriculacfc ON aulap.idAluno = matriculacfc.idAluno INNER JOIN funcionario ON aulap.idFuncionario = funcionario.idFuncionario INNER JOIN servico ON aulap.idServico = servico.idServico INNER JOIN veiculos ON aulap.idVeiculo = veiculos.idVeiculo WHERE idAulaP = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
                data = reader.GetString(1);
                status = reader.GetString(2);
                obs = reader.GetString(3);
                aluno = reader.GetString(4);
                funcionario = reader.GetString(5);
                servico = reader.GetString(6);
                placa = reader.GetString(7);

                banco.Desconectar();
                txtCodigo.Text = codigo.ToString();
                txtDataInicio.Text = data.ToString();
                cmbStatus.Text = status;
                txtObs.Text = obs;
                cmbAluno.Text = aluno;
                cmbFuncionario.Text = funcionario;
                cmbServico.Text = servico;
                cmbTipo.Text = "PRATICA";
                cmbVeiculo.Text = placa;
            }
        }
        private void AtualizarAulaP()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE aulap SET dataAulaP=@data,statusAulaP=@status,obs=@obs,idAluno=@aluno,idFuncionario=@funcionario,idServico=@servico,idVeiculo=@veiculo WHERE idAulaP = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@obs", obs);
            cmd.Parameters.AddWithValue("@aluno", codigoAluno);
            cmd.Parameters.AddWithValue("@funcionario", codigoFuncionario);
            cmd.Parameters.AddWithValue("@servico", codigoServico);
            cmd.Parameters.AddWithValue("@veiculo", codigoVeiculo);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Atualizado com sucesso!", "ATUALIZAÇÃO");
        }
        private void AtualizarAulaT()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE aulat SET dataAulaT=@data,statusAulaT=@status,obs=@obs,idAluno=@aluno,idFuncionario=@funcionario,idServico=@servico WHERE idAulaT = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@obs", obs);
            cmd.Parameters.AddWithValue("@aluno", codigoAluno);
            cmd.Parameters.AddWithValue("@funcionario", codigoFuncionario);
            cmd.Parameters.AddWithValue("@servico", codigoServico);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Atualizado com sucesso!", "ATUALIZAÇÃO");
        }
        private void CarregarAluno()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAluno,nome FROM matriculacfc";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbAluno.DataSource = dt;
            cmbAluno.ValueMember = "idAluno";
            cmbAluno.DisplayMember = "nome";
            cmbAluno.Text = string.Empty;

            banco.Desconectar();
        }
        private void CarregarAlunoSelecionado()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idAluno,nome FROM matriculacfc WHERE nome = @nome";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", aluno);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigoAluno = reader.GetInt32(0);
            }
            banco.Desconectar();
        }
        private void CarregarFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFuncionario,nomeFunc FROM funcionario";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbFuncionario.DataSource = dt;
            cmbFuncionario.ValueMember = "idFuncionario";
            cmbFuncionario.DisplayMember = "nomeFunc";
            cmbFuncionario.Text = string.Empty;

            banco.Desconectar();
        }
        private void CarregarFuncionarioSelecionado()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFuncionario,nomeFunc FROM funcionario WHERE nomeFunc = @nome";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", funcionario);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigoFuncionario = reader.GetInt32(0);
            }
            banco.Desconectar();
        }
        private void CarregarServico()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idServico,nomeServico FROM servico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbServico.DataSource = dt;
            cmbServico.ValueMember = "idServico";
            cmbServico.DisplayMember = "nomeServico";
            cmbServico.Text = string.Empty;

            banco.Desconectar();
        }
        private void CarregarServicoSelecionado()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idServico,nomeServico FROM servico WHERE nomeServico = @nome";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", servico);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigoServico = reader.GetInt32(0);
            }
            banco.Desconectar();
        }
        private void CarregarVeiculo()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idVeiculo,placa FROM veiculos";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbVeiculo.DataSource = dt;
            cmbVeiculo.ValueMember = "idVeiculo";
            cmbVeiculo.DisplayMember = "placa";
            cmbVeiculo.Text = string.Empty;

            banco.Desconectar();
        }
        private void CarregarVeiculoSelecionado()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idVeiculo,placa FROM veiculos WHERE placa = @nome";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", veiculo);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigoVeiculo = reader.GetInt32(0);
            }
            banco.Desconectar();
        }


        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = cmbTipo.Text;
            if (tipo == "PRATICA")
            {
                aula = "PRATICA";
                cmbVeiculo.Enabled = true;
            }else if (tipo == "TEORICA")
            {
                aula = "TEORICA";
                cmbVeiculo.Enabled = false;
            }
        }

        public frmCadAula()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmAulas aulas = new frmAulas();
            aulas.Show();
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }
        private void CarregarAulaT()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT MAX(idAulaT) FROM aulat";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
            }
            //MessageBox.Show(codigo.ToString());
        }
        private void CarregarAulaP()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT MAX(idAulaP) FROM aulap";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
            }
            //MessageBox.Show(codigo.ToString());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            data = txtDataInicio.Text;
            status = cmbStatus.Text;
            obs = txtObs.Text;
            aluno = cmbAluno.Text;
            funcionario = cmbFuncionario.Text;
            servico = cmbServico.Text;
            if (aula == "PRATICA") {
                veiculo = cmbVeiculo.Text;
                CarregarVeiculoSelecionado();
            }

            CarregarAlunoSelecionado();
            CarregarFuncionarioSelecionado();
            CarregarServicoSelecionado();



            if (funcao == "ADICIONAR")
            {
                if (aula == "PRATICA")
                {
                    InserirAulaP();
                }
                if (aula == "TEORICA")
                {
                    InserirAulaT();
                }
                btnSalvar.Enabled = false;

                var msg = MessageBox.Show("Deseja inserir outra aula?", "CADASTRAR", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    txtObs.Text = string.Empty;
                    txtDataInicio.Text = string.Empty;
                    cmbStatus.Text = string.Empty;
                    txtObs.Text = string.Empty;
                    cmbAluno.Text = string.Empty;
                    cmbFuncionario.Text = string.Empty;
                    cmbServico.Text = string.Empty;
                    txtObs.Select();
                    btnSalvar.Enabled = true;
                }
            }
            else if (funcao == "ALTERAR")
            {
                if (aula == "PRATICA")
                {
                    AtualizarAulaP();
                }
                if (aula == "TEORICA")
                {
                    AtualizarAulaT();
                }
                btnSalvar.Enabled = false;
            }
        }

        private void frmCadAula_Load(object sender, EventArgs e)
        {
            
            if (funcao == "ALTERAR")
            {
                CarregarAluno();
                CarregarFuncionario();
                CarregarServico();
                CarregarVeiculo();

                if (aula == "TEORICA")
                {
                    CarregarDadosAulaT();
                    cmbTipo.Text = aula;
                }
                if (aula == "PRATICA")
                {
                    CarregarDadosAulaP();
                    cmbTipo.Text = aula;
                }
            }
            if (funcao == "ADICIONAR")
            {
                txtObs.Select();
                CarregarAluno();
                CarregarFuncionario();
                CarregarServico();
                CarregarVeiculo();
            }
            //MessageBox.Show(codigo.ToString());

        }
    }
}
