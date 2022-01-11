import { Injectable } from '@angular/core';
import { AlertController } from '@ionic/angular';

@Injectable({
  providedIn: 'root'
})
export class UrlService {

  url: string = 'http://dotiweb.com/';
  //C:\Users\Rg\Xampp\htdocs\auto\admin
  //
  //http://localhost/auto/

  constructor(public alerta: AlertController) { }

  pegarUrl(){
    return this.url;
  }

 async alertas(titulo, msg){
    const alert = await this.alerta.create({
      header: titulo,
      message: msg,
      buttons: ['OK']
    });

    await alert.present();
  }
}