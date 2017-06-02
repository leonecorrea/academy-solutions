CREATE DATABASE AcademySolution;
GO
--drop database AcademySolution
--use gabaritoprova
USE AcademySolution;
GO
-- 
-- Estrutura da tabela tb_estados
-- 
CREATE TABLE tb_estados (
	id 				INT NOT NULL,
	uf 				VARCHAR(10) DEFAULT '',
	nome 			VARCHAR(20) NOT NULL DEFAULT '',
	PRIMARY KEY  (id)
)
GO
---
-- Estrutura da tabela tb_cidades
--
CREATE TABLE tb_cidades (
	id 					INT NOT NULL,
	estado 				INT NOT NULL DEFAULT '00',
	uf 					VARCHAR(4) NOT NULL DEFAULT '',
	nome 				VARCHAR(50) NOT NULL DEFAULT '',
	CONSTRAINT UK_CIDADES UNIQUE(id),
	CONSTRAINT FK_CIDADES_PK_ESTADOS FOREIGN KEY (estado) REFERENCES tb_estados(id)
)
GO
---
--Estrutura da tabela tb_categorias
---
CREATE TABLE tb_categorias(
	Id 					INT IDENTITY(1,1),--PK
	Name 				VARCHAR(20),
	Description 		TEXT,
	CONSTRAINT PK_CATEGORY PRIMARY KEY (Id)
)
GO
---
--Estrutura da tabela tb_contas
--
CREATE TABLE tb_contas(
	Id 					INT IDENTITY(100,1),--PK
	Nome 				VARCHAR(100),
	DataNasc 			DATE,
	Categoria 			VARCHAR(20),
	Email 				VARCHAR(50),
	Cpf 				VARCHAR(20),
	Telefone 			VARCHAR(20),
	Rua				VARCHAR(50),
	Numero 			VARCHAR(20),
	Complemento 		VARCHAR(30),
	Bairro 				VARCHAR(50),
	Cidade 				VARCHAR(50),
	Estado 				VARCHAR(50),
	Pais 				VARCHAR(50),
	DataRegistro 		DATETIME,
	DataUpdate 		DATETIME,
	CONSTRAINT PK_CONTA PRIMARY KEY (Id),
	CONSTRAINT FK_CONTA_CATEGORIA FOREIGN KEY (Categoria) REFERENCES tb_categorias (Id)
)
GO
---
--Estrutura da tabela tb_logins
---
CREATE TABLE tb_logins(
	Id 					INT IDENTITY(100,1),
	IdConta 			INT, --FK
	Username 			VARCHAR(20),
	Password 			VARCHAR (40),
	CONSTRAINT PK_LOGINS PRIMARY KEY (Id),
	CONSTRAINT FK_LOGINS_PK_CONTAS FOREIGN KEY (IdConta) REFERENCES tb_contas (Id)
)
GO
---
-- Estrutura da tabela tb_records
---
CREATE TABLE tb_records(
	IdRecord 			INT  IDENTITY(1,1),
	IdStudent 			INT,--FK
	IdTrainer 			INT,--FK
	DateBegin 			DATE,
	DateExpiration 		DATE,
	CONSTRAINT PK_FICHA PRIMARY KEY(IdRecord),
	CONSTRAINT FK_RECORDSTUDENT_PKACCOUNTS FOREIGN KEY (IdStudent) REFERENCES tb_contas (Id),
	CONSTRAINT FK_RECORDTRAINER_PKACCOUNTS FOREIGN KEY (IdTrainer) REFERENCES tb_contas (Id)
)
GO
--Inserção de teste
--INSERT INTO tb_records (IdStudent, IdTrainer, DateBegin, DateExpiration) values(100, 101, GETDATE(), '2017-08-22');
---
-- Estrutura da tabela tb_exercises
---
CREATE TABLE tb_exercises(
	Id 					INT IDENTITY(1,1),--PK
	Name 				VARCHAR (50),
	Description 		TEXT,
	CONSTRAINT PK_EXERCISES PRIMARY KEY (Id),
)
GO
--inserção de teste
--insert into tb_exercises(Name, Description) values('Prancha fronta', 'Prancha frontal com elevação do quadril');
---
---
-- Estrutura tabela tb_record_exercises(Exercicios de uma ficha)
CREATE TABLE tb_record_exercises(
	idRecord 			INT,
	idExercise 			INT,
	Series 				VARCHAR (50),
	repetitions 			VARCHAR (50),
	CONSTRAINT FK_RECORD FOREIGN KEY (idRecord) references tb_records(IdRecord),
	CONSTRAINT FK_EXERCISE FOREIGN KEY(idExercise) references tb_exercises(ID)
)
GO
--inserção de teste
--insert into tb_record_exercises values(1,1,3,12);
--Comando para obter os exercicios de determinada ficha
--select tb_exercises.Name from tb_exercises inner join tb_record_exercises on tb_exercises.Id = tb_record_exercises.idExercise  inner join tb_records on tb_records.IdRecord = tb_record_exercises.idRecord where tb_record_exercises.idRecord = @idFicha;
---
--Estrutura da View Alunos
---
-- Visão de todos os alunos
--DROP VIEW v_alunos
CREATE VIEW v_alunos AS SELECT Id AS Codigo, Nome, DataNasc AS DataDeNascimento, Cpf, DataRegistro, Email, Rua, Numero, Bairro, Cidade,Estado,Telefone,Complemento,Pais,DataUpdate FROM tb_contas WHERE Categoria = 1;
GO
-- Visão de um aluno especifico
/*DECLARE @Id AS INT = 100;
SELECT * FROM v_alunos WHERE Codigo=100;*/
CREATE VIEW v_trainners AS SELECT Id AS Codigo, Nome, DataNasc AS DataDeNascimento, Cpf, DataRegistro, Email, Rua, Numero, Bairro, Cidade,Estado,Telefone,Complemento,Pais FROM tb_contas WHERE Categoria = 2;
GO
--SELECT * FROM v_trainers 
create view v_categorias as select id as Codigo, name as Nome, description as Descricao from tb_categorias
GO
--select * from v_categorias