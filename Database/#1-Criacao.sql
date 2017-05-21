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
  nome varchar(20) NOT NULL DEFAULT '',
  PRIMARY KEY  (id)
)
---
-- Estrutura da tabela tb_cidades
--
CREATE TABLE tb_cidades (
  id INT NOT NULL,
  estado INT NOT NULL DEFAULT '00',
  uf VARCHAR(4) NOT NULL DEFAULT '',
  nome varchar(50) NOT NULL DEFAULT '',
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
	DataRegistro Date,
	Categoria int,
	Email VARCHAR(50),
	Rua	varchar(100),
	Numero int,
	Complemento varchar(30),
	Bairro varchar(50),
	Cidade VARCHAR(50),
	Estado VARCHAR(50),
	Pais varchar(50),
	Cpf varchar(20),
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
	IdStudent INT,--FK
	IdTrainer INT,--FK
	DateBegin DATETIME,
	DateExpiration DATETIME,
	CONSTRAINT FK_RECORDSTUDENT_PKACCOUNTS FOREIGN KEY (IdStudent) REFERENCES tb_contas (Id),
	CONSTRAINT FK_RECORDTRAINER_PKACCOUNTS FOREIGN KEY (IdTrainer) REFERENCES tb_contas (Id)
)
---
-- Estrutura da tabela tb_exercises
---
CREATE TABLE tb_exercises(
	Id INT IDENTITY(1,1),--PK
	Name VARCHAR (20),
	Description TEXT
	CONSTRAINT PK_EXERCISES PRIMARY KEY (Id)
)