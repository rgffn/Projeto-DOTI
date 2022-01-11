<?php
require_once("conexao.php");
class Site{

    //atributos (variaveis)
    public $nome;
    public $email;
    public $fone;
    public $mens;
    public $data;
	public $hora;
	public $assunto;

    //metodos (funçoes)
	//metodo para listar serviço
	public function ListarServico(){
		
		$query = "SELECT * FROM servico";
		$conexao = Conexao::LigarConexao();
		$conexao->exec("SET NAMES utf8");
		$resultado = $conexao->query($query);
		
		$lista = $resultado->fetchAll();
		return $lista;
	}
	//metodo para gravar contato no banco
	public function InserirContato(){
		$query = "INSERT INTO contato (nome, email, assunto, fone, mens) VALUES ('".$this->nome."','".$this->email."', '".$this->assunto."', '".$this->fone."', '".$this->mens."');";
		$conexao = Conexao::LigarConexao();
		$conexao->exec($query);
	}
	
	//metodo para listar as noticias
	
	
	//metodo para listar as equipes
			public function ListarEquipe(){
		
		$query = "SELECT * FROM funcionario";
		$conexao = Conexao::LigarConexao();
		$conexao->exec("SET NAMES utf8");
		$resultado = $conexao->query($query);
		
		$lista = $resultado->fetchAll();
		return $lista;
		}
}	//fim da classe site
?>