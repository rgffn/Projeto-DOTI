<?php

require_once("conexao.php");

$conexao = Conexao::LigarConexao();
$conexao->exec("SET NAMES utf8");

if(!$conexao){

    echo "Não esta conectado ao banco";

}
if(isset($_GET['Aluno'])){

    $Aluno = $_GET['Aluno'];

$query = $conexao->prepare("SELECT idAulaT,dataAulaT,statusAulaT,obs,idAluno,idFuncionario,nomeServico FROM aulat INNER JOIN servico ON aulat.idServico = servico.idServico WHERE idAluno = $Aluno");

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

    $json .= '"Aluno":"'.$resultado["idAluno"].'",';

    $json .= '"Funcionario":"'.$resultado["idFuncionario"].'",';

    $json .= '"Servico":"'.$resultado["nomeServico"].'"}';
}
$json .= "]";
echo $json;
}else if(isset($_GET['Funcionario'])){

    $Funcionario = $_GET['Funcionario'];

$query = $conexao->prepare("SELECT idAulaT,dataAulaT,statusAulaT,obs,nome,idFuncionario,nomeServico FROM aulat INNER JOIN servico ON aulat.idServico = servico.idServico INNER JOIN matriculacfc ON aulat.idAluno = matriculacfc.idAluno WHERE idFuncionario = $Funcionario AND statusAulaT = 'PENDENTE'");

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
}
$json .= "]";
echo $json;
}// fim do if isset
?>