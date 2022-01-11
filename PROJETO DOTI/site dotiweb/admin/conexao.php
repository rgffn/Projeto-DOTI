<?php
    header("Access-Control-Allow-Origin: *");

    class Conexao{
    
        public static function LigarConexao(){
           //Local 
		   //$conn= new PDO("mysql:host=localhost;dbname=auto","root",""); //dbnam 'Nome do seu banco'
		   //Acesso Remoto 
		   //$conn = new PDO("mysql:host=sql10.freemysqlhosting.net;dbname=sql10362505","sql10362505","9Z6P7v6TfL"); dbname 'Nome do seu banco'
           //WebHost 
		   //$conn = new PDO("mysql:host=localhost;dbname=id14020240_auto","id14020240_root","OzQrGF+kSoIAC3YO"); dbname 'Nome do seu banco'
           //ohh boy
		   $conn = new PDO("mysql:host=108.167.132.240;dbname=dotiwe34_auto","dotiwe34_thecake","Doti7616"); //dbname='Nome do seu banco'
		   return $conn;
		}
    }
?>