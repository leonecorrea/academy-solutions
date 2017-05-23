CREATE DATABASE AcademySolution;
GO

USE AcademySolution;
GO

-- 
-- Estrutura da tabela tb_estados
-- 
CREATE TABLE tb_estados (
  id INT NOT NULL,
  uf VARCHAR(10) DEFAULT '',
  nome VARCHAR(20) NOT NULL DEFAULT '',
  PRIMARY KEY  (id)
)
---
-- Estrutura da tabela tb_cidades
--
CREATE TABLE tb_cidades (
  id INT NOT NULL,
  estado INT NOT NULL DEFAULT '00',
  uf VARCHAR(4) NOT NULL DEFAULT '',
  nome VARCHAR(50) NOT NULL DEFAULT '',
  CONSTRAINT UK_CIDADES UNIQUE(id),
  CONSTRAINT FK_CIDADES_PK_ESTADOS FOREIGN KEY (estado) REFERENCES tb_estados(id)
)
---
--Estrutura da tabela tb_categorias
---
CREATE TABLE tb_categorias(
	Id INT IDENTITY(1,1),--PK
	Name VARCHAR(20),
	Description TEXT,
	CONSTRAINT PK_CATEGORY PRIMARY KEY (Id)
)
---
--Estrutura da tabela tb_contas
--
CREATE TABLE tb_contas(
	Id INT IDENTITY(100,1),--PK
	Nome VARCHAR(100),
	DataNasc DATE,
	DataRegistro DATETIME,
	Categoria INT,
	Email VARCHAR(50),
	Rua	VARCHAR(100),
	Numero INT,
	Complemento VARCHAR(30),
	Bairro VARCHAR(50),
	Cidade VARCHAR(50),
	Estado VARCHAR(50),
	Pais VARCHAR(50),
	Cpf VARCHAR(20),
	Telefone float,
	CONSTRAINT PK_ACCOUNT PRIMARY KEY (Id),
	CONSTRAINT FK_ACCOUNT_CATEGORY FOREIGN KEY (Categoria) REFERENCES tb_categorias (Id)
)
---
--Estrutura da tabela tb_logins
---
CREATE TABLE tb_logins(
	Id INT IDENTITY(1000,1),
	IdConta INT, --FK
	Username VARCHAR(20),
	Password VARCHAR (40),
	CONSTRAINT PK_LOGINS PRIMARY KEY (Id),
	CONSTRAINT FK_LOGINS_PK_CONTAS FOREIGN KEY (IdConta) REFERENCES tb_contas (Id)
)
---
-- Estrutura da tabela tb_records
---
CREATE TABLE tb_records(
	IdRecord INT  IDENTITY(1,1),
	IdStudent INT,--FK
	IdTrainer INT,--FK
	DateBegin DATE,
	DateExpiration DATE,
	CONSTRAINT PK_FICHA PRIMARY KEY(IdRecord),
	CONSTRAINT FK_RECORDSTUDENT_PKACCOUNTS FOREIGN KEY (IdStudent) REFERENCES tb_contas (Id),
	CONSTRAINT FK_RECORDTRAINER_PKACCOUNTS FOREIGN KEY (IdTrainer) REFERENCES tb_contas (Id)
)
--Inserção de teste
--INSERT INTO tb_records (IdStudent, IdTrainer, DateBegin, DateExpiration) values(100, 101, GETDATE(), '2017-08-22');
---
-- Estrutura da tabela tb_exercises
---
CREATE TABLE tb_exercises(
	Id INT IDENTITY(1,1),--PK
	Name VARCHAR (20),
	Description Text,
	CONSTRAINT PK_EXERCISES PRIMARY KEY (Id),
)
--inserção de teste
--insert into tb_exercises(Name, Description) values('Prancha fronta', 'Prancha frontal com elevação do quadril');
---
---
-- Estrutura tabela tb_record_exercises(Exercicios de uma ficha)
create table tb_record_exercises(
	idRecord int,
	idExercise int,
	Series int,
	repetitions int,
	CONSTRAINT FK_RECORD FOREIGN KEY (idRecord) references tb_records(IdRecord),
	CONSTRAINT FK_EXERCISE FOREIGN KEY(idExercise) references tb_exercises(ID)
)
--inserção de teste
--insert into tb_record_exercises values(1,1,3,12);
--Comando para obter os exercicios de determinada ficha
--select tb_exercises.Name from tb_exercises inner join tb_record_exercises on tb_exercises.Id = tb_record_exercises.idExercise  inner join tb_records on tb_records.IdRecord = tb_record_exercises.idRecord where tb_record_exercises.idRecord = @idFicha;
---
--Estrutura da View Alunos
---
-- Visão de todos os alunos
DROP VIEW v_alunos
CREATE VIEW v_alunos AS SELECT Id AS Codigo, Nome, DataNasc AS DataDeNascimento, Cpf, DataRegistro, Email, Rua, Numero, Bairro, Cidade,Estado,Telefone,Complemento,Pais FROM tb_contas;
-- Visão de um aluno especifico
DECLARE @Id AS INT = 100;
SELECT * FROM v_aluno WHERE Codigo=@Id;
