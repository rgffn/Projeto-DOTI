import { Component, OnInit } from '@angular/core';
import { NavController } from '@ionic/angular';
import { VisitanteService } from 'src/app/servidor/visitante.service';
import { UrlService } from 'src/app/servidor/url.service';
import { Platform } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss']
})
export class AppComponent implements OnInit {
  public selectedIndex = 0;
  public appPages = [
    {
      title: 'Inicio',
      url: 'home',
      icon: 'home'
    },
    {
      title: 'Minha Área',
      url: 'perfil',
      icon: 'home'
    },
    {
      title: 'Servicos',
      url: 'servicos',
      icon: 'car'
    },
    {
      title: 'Entre em contato',
      url: 'contato',
      icon: 'mail'
    }
  ];

  constructor(
    private platform: Platform,
    private splashScreen: SplashScreen,
    private statusBar: StatusBar,
    public nav: NavController, 
    public dadosUsuario: VisitanteService,
    public servidorUrl: UrlService,
    ) {
    this.initializeApp();
    this.dadosUsuario.setnomeCli(localStorage.getItem('nomeCli'));
    this.dadosUsuario.setfotoCli(localStorage.getItem('fotoCli'));
  }

  initializeApp() {
    this.platform.ready().then(() => {
      this.statusBar.styleDefault();
      this.splashScreen.hide();
    });
  }

  ngOnInit() {
    const path = window.location.pathname.split('folder/')[1];
    if (path !== undefined) {
      this.selectedIndex = this.appPages.findIndex(page => page.title.toLowerCase() === path.toLowerCase());
    }
  }
}
