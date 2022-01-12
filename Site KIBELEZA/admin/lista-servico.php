<?php

require_once("conexao.php");

$conexao = Conexao::LigarConexao();
$conexao->exec("SET NAMES utf8");

if(!$conexao){

    echo "Não esta conectado ao banco";

}

$query = $conexao->prepare("SELECT * FROM servico ORDER BY idServico ASC");

$query->execute();

$json = "[";

while ($resultado = $query->fetch()){

    if($json !="["){
        $json .= ",";
    }

    $json .= '{"codigo":"'.$resultado["idServico"].'",';

    $json .= '"nome":"'.$resultado["nomeServico"].'",';

    $json .= '"valor":"'.$resultado["valorServico"].'",';

    $json .= '"status":"'.$resultado["statusServico"].'",';

    $json .= '"data":"'.$resultado["dataCadServico"].'",';

    $json .= '"foto1":"'.$resultado["fotoServico1"].'",';

    $json .= '"foto2":"'.$resultado["fotoServico2"].'",';

    $json .= '"foto3":"'.$resultado["fotoServico3"].'",';

    $json .= '"desc":"'.$resultado["descServico"].'",';

    $json .= '"texto":"'.$resultado["texto"].'",';

    $json .= '"tempo":"'.$resultado["tempoServico"].'"}';
}
$json .= "]";
echo $json;
?>