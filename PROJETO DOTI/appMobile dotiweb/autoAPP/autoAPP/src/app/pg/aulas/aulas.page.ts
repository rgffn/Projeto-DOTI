import { Component, OnInit } from '@angular/core';
import { NavController } from '@ionic/angular';
import { VisitanteService } from '../../servidor/visitante.service';
import{ UrlService } from '../../servidor/url.service';
import { Http, Headers, Response } from '@angular/http';
import { map } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-aulas',
  templateUrl: './aulas.page.html',
  styleUrls: ['./aulas.page.scss'],
})
export class AulasPage implements OnInit {

  id: any;
  aulaT:any;
  aulaP:any;

  aulaTItems: Array<{
    idAulaT: any,
    dataAulaT: any,
    statusAulaT: any,
    obs: any,
    nome: any,
    idFuncionario: any,
    nomeServico: any,
  }>;
  aulaTItemsTodos: Array<{
    idAulaT: any,
    dataAulaT: any,
    statusAulaT: any,
    obs: any,
    nome: any,
    idFuncionario: any,
    nomeServico: any,
  }>;

  aulaPItems: Array<{
    idAulaP: any,
    dataAulaP: any,
    statusAulaP: any,
    obs: any,
    nome: any,
    idFuncionario: any,
    nomeServico: any,
    placa: any,
    modelo: any,
  }>;
  aulaPItemsTodos: Array<{
    idAulaP: any,
    dataAulaP: any,
    statusAulaP: any,
    obs: any,
    nome: any,
    idFuncionario: any,
    nomeServico: any,
    placa: any,
    modelo: any,
  }>;

  constructor(public http: Http, 
    public nav: NavController,
    public dadosUrl: ActivatedRoute, 
    public servidorUrl : UrlService) { 
      this.aulaTItems = [];
      this.aulaPItems = [];
      this.verificarLogin();
      this.dadosUrl.params.subscribe( parametroId => {
        this.id = parametroId.id;
        this.listaAulaT();
        this.listaAulaP();
        console.log('Meu ID:'+ this.id);
      });
      

    }

    listaAulaT(){
      if(localStorage.getItem('Aluno') !=null){
        this.http.get(this.servidorUrl.pegarUrl()+'admin/aulaT.php?Aluno='+this.id)
        .pipe(map(res => res.json()))
        .subscribe(
          listaDados =>{
          this.aulaT = listaDados;
          
          for(let i = 0; i < listaDados.length; i++){
            this.aulaTItems.push({
              idAulaT:listaDados[i]['Codigo'],
              dataAulaT:listaDados[i]['Data'],
              statusAulaT:listaDados[i]['Status'],
              obs:listaDados[i]['Obs'],
              nome:listaDados[i]['Aluno'],
              idFuncionario:listaDados[i]['Funcionario'],
              nomeServico:listaDados[i]['Servico'],
            });
          }//Fim do for
          this.aulaTItemsTodos = this.aulaTItems;
    
        });
      }else if(localStorage.getItem('Funcionario') !=null){
        this.http.get(this.servidorUrl.pegarUrl()+'admin/aulaT.php?Funcionario='+this.id)
        .pipe(map(res => res.json()))
        .subscribe(
          listaDados =>{
          this.aulaT = listaDados;
          console.log('Meu ID:'+ this.id);
          
          for(let i = 0; i < listaDados.length; i++){
            this.aulaTItems.push({
              idAulaT:listaDados[i]['Codigo'],
              dataAulaT:listaDados[i]['Data'],
              statusAulaT:listaDados[i]['Status'],
              obs:listaDados[i]['Obs'],
              nome:listaDados[i]['Aluno'],
              idFuncionario:listaDados[i]['Funcionario'],
              nomeServico:listaDados[i]['Servico'],
            });
          }//Fim do for
          this.aulaTItemsTodos = this.aulaTItems;
          console.log('Meu ID:'+ this.id);
    
        });
      }

    }

    listaAulaP(){
      if(localStorage.getItem('Aluno') !=null){
      this.http.get(this.servidorUrl.pegarUrl()+'admin/aulaP.php?Aluno='+this.id)
      .pipe(map(res => res.json())).subscribe(listaDados =>{
        this.aulaP = listaDados;
        
        for(let i = 0; i < listaDados.length; i++){
          this.aulaPItems.push({
            idAulaP:listaDados[i]['Codigo'],
            dataAulaP:listaDados[i]['Data'],
            statusAulaP:listaDados[i]['Status'],
            obs:listaDados[i]['Obs'],
            nome:listaDados[i]['Aluno'],
            idFuncionario:listaDados[i]['Funcionario'],
            nomeServico:listaDados[i]['Servico'],
            placa:listaDados[i]['Placa'],
            modelo:listaDados[i]['Modelo'],
          });
        }//Fim do for
        this.aulaPItemsTodos = this.aulaPItems;
  
      });
    }else if(localStorage.getItem('Funcionario') !=null){
      this.http.get(this.servidorUrl.pegarUrl()+'admin/aulaP.php?Funcionario='+this.id)
      .pipe(map(res => res.json())).subscribe(listaDados =>{
        this.aulaP = listaDados;
        
        for(let i = 0; i < listaDados.length; i++){
          this.aulaPItems.push({
            idAulaP:listaDados[i]['Codigo'],
            dataAulaP:listaDados[i]['Data'],
            statusAulaP:listaDados[i]['Status'],
            obs:listaDados[i]['Obs'],
            nome:listaDados[i]['Aluno'],
            idFuncionario:listaDados[i]['Funcionario'],
            nomeServico:listaDados[i]['Servico'],
            placa:listaDados[i]['Placa'],
            modelo:listaDados[i]['Modelo'],
          });
        }//Fim do for
        this.aulaPItemsTodos = this.aulaPItems;
  
      });
    }
    }

  ngOnInit() {
  }

  getItems(ev: any) {

    const val = ev.target.value;
    if(val && val.trim() != ''){

        this.aulaTItems = this.aulaTItemsTodos.filter((aulaT) =>{
          return(aulaT.nome.toLowerCase().indexOf(val.toLowerCase()) > -1);
        });
        this.aulaPItems = this.aulaPItemsTodos.filter((aulaP) =>{
          return(aulaP.nome.toLowerCase().indexOf(val.toLowerCase()) > -1);
        });

      console.log('teste');

    }else{

      this.aulaTItems = this.aulaTItemsTodos;
      this.aulaPItems = this.aulaPItemsTodos;

      console.log('nop');
    }

  }
  verificarLogin(){
    if(localStorage.getItem('Visitante') !=null){
      this.servidorUrl.alertas("Atenção", "Area disponivel apenas para alunos ou funcionarios.")
      this.nav.navigateBack('home');
    }

  }

}
