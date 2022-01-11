import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { NavController } from '@ionic/angular';
import { Http, Headers, Response } from '@angular/http';
import { UrlService } from '../../servidor/url.service';
import { map } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-contato',
  templateUrl: './contato.page.html',
  styleUrls: ['./contato.page.scss'],
})
export class ContatoPage implements OnInit {

  contato:any;
  nome:any;
  email:any;
  celular:any;
  msg:any;

  constructor(public nav: NavController,
    public http: Http, 
    public servidorUrl: UrlService, 
    public dadosUrl: ActivatedRoute,
    public formConst: FormBuilder) {
  //Construir a variavel Reserva com os dados do form e do LS
  this.contato = this.formConst.group({
  nome:['', Validators.required],
  email:['',Validators.required],
  celular:['',Validators.required],
  msg:['',Validators.required],

});

    }

  ngOnInit() {
  }
    //Metodo reserva
    async cadContato(){
      if(this.nome == undefined || this.email == undefined || this.celular == undefined || this.msg == undefined){
  
        this.servidorUrl.alertas('Atenção',' Preencha todos os campos');
      }else{
  
        this.cadDados(this.contato.value).subscribe(
          data =>{
            console.log("Dados Ok")
            this.servidorUrl.alertas('Auto Escola Guarulhos', this.nome+', Sua mensagem foi enviada com sucesso!');
            this.nav.navigateBack('home');
          },
          err => {
            console.log("Erro")
            this.servidorUrl.alertas('Auto Escola Guarulhos', this.nome+', Erro ao realizar sua reserva.');
          }
        )
  
  
      }
    }
    cadDados(nome){
      let cabecalho = new Headers({'content-type' : 'application/x-www-form-urlencoded'});
  
      return this.http.post(this.servidorUrl.pegarUrl()+'admin/inserirC.php', nome, {
        headers: cabecalho,
        method: 'POST'
      })
      .pipe(map((res: Response) => {
        return res.json();
      }));
    }// Fim do cadDados

}
