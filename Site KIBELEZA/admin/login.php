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

    $query = $conexao->prepare("SELECT * FROM cliente WHERE emailCli='$email' AND senhaCli='$senha'");

    $query->execute();

    $json = "";

    if($rs = $query->fetch()){
        if($json != ""){
            $json .= ",";
        }

        $json .= '{"Codigo":"'.$rs["idCliente"].'",';
        $json .= '"NomeCli":"'.$rs["nomeCli"].'",';
        $json .= '"EmailCli":"'.$rs["emailCli"].'",';
        $json .= '"SenhaCli":"'.$rs["senhaCli"].'",';
        $json .= '"StatusCli":"'.$rs["statusCli"].'",';
        $json .= '"DadaCadCli":"'.$rs["dataCadCli"].'",';
        $json .= '"FotoCli":"'.$rs["fotoCli"].'"}';

        $json = '{"msg": {"logado": "sim", "texto": "logado com sucesso!"}, "dados": '.$json.'}';

    }else{
        $json = '{"msg": {"logado": "nao", "texto": "Login ou Senha invalido"}, "dados": {'.$json.'}}';
    }

    echo $json;

    } //if empty
} //if isset

?>