<?php

	require_once ("vendors/PHPMailerAutoload.php");
   	$ok = 0;

try{
    if(isset($_POST["email"])){
		
        $assunto 	= "Site KiBeleza";
        $nome 		= $_POST["nome"];
        $email 		= $_POST["email"];
        $fone 		= $_POST["fone"];
        $mens	 	= $_POST["mens"];
		
        $phpmail = new PHPMailer(); // Instânciamos a classe PHPmailer para poder utiliza-la  
		
        $phpmail->isSMTP(); // envia por SMTP
        
        $phpmail->SMTPDebug = 0;
        $phpmail->Debugoutput = 'html';
        
        $phpmail->Host = "smtp.gmail.com"; // SMTP servers         
        $phpmail->Port = 587; // Porta SMTP do GMAIL
        
        $phpmail->SMTPSecure = 'tls'; // Autenticação SMTP
        $phpmail->SMTPAuth = true; // Caso o servidor SMTP precise de autenticação   
        
        $phpmail->Username = "thecakeisalieemm@gmail.com"; // SMTP username         
        $phpmail->Password = "testedebora"; // SMTP password
		
        $phpmail->IsHTML(true);         
        
        $phpmail->setFrom($email, $nome); // E-mail do remetende enviado pelo method post  
                 
        $phpmail->addAddress("thecakeisalieemm@gmail.com", $assunto);// E-mail do destinatario/*  
        
        $phpmail->Subject = $assunto; // Assunto do remetende enviado pelo method post
                
        $phpmail->msgHTML(" Nome: $nome <br>
                            E-mail: $email <br>
                            Telefone: $fone <br>
                            Mensagem: $mens ");
						  						       
        $phpmail->AlrBody = "Nome: $nome \n
                            E-mail: $email \n
                            Telefone: $fone \n
                            Mensagem: $mens";
            
        if($phpmail->send()){ 
			
			$ok = 1;
            //echo "A Mensagem foi enviada com sucesso.";
			
        }else{
			$ok = 2;
            //echo "Não foi possível enviar a mensagem. Erro: " .$phpmail->ErrorInfo;
        }
		         
        // ############## RESPOSTA AUTOMATICA
        $phpmailResposta = new PHPMailer();        
        $phpmailResposta->isSMTP();
        
        $phpmailResposta->SMTPDebug = 0;
        $phpmailResposta->Debugoutput = 'html';
        
        $phpmailResposta->Host = "teste1@dotiweb.tk";         
        $phpmailResposta->Port = 587;
        
        $phpmailResposta->SMTPSecure = 'tls';
        $phpmailResposta->SMTPAuth = true;   
        
        $phpmailResposta->Username = "thecakeialieemm@gmail.com";         
        $phpmailResposta->Password = "testedebora";          
        $phpmailResposta->IsHTML(true);         
        
        $phpmailResposta->setFrom($email, $nome); // E-mail do remetende enviado pelo method post  
                 
        $phpmailResposta->addAddress($email, "Kibeleza");// E-mail do destinatario/*  
        
        $phpmailResposta->Subject = "Restosta - " .$assunto; // Assunto do remetende enviado pelo method post
                
        $phpmailResposta->msgHTML(" Nome: $nome <br>
                            Em breve daremos o retorno");
        
        $phpmailResposta->AlrBody = "Nome: $nome \n
                            Em breve daremos o retorno";
            
        $phpmailResposta->send();
        
    } // FECHAR O IF
    
}catch(Exception $e){
     Erro::tratarErro($e); 
}
    
?>



<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset='utf-8'><!-- -->
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>SITE KIBELEZA</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <link rel='stylesheet' type='text/css' href='css/reset.css'>

    <!-- BANNER SLICK -->
    <link rel="stylesheet" type="text/css" href="css/slick.css">
    <link rel="stylesheet" type="text/css" href="css/slick-theme.css">

    <link rel="stylesheet" type="text/css" href="css/animate.css">

    <link rel="stylesheet" type="text/css" href="css/lity.css">



    <link rel='stylesheet' type='text/css' href='css/estilo.css'>
    <link rel='stylesheet' type='text/css' href='css/anima.css'>



</head>
<body>

<?php require_once("topo.php"); ?>

<section><!--MAPA-->
    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3659.0254647270517!2d-46.434050784408164!3d-23.495592265053293!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce63dda7be6fb9%3A0xa74e7d5a53104311!2sSenac%20S%C3%A3o%20Miguel%20Paulista!5e0!3m2!1spt-BR!2sbr!4v1583496727494!5m2!1spt-BR!2sbr" width="100%" height="550" frameborder="0" style="border:0;" allowfullscreen=""></iframe>
</section>

    <div class="fundoForm">
        <section class="site form"><!-- CONTATO -->
            <article><!-- FOMULARIO -->
                <h1>CONTATO</h1>    
                <h2> 
                    <?php
                        if($ok == 1){
                            echo $nome. ", sua mensagem foi enviada com sucesso.";
                        }else if($ok == 2){
                            echo $nome. ", não foi possivel enviar sua mensagem.";
                        }
                        
                    ?>
                </h2>
                  
                <form method="post" action="#">
                    <div>
                        <input name="nome" type="text" placeholder="Nome: ">
                    </div>
                    <div>
                        <input name="email" type="email" placeholder="Email: " required><!-- required é um comando para falar que é obrigatorio inserir tal coisa, nesse caso o email é obrigatorio colocar @.com-->
                    </div>
                    <div>
                        <input name="fone" type="tel" placeholder="Telefone: ">
                    </div>
                    <div>
                        <textarea name="mens" cols="10" rows="10" placeholder="Mensagem: " ></textarea>
                    </div>
                    <div>
                        <input type="submit" value="ENVIAR">
                    </div>
                </form>
            </article>
        
        </section>
    </div>

    <?php require_once("rodape.php"); ?>

</body>
</html>