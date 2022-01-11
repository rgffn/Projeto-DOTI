import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { UrlService } from '../../servidor/url.service';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-home',
  templateUrl: './home.page.html',
  styleUrls: ['./home.page.scss'],
})
export class HomePage implements OnInit {

  provas:any;

  provaItems: Array<{
    idProva: any,
    prova: any,
    minimoAcerto: any
  }>;
  provaItemsTodos: Array<{
    idProva: any,
    prova: any,
    minimoAcerto: any
  }>;

  constructor(public http: Http, 
    public servidorUrl : UrlService) { 
    
    this.provaItems = [];
    this.listaProva();

  }

  listaProva(){
    this.http.get(this.servidorUrl.pegarUrl()+'/admin/lista-provas.php')
    .pipe(map(res => res.json())).subscribe(listaDados =>{
      this.provas = listaDados;
      
      for(let i = 0; i < listaDados.length; i++){
        this.provaItems.push({
          idProva:listaDados[i]['Codigo'],
          prova:listaDados[i]['Titulo'],
          minimoAcerto:listaDados[i]['Minimo'],
        });
      }//Fim do for
      this.provaItemsTodos = this.provaItems;

    });
  }

  ngOnInit() {
  }

  getItems(ev: any) {

    const val = ev.target.value;
    if(val && val.trim() != ''){

        this.provaItems = this.provaItemsTodos.filter((provas) =>{
          return(provas.prova.toLowerCase().indexOf(val.toLowerCase()) > -1);
        });

      console.log('teste');

    }else{

      this.provaItems = this.provaItemsTodos;

      console.log('nop');
    }

  }

}
