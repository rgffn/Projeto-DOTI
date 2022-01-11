import { Component, OnInit } from '@angular/core';

import { Http } from '@angular/http';
import { UrlService } from '../../servidor/url.service';
import { map } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-detalhe',
  templateUrl: './detalhe.page.html',
  styleUrls: ['./detalhe.page.scss'],
})
export class DetalhePage implements OnInit {

  id: any;
  dados: Array<{
    idServico: any,
    nomeServico: any,
    valorServico: any,
    statusServico: any,
    dataCadServico: any,
    fotoServico1: any,
    fotoServico2: any,
    fotoServico3: any,
    descServico: any,
    texto: any,
    tempoServico: any,
    idEmpresa: any
  }>;

  detalhe: any;

  constructor(public http: Http, public servidorUrl: UrlService, public dadosUrl: ActivatedRoute) { 

    this.dadosUrl.params.subscribe( parametroId => {
      this.id = parametroId.id;
      this.listaDetalhe();
      this.dados = [];
      console.log('Meu ID:'+ this.id);
    });

   }

  ngOnInit() {
  }

  listaDetalhe(){
    this.http.get(this.servidorUrl.pegarUrl()+'admin/detalhe-servico.php?idServico='+this.id)
    .pipe(map(res => res.json()))
    .subscribe(
      data => {
        this.detalhe = data;
        
        for(let i = 0; i < data.length; i++){
          this.dados.push({
            idServico:data[i]['id'],
            nomeServico:data[i]['nome'],
            valorServico:data[i]['valor'],
            statusServico:data[i]['status'],
            dataCadServico:data[i]['data'],
            fotoServico1:data[i]['foto1'],
            fotoServico2:data[i]['foto2'],
            fotoServico3:data[i]['foto3'],
            descServico:data[i]['desc'],
            texto:data[i]['texto'],
            tempoServico:data[i]['tempo'],
            idEmpresa:data[i]['idEmpresa'],
          });

      }//FIM DO FOR
      console.log(this.dados);
      console.log(this.dados[0].idServico)
      localStorage.setItem('idServico',this.dados[0].idServico)
  }
    ) 
  }
}
