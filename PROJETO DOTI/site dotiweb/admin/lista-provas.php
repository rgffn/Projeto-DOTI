<?php

require_once("conexao.php");

$conexao = Conexao::LigarConexao();
$conexao->exec("SET NAMES utf8");

if(!$conexao){

    echo "Não esta conectado ao banco";

}

    $query = $conexao->prepare("SELECT * FROM provas");

    $query->execute();

    $json = "[";

while ($resultado = $query->fetch()){

    if($json !="["){
        $json .= ",";
    }
        $json .= '{"Codigo":"'.$resultado["idProva"].'",';

        $json .= '"Titulo":"'.$resultado["prova"].'",';
        
        $json .= '"Minimo":"'.$resultado["minimoAcerto"].'"}';
}//fim do while
$json .= "]";
echo $json;
?>