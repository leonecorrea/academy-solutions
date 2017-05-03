CREATE DATABASE AcademiaSolutions;
GO

CREATE TABLE Account(
	Cod_Account INT NOT NULL IDENTITY (10000,1),
	UserName VARCHAR(25) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	CONSTRAINT PK_ACCOUNT PRIMARY KEY (Cod_Account)
)

SELECT * FROM Account;

INSERT INTO Account (UserName, Password) VALUES ('admin','admin');
INSERT INTO Account (UserName, Password) VALUES ('bruno','bruno');
INSERT INTO Account (UserName, Password) VALUES ('leone','leone');