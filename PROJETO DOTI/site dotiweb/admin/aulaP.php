<?php

require_once("conexao.php");

$conexao = Conexao::LigarConexao();
$conexao->exec("SET NAMES utf8");

if(!$conexao){

    echo "Não esta conectado ao banco";

}
if(isset($_GET['Aluno'])){

    $Aluno = $_GET['Aluno'];

$query = $conexao->prepare("SELECT idAulaP,dataAulaP,statusAulaP,obs,idAluno,idFuncionario,nomeServico,placa,modelo FROM aulap INNER JOIN servico ON aulap.idServico = servico.idServico INNER JOIN veiculos ON aulap.idVeiculo = veiculos.idVeiculo WHERE idAluno = $Aluno");

$query->execute();

$json = "[";

while ($resultado = $query->fetch()){

    if($json !="["){
        $json .= ",";
    }

    $json .= '{"Codigo":"'.$resultado["idAulaP"].'",';

    $json .= '"Data":"'.$resultado["dataAulaP"].'",';

    $json .= '"Status":"'.$resultado["statusAulaP"].'",';

    $json .= '"Obs":"'.$resultado["obs"].'",';

    $json .= '"Aluno":"'.$resultado["idAluno"].'",';

    $json .= '"Funcionario":"'.$resultado["idFuncionario"].'",';

    $json .= '"Servico":"'.$resultado["nomeServico"].'",';

    $json .= '"Placa":"'.$resultado["placa"].'",';

    $json .= '"Modelo":"'.$resultado["modelo"].'"}';
}
$json .= "]";
echo $json;
}else if(isset($_GET['Funcionario'])){

    $Funcionario = $_GET['Funcionario'];

    $query = $conexao->prepare("SELECT idAulaP,dataAulaP,statusAulaP,obs,nome,idFuncionario,nomeServico,placa,modelo FROM aulap INNER JOIN servico ON aulap.idServico = servico.idServico INNER JOIN matriculacfc ON aulap.idAluno = matriculacfc.idAluno INNER JOIN veiculos ON aulap.idVeiculo = veiculos.idVeiculo WHERE idFuncionario = $Funcionario AND statusAulaP = 'PENDENTE'");
    
    $query->execute();
    
    $json = "[";
    
    while ($resultado = $query->fetch()){
    
        if($json !="["){
            $json .= ",";
        }
    
        $json .= '{"Codigo":"'.$resultado["idAulaP"].'",';
    
        $json .= '"Data":"'.$resultado["dataAulaP"].'",';
    
        $json .= '"Status":"'.$resultado["statusAulaP"].'",';
    
        $json .= '"Obs":"'.$resultado["obs"].'",';
    
        $json .= '"Aluno":"'.$resultado["nome"].'",';
    
        $json .= '"Funcionario":"'.$resultado["idFuncionario"].'",';
    
        $json .= '"Servico":"'.$resultado["nomeServico"].'",';
    
        $json .= '"Placa":"'.$resultado["placa"].'",';
    
        $json .= '"Modelo":"'.$resultado["modelo"].'"}';
    }
    $json .= "]";
    echo $json;
}// fim do if isset
?>