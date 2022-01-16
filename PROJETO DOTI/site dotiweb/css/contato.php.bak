<?php

	require_once ("vendors/PHPMailerAutoload.php");
   	$ok = 0;

try{
    if(isset($_POST["email"])){
		
        $nome 		= $_POST["nome"];
        $email 		= $_POST["email"];
        $assunto 	= $_POST["assunto"];
        $fone	 	= $_POST["fone"];
        $mens	 	= $_POST["mens"];

        //Alimentar Atributos da classe Site
        require_once("admin/site.php");
        $Contato = new Site();
        $Contato->nome = $nome;
        $Contato->email = $email;
        $Contato->assunto = $assunto;
        $Contato->fone = $fone;
        $Contato->mens = $mens;
        $Contato->InserirContato();


        //$Contato->data = date('Y-m-d');
        //$Contato->hora = date('H:i:s');
     
        $phpmail = new PHPMailer(); // Instânciamos a classe PHPmailer para poder utiliza-la  
		
        $phpmail->isSMTP(); // envia por SMTP
        
        $phpmail->SMTPDebug = 0;
        $phpmail->Debugoutput = 'html';
        
        $phpmail->Host = "smtp.gmail.com"; // SMTP servers         
        $phpmail->Port = 587; // Porta SMTP do GMAIL
        
        $phpmail->SMTPSecure = 'tls'; // Autenticação SMTP
        $phpmail->SMTPAuth = true; // Caso o servidor SMTP precise de autenticação   
        
        $phpmail->Username = "thecakeisalierg@gmail.com"; // SMTP username         
        $phpmail->Password = "Xenos559"; // SMTP password
		
        $phpmail->IsHTML(true);         
        
        $phpmail->setFrom($email, $nome); // E-mail do remetende enviado pelo method post  
                 
        $phpmail->addAddress("thecakeisalierg@gmail.com", $assunto);// E-mail do destinatario/*  
        
        $phpmail->Subject = $assunto; // Assunto do remetende enviado pelo method post
                
        $phpmail->msgHTML(" Nome: $nome <br>
                            E-mail: $email <br>
                            Assunto: $assunto <br>
                            Telefone: $fone <br>
                            Mensagem: $mens ");
						  						       
        $phpmail->AlrBody = "Nome: $nome \n
                            E-mail: $email \n
                            Assunto: $assunto \n
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
        
        $phpmailResposta->Host = "smtp.gmail.com";         
        $phpmailResposta->Port = 587;
        
        $phpmailResposta->SMTPSecure = 'tls';
        $phpmailResposta->SMTPAuth = true;   
        
        $phpmailResposta->Username = "thecakeisalierg@gmail.com";         
        $phpmailResposta->Password = "Xenos559";          
        $phpmailResposta->IsHTML(true);         
        
        $phpmailResposta->setFrom($email, $nome); // E-mail do remetende enviado pelo method post  
                 
        $phpmailResposta->addAddress($email, "Kibeleza");// E-mail do destinatario/*  
        
        $phpmailResposta->Subject = "Resposta - " .$assunto; // Assunto do remetende enviado pelo method post
                
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
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>Auto escola || DOTI</title>
	<link rel="icon" href="img/Favicon.png" type="image/png">

  <link rel="stylesheet" href="vendors/bootstrap/bootstrap.min.css">
  <link rel="stylesheet" href="vendors/fontawesome/css/all.min.css">
  <link rel="stylesheet" href="vendors/themify-icons/themify-icons.css">
  <link rel="stylesheet" href="vendors/linericon/estilo.css">
  <link rel="stylesheet" href="vendors/owl-carousel/owl.theme.default.min.css">
  <link rel="stylesheet" href="vendors/owl-carousel/owl.carousel.min.css">
  <link rel="stylesheet" href="vendors/Magnific-Popup/magnific-popup.css">

  <link rel="stylesheet" href="css/estilo.css">
</head>
<body>
  
<?php require_once ("topo.php");?>

  <!--================ Banner =================-->      
  <section class="hero-banner hero-banner--sm">
    <div class="hero-banner__content text-center">
      <h1>Entre em Contato</h1>
      <nav aria-label="breadcrumb" class="banner-breadcrumb">
        <ol class="breadcrumb">
          <li class="breadcrumb-item"><a href="#">Home</a></li>
          <li class="breadcrumb-item active" aria-current="page">Contato</li>
        </ol>
      </nav>
    </div>
  </section>
  <!--================ Banner Fim =================-->

  <!-- ================ Contato ================= -->
  <section class="section-margin--large">
    <div class="container">
    <div class="map" >
      <div class="d-none d-sm-block mb-5 pb-4">
        <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d14636.101310888944!2d-46.4318621!3d-23.4955972!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xa74e7d5a53104311!2sSenac%20S%C3%A3o%20Miguel%20Paulista!5e0!3m2!1spt-BR!2sbr!4v1594079544160!5m2!1spt-BR!2sbr" width="100%" height="420" frameborder="0" style="border:0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>
      </div>
    </div>

      <div class="row">
        <div class="col-md-4 col-lg-3 mb-4 mb-md-0">
          <div class="media contact-info">
            <span class="contact-info__icon"><i class="ti-home"></i></span>
            <div class="media-body">
              <h3>São Paulo</h3>
              <p>São Miguel Paulista</p>
            </div>
          </div>
          <div class="media contact-info">
            <span class="contact-info__icon"><i class="ti-headphone"></i></span>
            <div class="media-body">
              <h3><a href="tel:25048400">(011) 2504-8400</a></h3>
              <p>De Seg a Sex das 8am ate as 6pm</p>
            </div>
          </div>
          <div class="media contact-info">
            <span class="contact-info__icon"><i class="ti-email"></i></span>
            <div class="media-body">
              <h3><a href="doti07@outlook.com">doti07@outlook.com</a></h3>
              <p>Entre em contato a qualquer momento</p>
            </div>
          </div>
        </div>

        <!-- ================ Form ================= -->
        <div class="col-md-8 col-lg-9">
        <?php
        if($ok == 1){
          echo ("<h2> $nome, a sua mensagem foi enviada com sucesso.</h2>");
        }else if ($ok == 2){
           echo ("<h2> $nome, não foi possível enviar a sua mensagem.</h2>");
        }
        
        ?>

			
          <form action="#/" class="form-contact contact_form" action="#" method="post" id="contactForm">
            <div class="row">
              <div class="col-lg-5">
                <div class="form-group">
                  <input class="form-control" name="nome" id="nome" type="text" placeholder="Digite o seu nome">
                </div>
                <div class="form-group">
                  <input class="form-control" name="email" id="email" type="email" placeholder="Digite o seu email">
                </div>
                <div class="form-group">
                  <input class="form-control" name="assunto" id="subject" type="text" placeholder="Digite o assunto">
                </div>
                <div class="form-group">
                  <input class="form-control" name="fone" id="fone" type="text" placeholder="Digite o seu telefone">
                </div>
              </div>
              <div class="col-lg-7">
                <div class="form-group">
                    <textarea class="form-control different-control w-100" name="mens" cols="30" rows="7" placeholder="Digite a sua mensagem"></textarea>
                </div>
              </div>
            </div>
            <div class="form-group text-center text-md-right mt-3">
              <button type="submit" value="Enviar" class="button button-contactForm">Envie a sua Mensagem</button>
            </div>
          </form>
        </div>
        <!-- ================ Fim do Form ================= -->
      </div>
    </div>
  </section>
	<!-- ================ Contato Fim ================= -->

  <?php require_once ("rodape.php");?>

  <script src="vendors/jquery/jquery-3.2.1.min.js"></script>
  <script src="vendors/bootstrap/bootstrap.bundle.min.js"></script>
  <script src="vendors/owl-carousel/owl.carousel.min.js"></script>
  <script src="vendors/Magnific-Popup/jquery.magnific-popup.min.js"></script>
  <script src="js/contato.js"></script>
  <script src="js/jquery.ajaxchimp.min.js"></script>
  <script src="js/main.js"></script>
</body>
</html>