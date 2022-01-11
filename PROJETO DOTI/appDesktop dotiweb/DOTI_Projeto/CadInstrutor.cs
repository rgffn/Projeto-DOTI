using FTP_Upload;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTI_Projeto
{
    public partial class frmCadInstrutor : Form
    {

        public string funcao, empresa1;
        private int codigo;
        string nome, email, senha, nivel, status, empresa, numero, tipo, desc, cpf, cargo, atFoto, foto;
        int codigoEmpresa, linhaAtual, codigoFone;
        public int codigoFuncionario;

        //Fotos FTP
        string enderecoServidorFTP = "ftp://127.0.0.1/admin/upload/clientes/";
        string usuarioFTP = "aeg";
        string senhaFTP = "123";
        string caminhoFoto;

        //Validação FTP
        private bool ValidarFTP()
        {
            if (string.IsNullOrEmpty(usuarioFTP) || string.IsNullOrEmpty(senhaFTP) || string.IsNullOrEmpty(enderecoServidorFTP))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void pctFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto = new OpenFileDialog();
            ofdFoto.Multiselect = false;

            //ofdFoto.FileName = "";
            ofdFoto.InitialDirectory = @"C:\Users\theca\Xampp\htdocs\auto\admin\upload\clientes";
            ofdFoto.Title = "Selecione uma Foto";
            ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg; *.png";
            ofdFoto.CheckFileExists = true;
            ofdFoto.CheckPathExists = true;
            ofdFoto.RestoreDirectory = true;

            DialogResult dr = ofdFoto.ShowDialog();

            pctFoto.BackgroundImage = Image.FromFile(ofdFoto.FileName);
            caminhoFoto = "admin/upload/clientes/" + System.IO.Path.GetFileName(ofdFoto.FileName); //clientes/usuario.png

            txtFoto.Text = caminhoFoto;

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    atFoto = "S";
                    txtFoto.Text = ofdFoto.FileName;
                }
                catch (SecurityException ex)
                {
                    //Mensagem
                    //MessageBox.Show("Erro de Segurança - Fale com o Administrador \n\n Mensagem:" + ex.Message + "\n\n + Detalhe: " + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Voce não tem permissão para ler o arquivo. \n\n" + ex.Message);
                }
            }

            //ofdFoto.ShowDialog();

            //if (ofdFoto.FileName != "")
            //{
            //    pctFoto.BackgroundImage = Image.FromFile(ofdFoto.FileName);
            //    foto = ofdFoto.FileName;
            //    foto = foto.Remove(0, 53);
            //    txtFoto.Text = foto;
            //}
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public byte[] GetImgByte(string ftpFilePath)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(usuarioFTP, senhaFTP);
            byte[] imageByte = ftpClient.DownloadData(ftpFilePath);
            return imageByte;
        }

        private void frmCadInstrutor_Load(object sender, EventArgs e)
        {
            if (funcao == "ALTERAR")
            {
                CarregarDadosInstrutor();
            }
            if (funcao == "ADICIONAR")
            {
                txtNome.Select();
            }
        }
        private void AtualizarInstrutor()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE funcionario SET nomeFunc=@nome,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,status=@status WHERE idFuncionario = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@codigo", codigoFuncionario);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Atualizado com sucesso!", "ATUALIZAÇÃO");
        }

        private void CarregarDadosInstrutor()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM funcionario WHERE idFuncionario = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigoFuncionario);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
                nome = reader.GetString(1);
                cpf = reader.GetString(2);
                email = reader.GetString(3);
                senha = reader.GetString(4);
                cargo = reader.GetString(5);
                status = reader.GetString(6);
                foto = reader.GetString(7);
                foto = foto.Remove(0, 22);

                banco.Desconectar();
                txtCodigo.Text = codigo.ToString();
                txtNome.Text = nome;
                txtCpf.Text = cpf;
                txtEmail.Text = email;
                txtSenha.Text = senha;
                cmbCargo.Text = cargo;
                cmbStatus.Text = status;
                //MessageBox.Show(enderecoServidorFTP.ToString());
                //MessageBox.Show(foto.ToString());
                pctFoto.BackgroundImage = ByteToImage(GetImgByte(enderecoServidorFTP + foto));
                txtFoto.Text = enderecoServidorFTP + foto;
            }
        }
        private void InserirInstrutor()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO funcionario(idFuncionario,nomeFunc,cpf,email,senha,cargo,status,foto) VALUES (DEFAULT,@nome,@cpf,@email,@senha,@cargo,@status,@foto)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@foto", caminhoFoto);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(txtFoto.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto.Text);

                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show("Funcionário cadastrado com sucesso!", "CADASTRO DE FUNCIONÁRIO");
        }

        private void CarregarInstrutor()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT MAX(idFuncionario) FROM funcionario";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigoFuncionario = reader.GetInt32(0);
            }
            //MessageBox.Show(codigo.ToString());

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            cpf = txtCpf.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;
            cargo = cmbCargo.Text;
            status = cmbStatus.Text;

            if (funcao == "ADICIONAR")
            {
                InserirInstrutor();
                CarregarInstrutor();
            }
            else if (funcao == "ALTERAR")
            {
                AtualizarInstrutor();
                CarregarInstrutor();
                if (atFoto == "S")
                {
                    AtualizarFoto();
                }
            }
            btnSalvar.Enabled = false;
        }
        private void AtualizarFoto()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE funcionario SET foto = @foto WHERE idFuncionario = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@foto", caminhoFoto);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(txtFoto.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto.Text);

                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public frmCadInstrutor()
        {
            InitializeComponent(); 
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmInstrutores instrutores = new frmInstrutores();
            instrutores.Show();
            Close();
        }
    }
}
