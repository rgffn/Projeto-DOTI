<?php

require_once("conexao.php");

$conexao = Conexao::LigarConexao();
$conexao->exec("SET NAMES utf8");

if(!$conexao){

    echo "Não esta conectado ao banco";

}

if(isset($_GET['idProva'])){

    $idProva = $_GET['idProva'];

    $query = $conexao->prepare("SELECT * FROM questoes WHERE idProva = $idProva");

    $query->execute();

    $json = "[";

while ($resultado = $query->fetch()){

    if($json !="["){
        $json .= ",";
    }
        $json .= '{"Codigo":"'.$resultado["idQuestao"].'",';

        $json .= '"Assunto":"'.$resultado["assunto"].'",';
        
        $json .= '"Questão":"'.$resultado["questao"].'",';
        
        $json .= '"RespostaCerta":"'.$resultado["respostaCerta"].'",';
        
        $json .= '"RespostaErrada":"'.$resultado["respostaErrada"].'",';
        
        $json .= '"RespostaErrada1":"'.$resultado["respostaErrada1"].'",';
        
        $json .= '"RespostaErrada2":"'.$resultado["respostaErrada2"].'"}';
}//fim do while
$json .= "]";
echo $json;

}// fim do if isset

?>