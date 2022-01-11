<html>
<head>
	<title>ENVIO PARA EMAIL</title>
</head>
<body>

<?php

$nome = (!empty($_GET['nome'])) ? $_GET['nome'] : false;
$email = (!empty($_GET['email'])) ? $_GET['email'] : false;
$mensagem = (!empty($_GET['mensagem '])) ? $_GET['mensagem '] : false;

if (!empty($_GET['enviar'])) {
	
	$email_destino = 'thecakeisalierg@gmail.com';

	$email_assunto = "Mensagem de {$nome}";

	$email_mensagem = 'Mensagem via php' . "<br>";
	$email_mensagem .= 'NOME: ' . $nome . "<br>";
	$email_mensagem .= 'EMAIL: ' . $email . "<br>"; 
	$email_mensagem .= 'MENSAGEM: ' . $mensagem . "<br>";
	$email_mensagem .= "<br><br><br>";

	// headers de configuração 
	$email_headers = 'From: "'.$nome.'" <'.$email.'>' . "\r";
	$email_headers .= 'Subject: '.$email_assunto.'' . "\r";

	// função mail que envia para destinatário 
	$envio = mail($email_destino, $email_assunto, $email_mensagem, $email_headers);

	if ($envio) {
		echo "ENVIADO";
	}else{

		echo "FALHA AO ENVIAR";
	}		

}

?>
<form method="get" action="">

Nome: <br>
<input type="text" name="nome"> <br>

Email: <br>
<input type="text" name="email"> <br>

<input type="submit" name="enviar">

</form>

</body>
</html>
