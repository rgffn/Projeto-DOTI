import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class VisitanteService {

  idAluno = '';
  nome = '';
  email = '';
  foto = '';
  cpf = '';

  constructor() { }

    //GET
    setidCli(valor){
      this.idAluno=valor;
    }
    getidCli(){
      return this.idAluno;
    }

    //GET
    setnomeCli(valor){
      this.nome=valor;
    }
    getnomeCli(){
      return this.nome;
    }

    //GET
    setemailCli(valor){
      this.email=valor;
    }
    getemailCli(){
      return this.email;
    }
    //GET
    setfotoCli(valor){
      this.foto=valor;
    }
    getfotoCli(){
      return this.foto;
    }
    setCpf(valor){
      this.cpf=valor;
    }
    getCpf(){
      return this.cpf;
    }
}