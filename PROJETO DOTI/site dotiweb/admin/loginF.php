<?php
if(isset($_GET['email']) || isset($_GET['senha'])){

    if(!empty($_GET['email']) || !empty($_GET['senha'])){

        require_once("conexao.php");

        $conexao = Conexao::LigarConexao();
        $conexao->exec("SET NAMES utf8");

        if(!$conexao){

            echo "Não esta conectado ao banco";
        
        }

    $email = $_GET['email'];
    $senha = $_GET['senha'];

    $query = $conexao->prepare("SELECT * FROM funcionario WHERE email='$email' AND senha='$senha'");

    $query->execute();

    $json = "";

    if($rs = $query->fetch()){
        if($json != ""){
            $json .= ",";
        }

        $json .= '{"Codigo":"'.$rs["idFuncionario"].'",';
        $json .= '"Nome":"'.$rs["nomeFunc"].'",';
        $json .= '"Cpf":"'.$rs["cpf"].'",';
        $json .= '"Email":"'.$rs["email"].'",';
        $json .= '"Senha":"'.$rs["senha"].'",';
        $json .= '"Cargo":"'.$rs["cargo"].'",';
        $json .= '"Status":"'.$rs["status"].'",';
        $json .= '"Foto":"'.$rs["foto"].'"}';

        $json = '{"msg": {"logado": "sim", "texto": "logado com sucesso!"}, "dados": '.$json.'}';

    }else{
        $json = '{"msg": {"logado": "nao", "texto": "Login ou Senha invalido"}, "dados": {'.$json.'}}';
    }

    echo $json;

    } //if empty
} //if isset

?>