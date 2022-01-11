import { Component, OnInit } from '@angular/core';
import { NavController } from '@ionic/angular';
import { VisitanteService } from '../../servidor/visitante.service';
import{ UrlService } from '../../servidor/url.service';
import { Http } from '@angular/http';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.page.html',
  styleUrls: ['./perfil.page.scss'],
})
export class PerfilPage implements OnInit {

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
    public nav: NavController, 
    public dadosUsuario: VisitanteService,
    public servidorUrl: UrlService
    ) {

    this.verificarLogin();
    console.log(this.dadosUsuario.idAluno);
    console.log(this.dadosUsuario.nome);
    console.log(this.dadosUsuario.email);
    console.log(this.dadosUsuario.foto);
    console.log(this.servidorUrl.pegarUrl()+this.dadosUsuario.getfotoCli());

    this.servicoItems = [];
    this.listaServico();
   }

   listaServico(){
    this.http.get(this.servidorUrl.pegarUrl()+'/admin/lista-servico.php')
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
    //AUTH
    verificarLogin(){

      if(localStorage.getItem('Aluno') !=null){
  
        //Pegar dados do localstorage
        this.dadosUsuario.setidCli(localStorage.getItem('idCliente'));
        this.dadosUsuario.setnomeCli(localStorage.getItem('nomeCli'));
        this.dadosUsuario.setemailCli(localStorage.getItem('emailCli'));
        this.dadosUsuario.setfotoCli(localStorage.getItem('fotoCli'));
  
      }else if(localStorage.getItem('Funcionario') !=null){
  
        //Pegar dados do localstorage
        this.dadosUsuario.setidCli(localStorage.getItem('idCliente'));
        this.dadosUsuario.setnomeCli(localStorage.getItem('nomeCli'));
        this.dadosUsuario.setemailCli(localStorage.getItem('emailCli'));
        this.dadosUsuario.setfotoCli(localStorage.getItem('fotoCli'));
  
      }else if(localStorage.getItem('Visitante') !=null){
        //Pegar dados do localstorage
        this.dadosUsuario.setidCli(localStorage.getItem('idCliente'));
        this.dadosUsuario.setnomeCli(localStorage.getItem('nomeCli'));
        this.dadosUsuario.setemailCli(localStorage.getItem('emailCli'));
        this.dadosUsuario.setfotoCli(localStorage.getItem('fotoCli'));
      }
      else{
        this.nav.navigateBack('login');
      }
  
    }
  
    //metodo pa sair
    sair(){
      localStorage.clear();
      this.nav.navigateBack('login');
      //location.reload();
    }

}
