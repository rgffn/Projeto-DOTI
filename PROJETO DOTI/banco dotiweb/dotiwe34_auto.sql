-- phpMyAdmin SQL Dump
-- version 4.9.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Tempo de geração: 03/10/2020 às 01:21
-- Versão do servidor: 5.6.41-84.1
-- Versão do PHP: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dotiwe34_auto`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `aulap`
--

CREATE TABLE `aulap` (
  `idAulaP` int(11) NOT NULL,
  `dataAulaP` varchar(200) NOT NULL,
  `statusAulaP` varchar(45) NOT NULL,
  `obs` text NOT NULL,
  `idAluno` int(11) NOT NULL,
  `idFuncionario` int(11) NOT NULL,
  `idServico` int(11) NOT NULL,
  `idVeiculo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `aulap`
--

INSERT INTO `aulap` (`idAulaP`, `dataAulaP`, `statusAulaP`, `obs`, `idAluno`, `idFuncionario`, `idServico`, `idVeiculo`) VALUES
(1, '31/10/2020 03:08', 'PENDENTE', 'Atualização de cadastro pendente', 23, 1, 1, 1),
(2, '31/10/2020 03:08', 'PENDENTE', 'Atualização de cadastro pendente', 26, 1, 2, 1),
(3, '01/10/2020 13:00', 'PENDENTE', 'teste', 23, 1, 6, 2),
(4, '99/99/9999 99:99', 'PENDENTE', '', 24, 2, 5, 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `aulat`
--

CREATE TABLE `aulat` (
  `idAulaT` int(11) NOT NULL,
  `dataAulaT` varchar(200) NOT NULL,
  `statusAulaT` varchar(45) NOT NULL,
  `obs` text NOT NULL,
  `idAluno` int(11) NOT NULL,
  `idFuncionario` int(11) NOT NULL,
  `idServico` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `aulat`
--

INSERT INTO `aulat` (`idAulaT`, `dataAulaT`, `statusAulaT`, `obs`, `idAluno`, `idFuncionario`, `idServico`) VALUES
(1, '31/10/2020 03:08', 'FINALIZADO', 'Aula desenvolvida com sucesso', 23, 1, 7),
(2, '31/10/2020 03:08', 'FINALIZADO', 'Aula desenvolvida com sucesso', 23, 1, 7),
(3, '31/10/2020 03:08', 'CANCELADO', 'Aula desenvolvida  com sucesso', 23, 1, 5),
(4, '31/10/2020 03:08', 'CANCELADO', 'Aula desenvolvida  com sucesso', 23, 1, 5),
(5, '31/10/2020 03:08', 'PENDENTE', 'TESTE DE VISUALIZAÇÃO', 24, 1, 8),
(6, '31/10/2020 03:08', 'PENDENTE', 'TESTE DE VISUALIZAÇÃO', 23, 2, 8),
(7, '31/10/2020 03:08', 'PENDENTE', 'TESTE DE VISUALIZAÇÃO', 24, 2, 5),
(9, '99/99/9999 99:99', 'CANCELADO', '', 26, 1, 4),
(10, ' 1/21/2202 02:05', 'PENDENTE', 'iniciando', 27, 1, 3);

-- --------------------------------------------------------

--
-- Estrutura para tabela `banner`
--

CREATE TABLE `banner` (
  `idBanner` int(11) NOT NULL,
  `nomeBanner` varchar(100) NOT NULL,
  `caminhoBanner` varchar(100) NOT NULL,
  `statusBanner` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `banner`
--

INSERT INTO `banner` (`idBanner`, `nomeBanner`, `caminhoBanner`, `statusBanner`) VALUES
(1, 'banner Home', 'admin/upload/banner/banner.png', 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `contato`
--

CREATE TABLE `contato` (
  `id` int(11) NOT NULL,
  `nome` varchar(150) NOT NULL,
  `email` varchar(150) NOT NULL,
  `assunto` varchar(100) NOT NULL,
  `fone` varchar(20) NOT NULL,
  `mens` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `contato`
--

INSERT INTO `contato` (`id`, `nome`, `email`, `assunto`, `fone`, `mens`) VALUES
(16, 'F para o carro', 'adriansantos29@hotmail.com', 'App Mobile', '(48) 99836-6963', 'Teste teste'),
(21, 'julio', 'juliocesar11994952394@gmail.com', 'App Mobile', '11994952394', 'julio');

-- --------------------------------------------------------

--
-- Estrutura para tabela `fonealu`
--

CREATE TABLE `fonealu` (
  `idFone` int(11) NOT NULL,
  `numero` varchar(45) NOT NULL,
  `tipoFone` varchar(45) NOT NULL,
  `descFone` varchar(45) NOT NULL,
  `idAluno` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `fonealu`
--

INSERT INTO `fonealu` (`idFone`, `numero`, `tipoFone`, `descFone`, `idAluno`) VALUES
(1, '97522-2397', 'CELULAR', 'CLARO', 1),
(2, '95645-5058', 'RECADO', 'CLARO', 1),
(3, '93860-8603', 'CELULAR', 'OI', 4),
(4, '92417-3520', 'RECADO', 'TIM', 4),
(5, '99086-5033', 'CELULAR', 'VIVO', 5),
(6, '93196-4221', 'RECADO', 'NEXTEL', 5),
(7, '97322-2397', 'CELULAR', 'CLARO', 6),
(8, '97542-2397', 'RECADO', 'OI', 6),
(9, '97562-2397', 'CELULAR', 'TIM', 7),
(10, '91522-2397', 'RECADO', 'VIVO', 7),
(13, '(11) 95956-0046', 'CELULAR', 'TIM', 23),
(14, '(11) 11111-1111', 'CELULAR', 'OI', 25),
(15, '(99) 99999-9999', 'CELULAR', 'NEXTEL', 26),
(16, '(11) 99495-2525', 'CELULAR', 'CLARO', 27);

-- --------------------------------------------------------

--
-- Estrutura para tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `idFuncionario` int(11) NOT NULL,
  `nomeFunc` varchar(100) NOT NULL,
  `cpf` varchar(45) NOT NULL,
  `email` varchar(100) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `cargo` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  `foto` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `funcionario`
--

INSERT INTO `funcionario` (`idFuncionario`, `nomeFunc`, `cpf`, `email`, `senha`, `cargo`, `status`, `foto`) VALUES
(1, 'Robert', '666.666.666-66', 'thecakeisalierg@gmail.com', '123', 'ADMINISTRADOR', 'ATIVO', 'admin/upload/clientes/visitante.png'),
(2, 'teste', '666.666.666-66', 'teste@gmail.com', '123', 'INSTRUTOR', 'INATIVO', 'admin/upload/clientes/visitante.png'),
(4, 'mika', '999.999.999-99', 'mkmk@12.com', '123', 'INSTRUTOR', 'ATIVO', 'admin/upload/clientes/Lighthouse.jpg');

-- --------------------------------------------------------

--
-- Estrutura para tabela `matriculacfc`
--

CREATE TABLE `matriculacfc` (
  `idAluno` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `cpf` varchar(45) DEFAULT NULL,
  `email` varchar(100) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `data` datetime DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `foto` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `matriculacfc`
--

INSERT INTO `matriculacfc` (`idAluno`, `nome`, `cpf`, `email`, `senha`, `data`, `status`, `foto`) VALUES
(22, 'Visitante', '123.456.789-89', 'visitante@gmail.com', '123', '2020-09-02 00:00:00', 'ATIVO', 'admin/upload/clientes/visitante.png'),
(23, 'Robert Gomes', '123.456.789-89', 'thecakeisalierg@gmail.com', '123', '2020-09-02 00:00:00', 'ATIVO', 'admin/upload/clientes/visitante.png'),
(24, 'teste aluno', '666.666.666-66', 'testealuno@gmail.com', '123', '2020-09-02 00:00:00', 'ATIVO', 'admin/upload/clientes/visitante.png'),
(26, 'Michelle Karine', '999.999.999-99', 'mi@mi.com', '123', '2020-10-01 00:00:00', 'INATIVO', 'admin/upload/clientes/Jellyfish.jpg'),
(27, 'julin', '544.507.126-71', 'julio@gamil.com', 'bingulin', '2020-10-01 00:00:00', 'ATIVO', 'admin/upload/clientes/slide1.jpg');

-- --------------------------------------------------------

--
-- Estrutura para tabela `provas`
--

CREATE TABLE `provas` (
  `idProva` int(11) NOT NULL,
  `prova` varchar(50) DEFAULT '0',
  `minimoAcerto` varchar(600) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `provas`
--

INSERT INTO `provas` (`idProva`, `prova`, `minimoAcerto`) VALUES
(5, 'Google', 'https://www.google.com'),
(8, 'Site', 'https://www.dotiweb.com'),
(9, 'Steam', 'https://steamcommunity.com/id/rgffn'),
(10, 'Consulta', 'https://www.detran.sp.gov.br/wps/portal/portaldetran/cidadao/home/!ut/p/z1/jdBNC4JAEAbgX-O1eXUl1m7bl2WJfVDaXkLLTEg3bKu_X1REh5LmNsMz88KQpIhkGV_yLNa5KuPDvV_J5tqbojMYcGsczFwHU-4HrjW3AJ9R-AD4UQIk_9mvAbL-fEjyQZiNudM2BXhv2YfgM9Y3e4GFEV7gHeGa3Q6EY9v-0BsxOOwFakI8ktlBJc9_iDJhPCNZpbu0SqvGubqP91ofWwYMbJXOr2nS2KjCwDe-VydN0QejY7GIkE-KkJ_EDb9t8aQ!/dz/d5/L2dBISEvZ0FBIS9nQSEh/'),
(11, 'Infrações', 'https://www.detran.sp.gov.br/wps/portal/portaldetran/cidadao/oquefazerquando/9773f0a6-2823-402d-a794-8014d75dd399'),
(12, 'Veículos', 'https://www.detran.sp.gov.br/wps/portal/portaldetran/cidadao/veiculos/home'),
(13, 'Eventos', 'https://www.detran.sp.gov.br/wps/portal/portaldetran/cidadao/educacao/fichaservico/apostilasDenatran'),
(14, 'CNH', 'https://www.detran.sp.gov.br/wps/portal/portaldetran/cidadao/habilitacao/home');

-- --------------------------------------------------------

--
-- Estrutura para tabela `questoes`
--

CREATE TABLE `questoes` (
  `idQuestao` int(11) NOT NULL,
  `idProva` int(11) DEFAULT '0',
  `assunto` varchar(50) DEFAULT NULL,
  `questao` varchar(300) DEFAULT NULL,
  `respostaCerta` varchar(200) NOT NULL,
  `respostaErrada` varchar(200) NOT NULL,
  `respostaErrada1` varchar(200) NOT NULL,
  `respostaErrada2` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `questoes`
--

INSERT INTO `questoes` (`idQuestao`, `idProva`, `assunto`, `questao`, `respostaCerta`, `respostaErrada`, `respostaErrada1`, `respostaErrada2`) VALUES
(8, 5, 'Direção defensiva', 'São condições adversas, em vias pavimentadas, envolvendo riscos que podem contribuir para gerar acidentes', 'Presença de óleo e areia na pista', 'Pavimento em bom estado e acostamento em desnível', 'Acostamento em desnível e sinalização em bom estado', 'Longo trechos de retas e pontes estreitas'),
(9, 5, 'Direção defensiva', 'São condições adversas, em vias pavimentadas, envolvendo riscos que podem contribuir para gerar acidentes', 'Presença de óleo e areia na pista', 'Pavimento em bom estado e acostamento em desnível', 'Acostamento em desnível e sinalização em bom estado', 'Longo trechos de retas e pontes estreitas');

-- --------------------------------------------------------

--
-- Estrutura para tabela `servico`
--

CREATE TABLE `servico` (
  `idServico` int(11) NOT NULL,
  `nomeServico` varchar(100) NOT NULL,
  `valorServico` decimal(10,2) NOT NULL,
  `statusServico` varchar(45) NOT NULL,
  `dataCadServico` date NOT NULL,
  `fotoServico` varchar(250) NOT NULL,
  `fotoServico0` varchar(250) NOT NULL,
  `fotoServico1` varchar(250) NOT NULL,
  `fotoServico2` varchar(250) NOT NULL,
  `fotoServico3` varchar(250) NOT NULL,
  `descServico` text NOT NULL,
  `texto` text NOT NULL,
  `tempoServico` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `servico`
--

INSERT INTO `servico` (`idServico`, `nomeServico`, `valorServico`, `statusServico`, `dataCadServico`, `fotoServico`, `fotoServico0`, `fotoServico1`, `fotoServico2`, `fotoServico3`, `descServico`, `texto`, `tempoServico`) VALUES
(1, 'Categoria A', 616.00, 'ATIVO', '2020-08-25', 'admin/upload/servicos/categoriaa.png', 'admin/upload/servicos/categoriaa.png', 'admin/upload/servicos/categoriaa.png', 'admin/upload/servicos/categoriaa.png', 'admin/upload/servicos/categoriaa.png', 'Motocicleta, Ciclomotor, Motoneta ou Triciclo.', 'Com esse tipo de carteira de motorista, é possível conduzir veículos de duas ou três rodas, com ou sem carro lateral, com mais que 50 de cilindrada.', '08:46:05'),
(2, 'Categoria B', 616.00, 'ATIVO', '2020-08-25', 'admin/upload/servicos/categoriab.png', 'admin/upload/servicos/categoriab.png', 'admin/upload/servicos/categoriab.png', 'admin/upload/servicos/categoriab.png', 'admin/upload/servicos/categoriab.png', 'Automóvel, caminhonete, camioneta e utilitário.', 'Veículos motorizados de duas ou três rodas (Motos e Triciclos), com ou sem carro lateral, da categoria “A” e veículos motorizados da categoria “B”, cujo peso bruto total não exceda a três mil e quinhentos quilogramas e cuja lotação não exceda a oito lugares, excluído o do motorista.', '08:46:05'),
(3, 'Categoria C', 616.00, 'ATIVO', '0000-00-00', 'admin/upload/servicos/categoriab.png', 'admin/upload/servicos/categoriab.png\r\n', 'admin/upload/servicos/categoriab.png', 'admin/upload/servicos/categoriab.png', 'admin/upload/servicos/categoriab.png', 'Veículos elétricos ou Automotores que possuem um peso maior que 3.500 kg.', 'Nesta classe, motoristas podem dirigir todos os tipos de automóveis da categoria B, e também os veículos de carga, não articulados, com mais de 3,5 toneladas de peso bruto total. São exemplos os caminhões, tratores, máquinas agrícolas e de movimentação de carga.', '18:03:42'),
(4, 'Categoria D', 616.00, 'ATIVO', '0000-00-00', 'admin/upload/servicos/categoriad.png', 'admin/upload/servicos/categoriad.png\r\n', 'admin/upload/servicos/categoriad.png', 'admin/upload/servicos/categoriad.png', 'admin/upload/servicos/categoriad.png', 'Õnibus, Micro-ônibus, Vans e todos os veículos inclusos nos tipos B e C.', 'Veículos utilizados no transporte de passageiros, cuja lotação exceda a 08 passageiros, excluindo o motorista. Nesta categoria também estão autorizados a conduzir veículos automotores do tipo motor-casa (“MotorHome”),  com lotação acima de 08 lugares, excluído o do motorista, além de veículos abrangidos pela categoria “B” e “C”.', '18:03:42'),
(5, 'Categoria E', 616.00, 'ATIVO', '0000-00-00', 'admin/upload/servicos/categoriae.png', 'admin/upload/servicos/categoriae.png\r\n', 'admin/upload/servicos/categoriae.png', 'admin/upload/servicos/categoriae.png', 'admin/upload/servicos/categoriae.png', 'Carretas e Caminhões com reboques, Semirreboques articulados e pode conduzir todos os veículos inclusos nos tipos B, C e D.', 'Combinação de veículos em que a unidade tratora se enquadre nas categorias “B”, “C” ou “D” e cuja unidade acoplada, reboque, semirrreboque, trailer ou articulada tenha 6.000 kg (seis mil quilogramas) ou mais de peso bruto total, ou cuja lotação exceda a 8 (oito) lugares. ', '18:03:42'),
(6, 'Categoria AB', 616.00, 'ATIVO', '0000-00-00', 'admin/upload/servicos/categoriaab.png', 'admin/upload/servicos/categoriaab.png\r\n', 'admin/upload/servicos/categoriaab.png', 'admin/upload/servicos/categoriaab.png', 'admin/upload/servicos/categoriaab.png', 'Motocicleta, Ciclomotor, Motoneta, Triciclo, Automóvel, caminhonete, camioneta e utilitário.', 'Veículos motorizados de duas ou três rodas (Motos e Triciclos), com ou sem carro lateral, da categoria “A” e veículos motorizados da categoria “B”, cujo peso bruto total não exceda a três mil e quinhentos quilogramas e cuja lotação não exceda a oito lugares, excluído o do motorista.', '18:03:42'),
(7, 'Adição', 616.00, 'ATIVO', '0000-00-00', 'admin/upload/servicos/adicao.png', 'admin/upload/servicos/adicao.png\r\n', 'admin/upload/servicos/adicao.png', 'admin/upload/servicos/adicao.png', 'admin/upload/servicos/adicao.png', 'Concede ao condutor o direito de conduzir veículos em mais de uma categoria.', 'Este curso foi desenvolvido para as pessoas que já possuem habilitação na categoria “A” ou “B” e deseja adicionar a outra categoria. Ideal para pessoas que desejam a praticidade da motocicleta em certas situações e o conforto e segurança do carro em outras.', '18:03:42'),
(8, 'Reciclagem', 616.00, 'ATIVO', '0000-00-00', 'admin/upload/servicos/reciclagem.png', 'admin/upload/servicos/reciclagem.png\r\n', 'admin/upload/servicos/reciclagem.png', 'admin/upload/servicos/reciclagem.png', 'admin/upload/servicos/reciclagem.png', 'É aplicado em situações em que é necessário recuperar os preceitos de educação no trânsito e promover a reeducação de condutores infratores.', 'A Autoescola, como centros de formação cadastrado pelo DETRAN, oferece o curso de reciclagem da CNH, com objetivo de relembrar aos motoristas infratores sobre as regras do trânsito e outros conhecimentos importantes para uma direção responsável.', '18:03:42');

-- --------------------------------------------------------

--
-- Estrutura para tabela `veiculos`
--

CREATE TABLE `veiculos` (
  `idVeiculo` int(11) NOT NULL,
  `placa` varchar(50) DEFAULT '0',
  `modelo` varchar(50) DEFAULT '0',
  `ano` int(5) DEFAULT '0',
  `renavam` varchar(50) DEFAULT '0',
  `chassi` varchar(50) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `veiculos`
--

INSERT INTO `veiculos` (`idVeiculo`, `placa`, `modelo`, `ano`, `renavam`, `chassi`) VALUES
(1, 'LVH-6075', 'GOL', 1994, '', ''),
(2, 'AAA-111', 'Ford KA', 1977, '123343434343', '21321343432');

--
-- Índices de tabelas apagadas
--

--
-- Índices de tabela `aulap`
--
ALTER TABLE `aulap`
  ADD PRIMARY KEY (`idAulaP`),
  ADD KEY `idAluno` (`idAluno`),
  ADD KEY `idFuncionario` (`idFuncionario`),
  ADD KEY `idServico` (`idServico`),
  ADD KEY `idVeiculo` (`idVeiculo`);

--
-- Índices de tabela `aulat`
--
ALTER TABLE `aulat`
  ADD PRIMARY KEY (`idAulaT`),
  ADD KEY `idAluno` (`idAluno`),
  ADD KEY `idFuncionario` (`idFuncionario`),
  ADD KEY `idServico` (`idServico`);

--
-- Índices de tabela `banner`
--
ALTER TABLE `banner`
  ADD PRIMARY KEY (`idBanner`);

--
-- Índices de tabela `contato`
--
ALTER TABLE `contato`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `fonealu`
--
ALTER TABLE `fonealu`
  ADD PRIMARY KEY (`idFone`);

--
-- Índices de tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`idFuncionario`);

--
-- Índices de tabela `matriculacfc`
--
ALTER TABLE `matriculacfc`
  ADD PRIMARY KEY (`idAluno`);

--
-- Índices de tabela `provas`
--
ALTER TABLE `provas`
  ADD PRIMARY KEY (`idProva`);

--
-- Índices de tabela `questoes`
--
ALTER TABLE `questoes`
  ADD PRIMARY KEY (`idQuestao`),
  ADD KEY `idProva` (`idProva`);

--
-- Índices de tabela `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`idServico`);

--
-- Índices de tabela `veiculos`
--
ALTER TABLE `veiculos`
  ADD PRIMARY KEY (`idVeiculo`);

--
-- AUTO_INCREMENT de tabelas apagadas
--

--
-- AUTO_INCREMENT de tabela `aulap`
--
ALTER TABLE `aulap`
  MODIFY `idAulaP` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `aulat`
--
ALTER TABLE `aulat`
  MODIFY `idAulaT` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `banner`
--
ALTER TABLE `banner`
  MODIFY `idBanner` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `contato`
--
ALTER TABLE `contato`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de tabela `fonealu`
--
ALTER TABLE `fonealu`
  MODIFY `idFone` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `idFuncionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `matriculacfc`
--
ALTER TABLE `matriculacfc`
  MODIFY `idAluno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT de tabela `provas`
--
ALTER TABLE `provas`
  MODIFY `idProva` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `questoes`
--
ALTER TABLE `questoes`
  MODIFY `idQuestao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `servico`
--
ALTER TABLE `servico`
  MODIFY `idServico` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `veiculos`
--
ALTER TABLE `veiculos`
  MODIFY `idVeiculo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restrições para dumps de tabelas
--

--
-- Restrições para tabelas `aulap`
--
ALTER TABLE `aulap`
  ADD CONSTRAINT `aulap_ibfk_1` FOREIGN KEY (`idAluno`) REFERENCES `matriculacfc` (`idAluno`),
  ADD CONSTRAINT `aulap_ibfk_2` FOREIGN KEY (`idFuncionario`) REFERENCES `funcionario` (`idFuncionario`),
  ADD CONSTRAINT `aulap_ibfk_3` FOREIGN KEY (`idServico`) REFERENCES `servico` (`idServico`),
  ADD CONSTRAINT `aulap_ibfk_4` FOREIGN KEY (`idVeiculo`) REFERENCES `veiculos` (`idVeiculo`);

--
-- Restrições para tabelas `aulat`
--
ALTER TABLE `aulat`
  ADD CONSTRAINT `aulat_ibfk_1` FOREIGN KEY (`idAluno`) REFERENCES `matriculacfc` (`idAluno`),
  ADD CONSTRAINT `aulat_ibfk_2` FOREIGN KEY (`idFuncionario`) REFERENCES `funcionario` (`idFuncionario`),
  ADD CONSTRAINT `aulat_ibfk_3` FOREIGN KEY (`idServico`) REFERENCES `servico` (`idServico`);

--
-- Restrições para tabelas `questoes`
--
ALTER TABLE `questoes`
  ADD CONSTRAINT `questoes_ibfk_1` FOREIGN KEY (`idProva`) REFERENCES `provas` (`idProva`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
