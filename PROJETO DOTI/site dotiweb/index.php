<?php
	require_once("admin/site.php");
	$Site = new Site();
	$listarServico = $Site->ListarServico();
	$listarEquipe = $Site->ListarEquipe();

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
  <link rel="stylesheet" href="vendors/linericon/style.css">
  <link rel="stylesheet" href="vendors/owl-carousel/owl.theme.default.min.css">
  <link rel="stylesheet" href="vendors/owl-carousel/owl.carousel.min.css">
  <link rel="stylesheet" href="vendors/Magnific-Popup/magnific-popup.css">


  <link rel="stylesheet" href="css/estilo.css">
</head>
<body>
<!-- Pre-load -->
<div id="preload">
  <div id="layoutPreload"></div>
</div>

    <?php require_once ("topo.php");?>

    <?php require_once ("banner.php");?>



  <!--================ Segundo "Menu" =================-->
  <section>
    <div class="container static__single-position">
      <div class="row">
        <div class="col-md-6 col-xl-3 mb-4 mb-xl-0">
          <a href="servicos.php">
          <div class="card static__single">
            <h4>1ª Habilitação</h4>
          </div>
          </a>
        </div>
        <div class="col-md-6 col-xl-3 mb-4 mb-xl-0">
          <a href="servicos.php">
            <div class="card static__single">
              <h4>Adição</h4>
            </div>
            </a>
        </div>
        <div class="col-md-6 col-xl-3 mb-4 mb-xl-0">
          <a href="servicos.php">
            <div class="card static__single">
              <h4>Reciclagem</h4>
            </div>
            </a>
        </div>
        <div class="col-md-6 col-xl-3 mb-4 mb-xl-0">
          <a href="servicos.php">
            <div class="card static__single">
              <h4>Renovação</h4>
            </div>
            </a>
        </div>
      </div>
    </div>
  </section>
  <!--================ Segundo "Menu" Fim =================-->        

  <?php require_once ("sobreC.php");?>

  <?php require_once ("lista-servico.php");?>

  <?php require_once ("review.php");?>

  <?php require_once ("equipe.php");?>

  <!--================ Ct =================-->  
  <section class="section-padding--smaller cta-wrapper">
    <div class="container">
      <div class="cta__content text-center">
        <h2>Entre em contato!</h2>
        <p>Entre em contato conosco, tire todas as suas dúvidas e fique por dentro de
todas as nossas novidades e valores!
</p>
        <a href="contato.php" class="button button-cta">Entre em contato apertando aqui!</a>
      </div>
    </div>
  </section>
  <!--================ Ct Fim =================-->  

  <?php require_once ("rodape.php");?>


</body>
</html>