<?php

require_once("conexao.php");

$conexao = Conexao::LigarConexao();
$conexao->exec("SET NAMES utf8");

if(!$conexao){

    echo "Não esta conectado ao banco";

}

if(isset($_GET['idAulaT'])){

    $idAulaT = $_GET['idAulaT'];

    $query = $conexao->prepare("SELECT idAulaT,dataAulaT,statusAulaT,obs,nome,idFuncionario,nomeServico FROM aulat INNER JOIN servico ON aulat.idServico = servico.idServico INNER JOIN matriculacfc ON aulat.idAluno = matriculacfc.idAluno WHERE idAulaT = $idAulaT");

    $query->execute();

    $json = "[";

while ($resultado = $query->fetch()){

    if($json !="["){
        $json .= ",";
    }

    $json .= '{"Codigo":"'.$resultado["idAulaT"].'",';

        $json .= '"Data":"'.$resultado["dataAulaT"].'",';
    
        $json .= '"Status":"'.$resultado["statusAulaT"].'",';
    
        $json .= '"Obs":"'.$resultado["obs"].'",';
    
        $json .= '"Aluno":"'.$resultado["nome"].'",';
    
        $json .= '"Funcionario":"'.$resultado["idFuncionario"].'",';
    
        $json .= '"Servico":"'.$resultado["nomeServico"].'"}';
}//fim do while
$json .= "]";
echo $json;

}// fim do if isset

?>