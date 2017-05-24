USE AcademySolution;
GO
---
--Estraindo dados da tabela Categorias
---

INSERT INTO tb_categorias VALUES ('Aluno','Student');
INSERT INTO tb_categorias VALUES ('Treinador','Trainer');
INSERT INTO tb_categorias VALUES ('Recepção','Recepção da Academia');
INSERT INTO tb_categorias VALUES ('Administrator Master','Administrador Geral do Sistema');
INSERT INTO tb_categorias VALUES ('Developer','Desenvolvedor do Sistema');

-----------------------------------------------------------------------------------
---
--Extraindo dados para tb_contas
---(Nome, DataNasc, DataRegistro, Email, Rua, Numero, Bairro, Cidade,Estado, Cpf,Telefone,Complemento,Pais,DataUpdate)

INSERT INTO tb_contas (Nome, DataNasc,DataRegistro,Categoria,Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone, DataUpdate ) 
VALUES ('Bruno Leone','1997/05/08',SYSDATETIME(),4,'contact@leonecorrea.com','R. Sergipe','811',null, 'Funcionários','Belo Horizonte','MG','Brasil', '12046659820', 31998885050, null);

INSERT INTO tb_contas (Nome, DataNasc,DataRegistro,Categoria,Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone, DataUpdate )
 VALUES ('Gladson Bruno','1997/05/08',SYSDATETIME(),4,'gladsonbruno@gmail.com','R. Sergipe','811',null,'Funcionários', 'Belo Horizonte' , 'MG', 'Brasil', '12046659830', 31998885060, null);

INSERT INTO tb_contas (Nome, DataNasc,DataRegistro,Categoria,Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone, DataUpdate )
 VALUES ('Robert Max','1997/05/08',SYSDATETIME(),4,'robermax@gmail.com','R. Sergipe', '811',null,'Funcionários', 'Belo Horizonte', 'MG','Brasil','12046659840', 31998885070, null);

INSERT INTO tb_contas (Nome, DataNasc,DataRegistro,Categoria,Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone, DataUpdate )
 VALUES ('Gina Souza','1997/05/08',SYSDATETIME(),1,'gina@gmail.com','R. Sergipe', '811',null,'Funcionários', 'Belo Horizonte', 'MG','Brasil','12046699840', 31989885070, null);

INSERT INTO tb_contas (Nome, DataNasc,DataRegistro,Categoria,Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone, DataUpdate )
 VALUES ('Amanda Florenciano','1997/05/08',SYSDATETIME(),2,'amanda@gmail.com','R. Sergipe', '811',null,'Funcionários', 'Belo Horizonte', 'MG','Brasil','12046694567', 31989885070, null);

INSERT INTO tb_contas (Nome, DataNasc,DataRegistro,Categoria,Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone, DataUpdate )
 VALUES ('Roberto Amancio Nolasco','1988/05/08',SYSDATETIME(),1,'roberto@gmail.com','R. Sergipe', '811',null,'Funcionários', 'Belo Horizonte', 'MG','Brasil','12046694567', 31989885070, null);

INSERT INTO tb_contas (Nome, DataNasc,DataRegistro,Categoria,Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone, DataUpdate )
 VALUES ('Ronaldo Fenomeno','1969/05/08',SYSDATETIME(),1,'fenomeno@gmail.com','R. Sergipe', '811',null,'Funcionários', 'Belo Horizonte', 'MG','Brasil','12046694567', 31989885070, null);

INSERT INTO tb_contas (Nome, DataNasc,DataRegistro,Categoria,Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone, DataUpdate )
 VALUES ('Cristovão Colombo','1768/05/08',SYSDATETIME(),2,'colombo@gmail.com','R. Sergipe', '811',null,'Funcionários', 'Belo Horizonte', 'MG','Brasil','12046694567', 31989885070, null);

INSERT INTO tb_contas (Nome, DataNasc,DataRegistro,Categoria,Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone, DataUpdate )
 VALUES ('Alex Montanhes','1989/05/08',SYSDATETIME(),2,'tenentemontanha@gmail.com','R. Sergipe', '811',null,'Funcionários', 'Belo Horizonte', 'MG','Brasil','12046694567', 31989885070, null);
-----------------------------------------------------------------------------------
---
-- Extraindo dados para tb_logins
--

INSERT INTO tb_Logins VALUES (100,'Bruno Leone','b41d0c91f1c31e2cddfdc24ce41a4f82');
INSERT INTO tb_Logins VALUES (101,'Gladson Bruno','e2c450ce04c1823d9838b5ef1a4e1183');
INSERT INTO tb_Logins VALUES (102,'Robert Max','c9dc13710e09a3c2fd13df39ca40d3ad');

-----------------------------------------------------------------------------------