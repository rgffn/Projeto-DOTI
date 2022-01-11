  <!--================ Serviços =================-->
  <section class="section-margin">
    <div class="container">
      <div class="section-intro text-center pb-65px">
        <h2 class="section-intro__title">Serviços</h2>
        <p>Aqui você pode conhecer melhor nossos serviços e escolher qual tipo de Carteira de Motorista é indicada a sua necessidade.</p>
      </div>
      <div class="row">
	  <?php foreach(array_slice($listarServico, 0, 8) as $linha): ?>
        <div class="col-sm-6 col-lg-4 col-xl-3 mb-4 mb-xl-0">
          <div class="card card-subject">
            <div class="card-subject__img">
              <img class="card-img rounded-0" src="<?php echo $linha['fotoServico'] ?>" alt="<?php echo $linha['nomeServico']?>">
              <div class="card-subject__imgOverlay">
                <img src="img/home/hover-icon.png" alt="">
              </div>
            </div>
            <div class="card-subject__body">
              <h3><a href="servicos.php"><?php echo $linha['nomeServico'] ?></a></h3>
              <p><?php echo $linha['texto'] ?></p>
            </div>
          </div>
        </div>
	  <?php endforeach?>
      </div>
	  
      <div class="col-12 text-center mt-5 pt-xl-4">
        <a class="button" href="servicos.php">Veja todos os nossos serviços<span class="align-middle"><i class="ti-arrow-right"></i></span></a>
      </div>
    </div>
  </section>
  <!--================ Serviços Fim =================-->