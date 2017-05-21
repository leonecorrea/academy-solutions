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
---
INSERT INTO tb_contas VALUES ('Bruno Leone','1997/05/08',GETDATE(),4,'contact@leonecorrea.com','R. Sergipe','811',null,
	'Funcionários','Belo Horizonte','MG','Brasil', '12046659820', 31998885050);
INSERT INTO tb_contas VALUES ('Gladson Bruno','1997/05/08',GETDATE(),4,'gladsonbruno@gmail.com','R. Sergipe','811',null,
'Funcionários', 'Belo Horizonte' , 'MG', 'Brasil', '12046659830', 31998885060);
INSERT INTO tb_contas VALUES ('Robert Max','1997/05/08',GETDATE(),4,'robermax@gmail.com','R. Sergipe', '811',null,
	'Funcionários', 'Belo Horizonte', 'MG','Brasil','12046659840', 31998885070);
-----------------------------------------------------------------------------------
---
-- Extraindo dados para tb_logins
--
INSERT INTO tb_Logins VALUES (100,'Bruno Leone','b41d0c91f1c31e2cddfdc24ce41a4f82');
INSERT INTO tb_Logins VALUES (101,'Gladson Bruno','e2c450ce04c1823d9838b5ef1a4e1183');
INSERT INTO tb_Logins VALUES (102,'Robert Max','c9dc13710e09a3c2fd13df39ca40d3ad');
-----------------------------------------------------------------------------------
