CREATE DATABASE AcademySolution;

GO


USE AcademySolution;
GO

CREATE TABLE TblCategory(
	CodCategory INT IDENTITY(1,1),--PK
	Name VARCHAR(20),
	Description TEXT,
	CONSTRAINT PK_CATEGORY PRIMARY KEY (CodCategory)
)

CREATE TABLE TblConta(
	CodAccount INT IDENTITY(100,1),--PK
	Nome VARCHAR(50),
	Sobrenome VARCHAR(50),
	DataNasc DATE,
	DataRegistro Date,
	CodCategory int,
	Email VARCHAR(50),
	Rua	varchar(100),
	Numero int,
	Complemento varchar(30),
	Bairro varchar(50),
	Cidade varchar (50),
	Estado varchar (50),
	Pais varchar(50),
	Cpf varchar(20),
	Telefone float,
	CONSTRAINT PK_ACCOUNT PRIMARY KEY (CodAccount),
	CONSTRAINT FK_ACCOUNT_CATEGORY FOREIGN KEY (CodCategory) REFERENCES TblCategory (CodCategory)
)

CREATE TABLE TblLogin(
	CodLogin INT IDENTITY(1000,1),
	CodAccount INT, --FK
	Username VARCHAR(20),
	Password VARCHAR (40),
	CONSTRAINT PK_LOGIN PRIMARY KEY (CodLogin),
	CONSTRAINT FK_LOGIN_PK_ACCOUNT FOREIGN KEY (CodAccount) REFERENCES TblConta (CodAccount)
)

CREATE TABLE TblRecord(
	CodStudent INT,--FK
	CodTrainer INT,--FK
	DateBegin DATETIME,
	DateExpiration DATETIME,
	CONSTRAINT FK_RECORDSTUDENT_PKACCOUNT FOREIGN KEY (CodStudent) REFERENCES TblConta (CodAccount),
	CONSTRAINT FK_RECORDTRAINER_PKACCOUNT FOREIGN KEY (CodTrainer) REFERENCES TblConta (CodAccount)
)

CREATE TABLE TblExercises(
	CodExercise INT IDENTITY(1,1),--PK
	Name VARCHAR (20),
	Description TEXT
	CONSTRAINT PK_EXERCISE PRIMARY KEY (CodExercise)
)

USE AcademySolution;

-- 
INSERT INTO TblCategory VALUES ('Student','Student');
INSERT INTO TblCategory VALUES ('Trainer','Trainer');
INSERT INTO TblCategory VALUES ('Administrator','Administrador do sistema');
INSERT INTO TblCategory VALUES ('Developer','Desenvolvedor do sistema');
--

--
INSERT INTO TblConta VALUES ('Bruno', 'Leone','1997/05/08',GETDATE(),4,'contact@leonecorrea.com','R. Sergipe',' 811',null,  'Funcionários', 'Belo Horizonte' , 'MG' , 'Brasil', '12046659820', 31998885050);
INSERT INTO TblConta VALUES ('Gladson', 'Bruno','1997/05/08',GETDATE(),4,'gladsonbruno@gmail.com','R. Sergipe', '811',null, 'Funcionários', 'Belo Horizonte' , 'MG', 'Brasil', '12046659830', 31998885060);
INSERT INTO TblConta VALUES ('Robert', 'Max','1997/05/08',GETDATE(),4,'robermax@gmail.com','R. Sergipe', '811',null, 'Funcionários', 'Belo Horizonte', 'MG','Brasil','12046659840', 31998885070)
--
select * from TblConta
--
INSERT INTO TblLogin VALUES (100,'Bruno Leone','b41d0c91f1c31e2cddfdc24ce41a4f82');
INSERT INTO TblLogin VALUES (101,'Gladson Bruno','e2c450ce04c1823d9838b5ef1a4e1183');
INSERT INTO TblLogin VALUES (102,'Robert Max','c9dc13710e09a3c2fd13df39ca40d3ad');
--

-- Atualização de senha
DECLARE @USERNAME AS VARCHAR = 'Bruno Leone';
DECLARE @PASSWORD AS VARCHAR = 'b41d0c91f1c31e2cddfdc24ce41a4f82';
--UPDATE TblLogin SET Password = @PASSWORD WHERE Username = @USERNAME;
--
SELECT CodLogin AS Codigo, Nome, Sobrenome, Email, Username, Password FROM TblLogin INNER JOIN TblConta ON TblConta.CodAccount=TblLogin.CodLogin WHERE CodLogin=1000;
SELECT CodLogin AS Codigo, Nome, Sobrenome, Email, Username, Password FROM TblLogin INNER JOIN TblConta ON TblConta.CodAccount=TblLogin.CodLogin ORDER BY CodLogin ASC;

--
SELECT * FROM TblConta;
SELECT * FROM TblCategory;
SELECT * FROM TblLogin;
--