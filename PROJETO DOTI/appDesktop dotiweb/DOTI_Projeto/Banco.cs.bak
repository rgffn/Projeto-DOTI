using MySql.Data.MySqlClient;
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTI_Projeto
{
    public class Banco
    {
        //string db = "SERVER=localhost;USER=root;DATABASE=auto";
        //string db = "SERVER=108.167.132.240;uid=dotiwe34_thecake;pwd=Doti7616;DATABASE=dotiwe34_auto";
        string db = "SERVER=dotiweb.com; DATABASE=dotiwe34_auto; UID=dotiwe34_thecake; PWD=Doti7616; PORT=3306";
        //string db = "Persist Security Info=False;server=108.167.132.240;userid=dotiwe34_thecake;password=Doti7616;database=dotiwe34_auto";
        //string db = "Server=sql10.freemysqlhosting.net;Database=sql10362505;Uid=sql10362505;Pwd=9Z6P7v6TfL;";
        public MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar conectar com o banco de dados", "ERRO!");
            }
        }

        public void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar desconectar o banco de dados", "ERRO!");
            }
        }
        public static string nivel;
    }
}
