<?php
//Permissões
 header("Access-Control-Allow-Origin: *");
 header("Content-Type: application/json; charset-UTF-8");
 header("Access-Control-Allow-Methods: POST, PUT, GET, OPTIONS, DELETE");



$data = file_get_contents('php://input');
$objData = json_decode($data);

$nome = $objData->nome;
$email = $objData->email;
$celular = $objData->celular;
$msg = $objData->msg;

$assunto = 'App Mobile';

//Remove as barras (\)
$nome = stripslashes($nome);
$email = stripslashes($email);
$celular = stripslashes($celular);
$msg = stripslashes($msg);
//Remove os espaços ( )
$nome = trim($nome);
$email = trim($email);
$celular = trim($celular);
$msg = trim($msg);

$dados;

        require_once("conexao.php");

        $conexao = Conexao::LigarConexao();
        $conexao->exec("SET NAMES utf8");

        if(($conexao) || ($nome !="")){
            $query = $conexao->prepare("INSERT INTO contato (nome, email, assunto, fone, mens) VALUES ('".$nome."', '".$email."', '".$assunto."', '".$celular."', '".$msg."')");
            $query->execute();

            $dados = array('mensagem' => 'Dados atualizados com sucesso');

            echo json_encode($dados);
        
        }else{

            $dados = array('mensagem' => 'Não foi possivel atualizar os dados.');

            echo json_encode($dados);
        }
?>