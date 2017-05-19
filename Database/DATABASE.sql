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

CREATE TABLE TblAccount(
	CodAccount INT IDENTITY(100,1),--PK
	LastName VARCHAR(50),
	FirstName VARCHAR(50),
	Email VARCHAR(50),
	DateBirth DATE,
	DateRegister DATETIME,
	Address VARCHAR (255),
	CodCategory INT,--FK
	CONSTRAINT PK_ACCOUNT PRIMARY KEY (CodAccount),
	CONSTRAINT FK_ACCOUNT_CATEGORY FOREIGN KEY (CodCategory) REFERENCES TblCategory (CodCategory)
)

CREATE TABLE TblLogin(
	CodLogin INT IDENTITY(1000,1),
	CodAccount INT, --FK
	Username VARCHAR(20),
	Password VARCHAR (40),
	CONSTRAINT PK_LOGIN PRIMARY KEY (CodLogin),
	CONSTRAINT FK_LOGIN_PK_ACCOUNT FOREIGN KEY (CodAccount) REFERENCES TblAccount (CodAccount)
)

CREATE TABLE TblRecord(
	CodStudent INT,--FK
	CodTrainer INT,--FK
	DateBegin DATETIME,
	DateExpiration DATETIME,
	CONSTRAINT FK_RECORDSTUDENT_PKACCOUNT FOREIGN KEY (CodStudent) REFERENCES TblAccount (CodAccount),
	CONSTRAINT FK_RECORDTRAINER_PKACCOUNT FOREIGN KEY (CodTrainer) REFERENCES TblAccount (CodAccount)
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
INSERT INTO TblAccount VALUES ('Bruno', 'Leone','contact@leonecorrea.com','1997/05/08',GETDATE(),'R. Sergipe, 811 - Funcionários, Belo Horizonte - MG, 30130-171',4);
INSERT INTO TblAccount VALUES ('Gladson', 'Bruno','gladsonbruno@gmail.com','1997/05/08',GETDATE(),'R. Sergipe, 811 - Funcionários, Belo Horizonte - MG, 30130-171',4);
INSERT INTO TblAccount VALUES ('Robert', 'Max','robermax@gmail.com','1997/05/08',GETDATE(),'R. Sergipe, 811 - Funcionários, Belo Horizonte - MG, 30130-171',4);
--

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
SELECT CodLogin AS Codigo, FirstName, LastName, Email, Username, Password FROM TblLogin INNER JOIN TblAccount ON TblAccount.CodAccount=TblLogin.CodLogin WHERE CodLogin=1000;
SELECT CodLogin AS Codigo, FirstName, LastName, Email, Username, Password FROM TblLogin INNER JOIN TblAccount ON TblAccount.CodAccount=TblLogin.CodLogin ORDER BY CodLogin ASC;
--

--
SELECT * FROM TblAccount;
SELECT * FROM TblCategory;
SELECT * FROM TblLogin;
--