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
      <h1>Sobre Nos</h1>
      <nav aria-label="breadcrumb" class="banner-breadcrumb">
        <ol class="breadcrumb">
          <li class="breadcrumb-item"><a href="#">Home</a></li>
          <li class="breadcrumb-item active" aria-current="page">Sobre</li>
        </ol>
      </nav>
    </div>
  </section>
  <!--================ Banner Fim =================-->

  <?php require_once ("sobreC.php");?>

  <?php require_once ("review.php");?>

  <!--================ Contador =================-->
  <section class="counters">
    <div class="container">
      <div class="row">
        <div class="col-sm-6 col-lg-3 mb-5 mb-lg-0">
          <div class="counters__single text-center">
            <h2>20</h2>
            <h4>Nossos Parceiros</h4>
          </div>
        </div>
        <div class="col-sm-6 col-lg-3 mb-5 mb-lg-0">
          <div class="counters__single text-center">
            <h2>3000</h2>
            <h4>Alunos Formados</h4>
          </div>
        </div>
        <div class="col-sm-6 col-lg-3 mb-5 mb-lg-0">
          <div class="counters__single text-center">
            <h2>2000</h2>
            <h4>Aulas</h4>
          </div>
        </div>
        <div class="col-sm-6 col-lg-3 mb-5 mb-lg-0">
          <div class="counters__single text-center">
            <h2>30</h2>
            <h4>Funcionarios</h4>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!--================ Contador Fim =================-->  

  <?php require_once ("rodape.php");?>

  <script src="vendors/jquery/jquery-3.2.1.min.js"></script>
  <script src="vendors/bootstrap/bootstrap.bundle.min.js"></script>
  <script src="vendors/owl-carousel/owl.carousel.min.js"></script>
  <script src="vendors/Magnific-Popup/jquery.magnific-popup.min.js"></script>
  <script src="js/jquery.ajaxchimp.min.js"></script>
  <script src="js/main.js"></script>
</body>
</html>