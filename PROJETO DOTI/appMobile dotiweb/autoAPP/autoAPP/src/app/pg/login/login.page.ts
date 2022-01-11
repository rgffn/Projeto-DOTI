import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { map } from 'rxjs/operators';
import { UrlService } from '../../servidor/url.service';
import { NavController } from '@ionic/angular';
import { VisitanteService } from '../../servidor/visitante.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  email:any;
  senha:any;

  constructor(public http: Http,
              public servidorUrl: UrlService,
              public dadosUsuario: VisitanteService,
              public nav: NavController) { 

              }
              

  ngOnInit() {
  }

  async LogarV(){
    this.email = 'visitante@gmail.com';
    this.senha = '123';

      this.http.get(this.servidorUrl.pegarUrl()+'/admin/login.php?email='+this.email+'&senha='+this.senha)
      .pipe(map(res => res.json()))
      .subscribe(data =>{

        if(data.msg.logado == 'sim'){

            //ALIMENTAR VARIAVEIS
            this.dadosUsuario.setidCli(data.dados.Codigo);
            this.dadosUsuario.setnomeCli(data.dados.Nome);
            this.dadosUsuario.setemailCli(data.dados.Email);
            this.dadosUsuario.setfotoCli(data.dados.Foto);
            this.dadosUsuario.setCpf(data.dados.Cpf);

            //TESTE
           // console.log(this.dadosUsuario.getidCli());
           // console.log(this.dadosUsuario.getnomeCli());
           // console.log(this.dadosUsuario.getemailCli());
           // console.log(this.dadosUsuario.getstatusCli());
           // console.log(this.dadosUsuario.getfotoCli());

          //ARMAZENAR NO LOCALSTORAGE

          localStorage.setItem('idCliente', data.dados.Codigo);
          localStorage.setItem('nomeCli', data.dados.Nome);
          localStorage.setItem('emailCli', data.dados.Email);
          localStorage.setItem('fotoCli', data.dados.Foto);
          localStorage.setItem('Cpf', data.dados.Cpf);


          localStorage.setItem('Visitante','sim');
          this.servidorUrl.alertas("Auto Escola Guarulhos", data.dados.Nome+" Logado com sucesso");
          


            this.nav.navigateBack('home');

        }
      });
      }

  async Logar(){
    if(this.email == '' || this.senha == ''){

      this.servidorUrl.alertas("Atenção","Preencha todos os campos");

    }else{

      this.http.get(this.servidorUrl.pegarUrl()+'/admin/login.php?email='+this.email+'&senha='+this.senha)
      .pipe(map(res => res.json()))
      .subscribe(data =>{

        if(data.msg.logado == 'sim'){

            //ALIMENTAR VARIAVEIS
            this.dadosUsuario.setidCli(data.dados.Codigo);
            this.dadosUsuario.setnomeCli(data.dados.Nome);
            this.dadosUsuario.setemailCli(data.dados.Email);
            this.dadosUsuario.setfotoCli(data.dados.Foto);

            //TESTE
           // console.log(this.dadosUsuario.getidCli());
           // console.log(this.dadosUsuario.getnomeCli());
           // console.log(this.dadosUsuario.getemailCli());
           // console.log(this.dadosUsuario.getstatusCli());
           // console.log(this.dadosUsuario.getfotoCli());

          //ARMAZENAR NO LOCALSTORAGE

          localStorage.setItem('idCliente', data.dados.Codigo);
          localStorage.setItem('nomeCli', data.dados.Nome);
          localStorage.setItem('emailCli', data.dados.Email);
          localStorage.setItem('fotoCli', data.dados.Foto);


          localStorage.setItem('Aluno','sim');
          


            this.nav.navigateBack('perfil');
            this.servidorUrl.alertas("Auto Escola Guarulhos", data.dados.Nome+" Logado com sucesso");

        }else{ //if data logado
          this.servidorUrl.alertas("Atenção", "Usuario ou Senha invalido")
        }

      });
      

    }
  }

  async LogarF(){
    if(this.email == '' || this.senha == ''){

      this.servidorUrl.alertas("Atenção","Preencha todos os campos");

    }else{

      this.http.get(this.servidorUrl.pegarUrl()+'/admin/loginF.php?email='+this.email+'&senha='+this.senha)
      .pipe(map(res => res.json()))
      .subscribe(data =>{

        if(data.msg.logado == 'sim'){


            //ALIMENTAR VARIAVEIS
            this.dadosUsuario.setidCli(data.dados.Codigo);
            this.dadosUsuario.setnomeCli(data.dados.Nome);
            this.dadosUsuario.setemailCli(data.dados.Email);
            this.dadosUsuario.setfotoCli(data.dados.Foto);

            //TESTE
           // console.log(this.dadosUsuario.getidCli());
           // console.log(this.dadosUsuario.getnomeCli());
           // console.log(this.dadosUsuario.getemailCli());
           // console.log(this.dadosUsuario.getstatusCli());
           // console.log(this.dadosUsuario.getfotoCli());

          //ARMAZENAR NO LOCALSTORAGE

          localStorage.setItem('idCliente', data.dados.Codigo);
          localStorage.setItem('nomeCli', data.dados.Nome);
          localStorage.setItem('emailCli', data.dados.Email);
          localStorage.setItem('fotoCli', data.dados.Foto);


          localStorage.setItem('Funcionario','sim');
          


            this.nav.navigateBack('perfil');
            this.servidorUrl.alertas("Auto Escola Guarulhos", data.dados.Nome+" Logado com sucesso");

        }else{ //if data logado
          this.servidorUrl.alertas("Atenção", "Usuario ou Senha invalido")
        }

      });
      

    }
  }

}
