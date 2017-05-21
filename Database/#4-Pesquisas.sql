USE AcademySolution;

-- Atualização de senha
DECLARE @USERNAME AS VARCHAR = 'Bruno Leone';
DECLARE @PASSWORD AS VARCHAR = 'b41d0c91f1c31e2cddfdc24ce41a4f82';
--UPDATE tb_Logins SET Password = @PASSWORD WHERE Username = @USERNAME;
--
SELECT Id AS Id, Nome, Sobrenome, Email, Username, Password FROM tb_logins INNER JOIN tb_contas ON tb_contas.Id=tb_Login.Id WHERE Id=1000;
SELECT Id AS Id, Nome, Sobrenome, Email, Username, Password FROM tb_logins INNER JOIN tb_contas ON tb_contas.Id=tb_Login.Id ORDER BY Id ASC;
--
SELECT * FROM tb_contas;
SELECT * FROM tb_categorias;
SELECT * FROM tb_logins;
SELECT * FROM tb_cidades;
SELECT * FROM tb_estados;
--