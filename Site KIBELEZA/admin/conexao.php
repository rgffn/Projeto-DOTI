<?php
    header("Access-Control-Allow-Origin: *");

    class Conexao{
    
        public static function LigarConexao(){
            $conn = new PDO("mysql:host=localhost;dbname=kibelezati07","root","");
            return $conn;
        }
    }


?>