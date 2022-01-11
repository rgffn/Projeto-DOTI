using MySql.Data.MySqlClient;
using FTP_Upload;
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
    public partial class frmCadAluno : Form
    {
        public string funcao;
        string nome, email, senha, status, foto, numero, tipo, desc, cpf, atFoto;
        DateTime data = DateTime.Now;
        public int codigo;
        int codigoFone, linhaAtual;

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
            ofdFoto.InitialDirectory = @"C:\Users\Rg\Xampp\htdocs\auto\admin\upload\clientes";
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
                    //MessageBox.Show(caminhoFoto.ToString());
                }
                catch (SecurityException ex)
                {
                    //Mensagem
                    MessageBox.Show("Erro de Segurança - Fale com o Administrador \n\n Mensagem:" + ex.Message + "\n\n + Detalhe: " + ex.StackTrace);
                    //MessageBox.Show(caminhoFoto.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Voce não tem permissão para ler o arquivo. \n\n" + ex.Message);
                    //MessageBox.Show(caminhoFoto.ToString());
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

        private void InserirAluno()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO matriculacfc(idAluno, nome, cpf, email, senha,data,status,foto) VALUES (DEFAULT,@nome,@cpf,@email,@senha,@data,@status,@foto)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@data", data);
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

            MessageBox.Show("Cadastrado com sucesso!", "CADASTRO");
        }

        private void CarregarFone()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFone,numero,tipoFone,descFone FROM fonealu WHERE idAluno = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvFone.DataSource = dt;
            dgvFone.Columns[0].HeaderText = "Cod. Fone";
            dgvFone.Columns[0].Width = 0;
            dgvFone.Columns[1].HeaderText = "Número";
            dgvFone.Columns[2].HeaderText = "Tipo";
            dgvFone.Columns[3].HeaderText = "Descrição";

            banco.Desconectar();
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

        private void CarregarDadosAluno()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM matriculacfc WHERE idAluno = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
                nome = reader.GetString(1);
                cpf = reader.GetString(2);
                email = reader.GetString(3);
                senha = reader.GetString(4);
                data = DateTime.Parse(reader.GetString(5));
                status = reader.GetString(6);
                foto = reader.GetString(7);
                foto = foto.Remove(0, 22);

                banco.Desconectar();
                txtCodigo.Text = codigo.ToString();
                txtNome.Text = nome;
                txtCpf.Text = cpf.ToString();
                txtEmail.Text = email;
                txtSenha.Text = senha;
                cmbStatus.Text = status;
                txtDataCad.Text = Convert.ToString(data);
                //MessageBox.Show(enderecoServidorFTP.ToString());
                //MessageBox.Show(foto.ToString());
                pctFoto.BackgroundImage = ByteToImage(GetImgByte(enderecoServidorFTP + foto));
                txtFoto.Text = enderecoServidorFTP + foto;
            }
        }

        private void frmCadAluno_Load(object sender, EventArgs e)
        {
            if (funcao == "ALTERAR")
            {
                CarregarFone();
                CarregarDadosAluno();
                TelefoneContato.Enabled = true;
            }
            if (funcao == "ADICIONAR")
            {
                txtNome.Select();
                txtCpf.Enabled = true;
                pctFoto.BackgroundImage = Properties.Resources.foto;
                txtDataCad.Text = data.ToString();
                data = Convert.ToDateTime(txtDataCad.Text);
            }
        }

        private void btnPSalvar_Click(object sender, EventArgs e)
        {
            numero = mtxtNumero.Text;
            tipo = cmbTipo.Text;
            desc = cmbDesc.Text;
            if (funcao == "ADICIONAR FONE")
            {
                InserirFone();
                mtxtNumero.Clear();
                cmbTipo.Text = "";
                cmbDesc.Text = "";

                mtxtNumero.Select();
            }
            else if (funcao == "ALTERAR FONE")
            {
                AtualizarFone();
                btnPFechar.PerformClick();
            }
            btnPSalvar.Enabled = false;
        }

        private void CarregarDadosFone()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM fonealu WHERE idFone = @codigoFone";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigoFone", codigoFone);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigoFone = reader.GetInt32(0);
                numero = reader.GetString(1);
                tipo = reader.GetString(2);
                desc = reader.GetString(3);
            }
            banco.Desconectar();
            txtCodigoFone.Text = codigoFone.ToString();
            mtxtNumero.Text = numero;
            cmbTipo.Text = tipo;
            cmbDesc.Text = desc;
        }

        private void AtualizarFone()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE fonealu SET numero = @numero, tipoFone = @tipo, descFone = @desc WHERE idFone = @codigoFone ";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@codigoFone", codigoFone);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Telefone atualizado com sucesso!", "ATUALIZAÇÃO TELEFONE CLIENTE");
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            funcao = "ALTERAR FONE";
            codigoFone = Convert.ToInt32(dgvFone[0, linhaAtual].Value);
            btnPSalvar.Enabled = true;
            CarregarDadosFone();
            frmCadFone.Visible = true;
            //MessageBox.Show(codigoFone.ToString());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFone.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir esse Telefone? \n\n Essa ação não podera ser desfeita!", "EXCLUIR TELEFONE", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Excluir();

                }
                CarregarFone();
                dgvFone.ClearSelection();
                dgvFone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void Excluir()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "DELETE FROM fonealu where idFone = @codigo;";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();
        }


        private void dgvFone_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFone.Sort(dgvFone.Columns[1], ListSortDirection.Ascending);
            dgvFone.ClearSelection();
        }

        private void dgvFone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigoFone = Convert.ToInt32(dgvFone[0, linhaAtual].Value);
            }

        }

        private void AtualizarAluno()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE matriculacfc SET nome = @nome, cpf = @cpf, email = @email, senha = @senha, status = @status WHERE idAluno = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Atualizado com sucesso!", "ATUALIZAÇÃO");
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            cpf = txtCpf.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;
            status = cmbStatus.Text;

            if (funcao == "ADICIONAR")
            {
                InserirAluno();
                CarregarAluno();
            }
            else if (funcao == "ALTERAR")
            {
                AtualizarAluno();
                if (atFoto == "S")
                {
                    AtualizarFoto();
                }

            }
            btnSalvar.Enabled = false;
            TelefoneContato.Enabled = true;
        }

        private void AtualizarFoto()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE matriculacfc SET foto = @foto WHERE idAluno = @codigo";
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
                        //MessageBox.Show(urlArquivoEnviar.ToString());
                        //MessageBox.Show(txtFoto.Text.ToString());
                        //MessageBox.Show(enderecoServidorFTP.ToString());
                        //MessageBox.Show(foto.ToString());
                        //MessageBox.Show(caminhoFoto.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show(urlArquivoEnviar.ToString());
                        //MessageBox.Show(txtFoto.Text.ToString());
                        //MessageBox.Show(enderecoServidorFTP.ToString());
                        //MessageBox.Show(foto.ToString());
                        //MessageBox.Show(caminhoFoto.ToString());
                    }
                }
            }

        }
        private void CarregarAluno()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT MAX(idAluno) FROM matriculacfc";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
            }
            //MessageBox.Show(codigo.ToString());
        }

        private void InserirFone()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO fonealu(idFone,numero,tipoFone,descFone,idAluno) VALUES (DEFAULT,@numero,@tipo,@desc,@codigo)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Telefone cadastrado com sucesso!", "TELEFONE");
        }

        private void btnPFechar_Click(object sender, EventArgs e)
        {
            frmCadFone.Visible = false;
            CarregarFone();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            funcao = "ADICIONAR FONE";
            btnPSalvar.Enabled = true;
            frmCadFone.Visible = true;
            mtxtNumero.Select();
        }
        public frmCadAluno()
        {
            InitializeComponent(); 
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmAluno aluno = new frmAluno();
            aluno.Show();
            Close();
        }

    }
}
