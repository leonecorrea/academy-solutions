use AcademySolution;

DECLARE @Nome VARCHAR(23) = 'Teet';
DECLARE @DateBirth DATETIME = SYSDATETIME();
DECLARE @DateRegister DATETIME = SYSDATETIME();
DECLARE @Categoria INT = 1;
DECLARE @Email VARCHAR(234) = 'ADFA'
DECLARE @Rua VARCHAR(34) = 'ASDF'
DECLARE @Numero INT = 23;
DECLARE @Complemento VARCHAR(234) = '';
DECLARE @Bairro VARCHAR(32) = '';
DECLARE @Cidade VARCHAR(23) = '';
DECLARE @Estado VARCHAR (324) = '';
DECLARE @Country VARCHAR(23) = '';
DECLARE @Cpf VARCHAR(22) = '';
DECLARE @Telefone VARCHAR(234) = '';
DECLARE @DataUpdate DATETIME = SYSDATETIME();

insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, 
Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone,DataUpdate) 
values(@Nome, @DateBirth, @DateRegister, @Categoria, @Email, @Rua, @Numero, @Complemento, @Bairro,
@Cidade, @Estado, @Country, @Cpf, @Telefone,@DataUpdate);

SELECT * FROM TB_CONTAS