USE AcademySolution;

-- 
INSERT INTO TblCategory VALUES ('Student','Student');
INSERT INTO TblCategory VALUES ('Trainer','Trainer');
INSERT INTO TblCategory VALUES ('Administrator','Administrador do sistema');
INSERT INTO TblCategory VALUES ('Developer','Desenvolvedor do sistema');
--

--
INSERT INTO TblAccount VALUES ('Bruno Leone Corrêa','contact@leonecorrea.com','1997/05/08',GETDATE(),'R. Sergipe, 811 - Funcionários, Belo Horizonte - MG, 30130-171',4);
INSERT INTO TblAccount VALUES ('Gladson Bruno','gladsonbruno@gmail.com','1997/05/08',GETDATE(),'R. Sergipe, 811 - Funcionários, Belo Horizonte - MG, 30130-171',4);
INSERT INTO TblAccount VALUES ('Robert Max','robermax@gmail.com','1997/05/08',GETDATE(),'R. Sergipe, 811 - Funcionários, Belo Horizonte - MG, 30130-171',4);
--

--
INSERT INTO TblLogin VALUES (100,'Bruno Leone','b41d0c91f1c31e2cddfdc24ce41a4f82');
INSERT INTO TblLogin VALUES (101,'Gladson Bruno','e2c450ce04c1823d9838b5ef1a4e1183');
INSERT INTO TblLogin VALUES (102,'Robert Max','c9dc13710e09a3c2fd13df39ca40d3ad');
--

--

--

--
SELECT * FROM TblAccount;
SELECT * FROM TblCategory;
SELECT * FROM TblLogin;
--