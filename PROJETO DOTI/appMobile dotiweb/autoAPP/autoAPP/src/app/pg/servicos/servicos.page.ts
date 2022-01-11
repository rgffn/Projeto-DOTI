import { Component, OnInit } from '@angular/core';

import { Http } from '@angular/http';
import { UrlService } from '../../servidor/url.service';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-servicos',
  templateUrl: './servicos.page.html',
  styleUrls: ['./servicos.page.scss'],
})
export class ServicosPage implements OnInit {

  servicos:any;

  servicoItems: Array<{
    idServico: any,
    nomeServico: any,
    valorServico: any,
    statusServico: any,
    dataCadServico: any,
    fotoServico: any,
    fotoServico1: any,
    fotoServico2: any,
    fotoServico3: any,
    descServico: any,
    texto: any,
    tempoServico: any
  }>;
  servicoItemsTodos: Array<{
    idServico: any,
    nomeServico: any,
    valorServico: any,
    statusServico: any,
    dataCadServico: any,
    fotoServico: any,
    fotoServico1: any,
    fotoServico2: any,
    fotoServico3: any,
    descServico: any,
    texto: any,
    tempoServico: any
  }>;

  constructor(public http: Http, 
    public servidorUrl : UrlService) { 
    
    this.servicoItems = [];
    this.listaServico();

  }

  listaServico(){
    this.http.get(this.servidorUrl.pegarUrl()+'admin/lista-servico.php')
    .pipe(map(res => res.json())).subscribe(listaDados =>{
      this.servicos = listaDados;
      
      for(let i = 0; i < listaDados.length; i++){
        this.servicoItems.push({
          idServico:listaDados[i]['codigo'],
          nomeServico:listaDados[i]['nome'],
          valorServico:listaDados[i]['valor'],
          statusServico:listaDados[i]['status'],
          dataCadServico:listaDados[i]['data'],
          fotoServico:listaDados[i]['foto'],
          fotoServico1:listaDados[i]['foto1'],
          fotoServico2:listaDados[i]['foto2'],
          fotoServico3:listaDados[i]['foto3'],
          descServico:listaDados[i]['desc'],
          texto:listaDados[i]['texto'],
          tempoServico:listaDados[i]['tempo'],
        });
      }//Fim do for
      this.servicoItemsTodos = this.servicoItems;

    });
  }

  ngOnInit() {
  }

  getItems(ev: any) {

    const val = ev.target.value;
    if(val && val.trim() != ''){

        this.servicoItems = this.servicoItemsTodos.filter((servicos) =>{
          return(servicos.nomeServico.toLowerCase().indexOf(val.toLowerCase()) > -1);
        });

      console.log('teste');

    }else{

      this.servicoItems = this.servicoItemsTodos;

      console.log('nop');
    }

  }

}
