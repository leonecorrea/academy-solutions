USE AcademySolution;

-- Atualização de senha
DECLARE @USERNAME AS VARCHAR = 'Bruno Leone';
DECLARE @PASSWORD AS VARCHAR = 'b41d0c91f1c31e2cddfdc24ce41a4f82';
--UPDATE tb_Logins SET Password = @PASSWORD WHERE Username = @USERNAME;
--
SELECT Id AS Id, Nome, Sobrenome, Email, Username, Password FROM tb_logins INNER JOIN tb_contas ON tb_contas.Id=tb_Login.Id WHERE Id=1000;
SELECT Id AS Id, Nome, Sobrenome, Email, Username, Password FROM tb_logins INNER JOIN tb_contas ON tb_contas.Id=tb_Login.Id ORDER BY Id ASC;
--
SELECT * FROM v_alunos WHERE Nome LIKE '%%Edu%%'
--
SELECT * FROM tb_contas;
SELECT * FROM tb_categorias;
SELECT * FROM tb_logins;
SELECT * FROM tb_cidades;
SELECT * FROM tb_estados;
--
UPDATE v_alunos SET Nome = 'Eduarda Diniz Rabelo', Cpf = '22222222222',DataRegistro = '',Email = '', 
Rua = '', Numero = '', Cidade = '', Pais = '', Telefone = '', Complemento = '' WHERE Codigo = '103';


-------------------------------------------------------------------------------------------------------------------------------------
DECLARE @IDFICHA AS INT = 1;
--Pesquisa para a ficha
-- Cabeçalho da ficha (Nome aluno, inicio, termino)
select tb_contas.Nome as NomeAluno, tb_records.DateBegin as Inicio, tb_records.DateExpiration as Termino from tb_contas inner join tb_records on tb_contas.Id = tb_records.IdStudent where tb_records.IdRecord = @IDFICHA;
-- Nome professor
select tb_contas.Nome as NomeProf from tb_contas inner join tb_records on tb_contas.Id = tb_records.IdTrainer where tb_records.IdRecord = @IDFICHA;

--Exercicios da ficha (Nome Exercicio, series, repetições)
select tb_exercises.Name as NomeExercicio, tb_record_exercises.repetitions as Repeticoes, tb_record_exercises.Series as Series from tb_exercises inner join tb_record_exercises on tb_exercises.Id = tb_record_exercises.idExercise  inner join tb_records on tb_records.IdRecord = tb_record_exercises.idRecord where tb_record_exercises.idRecord = @IDFICHA;
