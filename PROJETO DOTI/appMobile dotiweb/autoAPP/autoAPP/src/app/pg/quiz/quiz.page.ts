import { Component, OnInit } from '@angular/core';

import { Http } from '@angular/http';
import { UrlService } from '../../servidor/url.service';
import { map } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.page.html',
  styleUrls: ['./quiz.page.scss'],
})
export class QuizPage implements OnInit {

  id: any;
  quests: any;
  dados: Array<{
    idQuestao: any,
    assunto: any,
    questao: any,
    respostaCerta: any,
    respostaErrada: any,
    respostaErrada1: any,
    respostaErrada2: any,
  }>;
  dadosTodos: Array<{
    idQuestao: any,
    assunto: any,
    questao: any,
    respostaCerta: any,
    respostaErrada: any,
    respostaErrada1: any,
    respostaErrada2: any,
  }>;

  quest: any;

  constructor(public http: Http, public servidorUrl: UrlService, public dadosUrl: ActivatedRoute) { 

    this.dadosUrl.params.subscribe( parametroId => {
      this.id = parametroId.id;
      this.dados = [];
      this.listaQuestao();

      console.log('Meu ID:'+ this.id);
    });

   }

  ngOnInit() {
  }

  listaQuestao(){
    this.http.get(this.servidorUrl.pegarUrl()+'admin/lista-questoes.php?idProva='+this.id)
    .pipe(map(res => res.json())).subscribe(listaDados =>{
      this.quests = listaDados;
      
      for(let i = 0; i < listaDados.length; i++){
        this.dados.push({
            idQuestao:listaDados[i]['Codigo'],
            assunto:listaDados[i]['Assunto'],
            questao:listaDados[i]['Questão'],
            respostaCerta:listaDados[i]['RespostaCerta'],
            respostaErrada:listaDados[i]['RespostaErrada'],
            respostaErrada1:listaDados[i]['RespostaErrada1'],
            respostaErrada2:listaDados[i]['RespostaErrada2'],
          });

      }//FIM DO FOR

      this.dadosTodos = this.dados;
      console.log(this.dados);
      console.log(this.dados[0].idQuestao)
      localStorage.setItem('idQuestão',this.dados[0].idQuestao)
  }
    ) 
  }

  

}
