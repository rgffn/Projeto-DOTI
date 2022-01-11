<?php
//Permissões
 header("Access-Control-Allow-Origin: *");
 header("Content-Type: application/json; charset-UTF-8");
 header("Access-Control-Allow-Methods: POST, PUT, GET, OPTIONS, DELETE");



$data = file_get_contents('php://input');
$objData = json_decode($data);

$status = $objData->status;
$codAula = $objData->codAula;

//Remove as barras (\)
$status = stripslashes($status);
$codAula = stripslashes($codAula);

//Remove os espaços ( )
$status = trim($status);
$codAula = trim($codAula);

$dados;

        require_once("conexao.php");

        $conexao = Conexao::LigarConexao();
        $conexao->exec("SET NAMES utf8");

        if(($conexao) || ($status !="")){
            $query = $conexao->prepare("UPDATE aulat SET statusAulaT='".$status."' WHERE idAulaT='".$codAula."'");
            $query->execute();

            $dados = array('mensagem' => 'Dados atualizados com sucesso');

            echo json_encode($dados);
        
        }else{

            $dados = array('mensagem' => 'Não foi possivel atualizar os dados.');

            echo json_encode($dados);
        }
?>