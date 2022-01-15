﻿using MySql.Data.MySqlClient;
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
