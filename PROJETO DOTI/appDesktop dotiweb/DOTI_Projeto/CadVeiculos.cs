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
    public partial class frmCadVeiculos : Form
    {
        public string funcao;
        private int codigo;
        string placa, modelo, ano, renavam, chassi, empresa, numero, tipo, desc, cpf, cargo;
        int codigoEmpresa, linhaAtual, codigoFone;
        public int codigoVeiculo;

        private void frmCadVeiculos_Load(object sender, EventArgs e)
        {
            if (funcao == "ALTERAR")
            {
                CarregarDadosVeiculos();
            }
            if (funcao == "ADICIONAR")
            {
                txtPlaca.Select();
            }
        }
        private void AtualizarVeiculos()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE veiculos SET placa=@placa,modelo=@modelo,ano=@ano,renavam=@renavam,chassi=@chassi WHERE idVeiculo = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@renavam", renavam);
            cmd.Parameters.AddWithValue("@chassi", chassi);
            cmd.Parameters.AddWithValue("@codigo", codigoVeiculo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Atualizado com sucesso!", "ATUALIZAÇÃO");
        }
        private void CarregarDadosVeiculos()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM veiculos WHERE idVeiculo = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigoVeiculo);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
                placa = reader.GetString(1);
                modelo = reader.GetString(2);
                ano = reader.GetString(3);
                renavam = reader.GetString(4);
                chassi = reader.GetString(5);

                banco.Desconectar();
                txtCodigo.Text = codigo.ToString();
                txtPlaca.Text = placa;
                txtModelo.Text = modelo;
                txtAno.Text = ano;
                txtRenavam.Text = renavam;
                txtChassi.Text = chassi;
            }
        }
        private void InserirVeiculos()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO veiculos(idVeiculo,placa,modelo,ano,renavam,chassi) VALUES (DEFAULT,@placa,@modelo,@ano,@renavam,@chassi)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@renavam", renavam);
            cmd.Parameters.AddWithValue("@chassi", chassi);
            cmd.ExecuteNonQuery();

            banco.Desconectar();


            MessageBox.Show("Cadastrado com sucesso!", "CADASTRO");
        }
        private void CarregarVeiculos()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT MAX(idVeiculo) FROM veiculos";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigoVeiculo = reader.GetInt32(0);
            }
            //MessageBox.Show(codigo.ToString());

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            placa = txtPlaca.Text;
            modelo = txtModelo.Text;
            ano = txtAno.Text;
            renavam = txtRenavam.Text;
            chassi = txtChassi.Text;

            if (funcao == "ADICIONAR")
            {
                InserirVeiculos();
                CarregarVeiculos();
            }
            else if (funcao == "ALTERAR")
            {
                AtualizarVeiculos();
                CarregarVeiculos();
            }
            btnSalvar.Enabled = false;
        }


        public frmCadVeiculos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmVeiculos veiculos = new frmVeiculos();
            veiculos.Show();
            Close();
        }
    }
}
