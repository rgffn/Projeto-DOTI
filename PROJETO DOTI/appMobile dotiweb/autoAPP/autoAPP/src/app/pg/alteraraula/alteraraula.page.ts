import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { NavController } from '@ionic/angular';
import { Http, Headers, Response } from '@angular/http';
import { UrlService } from '../../servidor/url.service';
import { map } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-alteraraula',
  templateUrl: './alteraraula.page.html',
  styleUrls: ['./alteraraula.page.scss'],
})
export class AlteraraulaPage implements OnInit {

  id: any;
  dados: Array<{
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

  aulap: any;
  servicos: any;
  status: any;
  codAula = localStorage.getItem('idAulaP');
  aulapr: any;

  constructor(public nav: NavController,
    public http: Http, 
    public servidorUrl: UrlService, 
    public dadosUrl: ActivatedRoute,
    public formConst: FormBuilder) { 
    this.verificarLogin();
    this.dadosUrl.params.subscribe( parametroId => {
      this.id = parametroId.id;
      this.listaAulaP();
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
  listaAulaP(){
    this.http.get(this.servidorUrl.pegarUrl()+'admin/alterar-aulaP.php?idAulaP='+this.id)
    .pipe(map(res => res.json())) 
    .subscribe(
      data => {
        this.aulap = data;
        
        for(let i = 0; i < data.length; i++){
          this.dados.push({
            idAulaP:data[i]['Codigo'],
            dataAulaP:data[i]['Data'],
            statusAulaP:data[i]['Status'],
            obs:data[i]['Obs'],
            nome:data[i]['Aluno'],
            idFuncionario:data[i]['Funcionario'],
            nomeServico:data[i]['Servico'],
            placa:data[i]['Placa'],
            modelo:data[i]['Modelo'],
          });

      }//FIM DO FOR
      console.log(this.dados);
      console.log(this.dados[0].idAulaP)
      localStorage.setItem('idAulaP',this.dados[0].idAulaP)
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
        console.log(this.codAula)
        console.log(this.status)

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
      return this.http.post(this.servidorUrl.pegarUrl()+'admin/cadP.php', nome, {
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
