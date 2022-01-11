import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { NavController } from '@ionic/angular';
import { Http, Headers, Response } from '@angular/http';
import { UrlService } from '../../servidor/url.service';
import { map } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-alteraraula-t',
  templateUrl: './alteraraula-t.page.html',
  styleUrls: ['./alteraraula-t.page.scss'],
})
export class AlteraraulaTPage implements OnInit {

  id: any;
  dados: Array<{
    idAulaT: any,
    dataAulaT: any,
    statusAulaT: any,
    obs: any,
    nome: any,
    idFuncionario: any,
    nomeServico: any,
  }>;

  aulat: any;
  servicos: any;
  status: any;
  codAula = localStorage.getItem('idAulaT');
  aulapr: any;

  constructor(public nav: NavController,
    public http: Http, 
    public servidorUrl: UrlService, 
    public dadosUrl: ActivatedRoute,
    public formConst: FormBuilder) { 
      this.verificarLogin();
      this.dadosUrl.params.subscribe( parametroId => {
        this.id = parametroId.id;
        this.listaAulaT();
        this.listaServico();
        this.dados = [];
        console.log('Meu ID:'+ this.id);
      });
  
      this.aulapr = this.formConst.group({
        status: ['',Validators.required],
        codAula: this.codAula
      });

   }

  ngOnInit() {
  }

  listaAulaT(){
    this.http.get(this.servidorUrl.pegarUrl()+'admin/alterar-aulaT.php?idAulaT='+this.id)
    .pipe(map(res => res.json())) 
    .subscribe(
      data => {
        this.aulat = data;
        
        for(let i = 0; i < data.length; i++){
          this.dados.push({
            idAulaT:data[i]['Codigo'],
            dataAulaT:data[i]['Data'],
            statusAulaT:data[i]['Status'],
            obs:data[i]['Obs'],
            nome:data[i]['Aluno'],
            idFuncionario:data[i]['Funcionario'],
            nomeServico:data[i]['Servico'],
          });

      }//FIM DO FOR
      console.log(this.dados);
      console.log(this.dados[0].idAulaT)
      localStorage.setItem('idAulaT',this.dados[0].idAulaT)
    }
    ) 
  }
  listaServico(){
    this.http.get(this.servidorUrl.pegarUrl()+'admin/lista-servico.php')
    .pipe(map(res => res.json())).subscribe(listaDados => {
      this.servicos = listaDados;
    });
  }

    //Metodo reserva
    async cadStatus(){

      if(this.codAula == undefined || this.status == undefined){

        this.servidorUrl.alertas('Atenção','Preencha todos os campos');
      }else{
        this.cadDados(this.aulapr.value).subscribe(
          data =>{
            console.log("Dados Ok")
            console.log(this.codAula);
            console.log(this.status);
            this.servidorUrl.alertas('Atualização de Status','Sua modificação foi realizada com sucesso!');
            //this.nav.navigateBack('perfil');
          },
          err => {
            console.log("Erro")
            this.servidorUrl.alertas('Atualização de Status', 'Erro ao realizar sua modificação.');
          }
        )
      }

    }
    cadDados(nome){
      let cabecalho = new Headers({'content-type' : 'application/x-www-form-urlencoded'});
      return this.http.post(this.servidorUrl.pegarUrl()+'admin/cadT.php', nome, {
        headers: cabecalho,
        method: 'POST'
      })
      .pipe(map((res: Response) => {
        return res.json();
      }));
    
    }// Fim do cadDados
    verificarLogin(){
      if(localStorage.getItem('Aluno') !=null){
        this.servidorUrl.alertas("Atenção", "Area disponivel apenas para funcionarios.")
        this.nav.navigateBack('home');
      }
  
    }

}