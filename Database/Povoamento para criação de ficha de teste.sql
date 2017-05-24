--Inserindo exercicios

insert into tb_exercises(Name, Description) values('Elevação Lateral', 'Elevação lateral dos braços utilizando alteres');
insert into tb_exercises(Name, Description) values('Elevação Frontal', 'Elevação frontal dos braços utilizando alteres');
insert into tb_exercises(Name, Description) values('Rotação Externa de Ombro', 'Elevação externa de ombros deitado com alteres ou em máquina');
insert into tb_exercises(Name, Description) values('Banco extensor', 'Exercicio em máquina');
insert into tb_exercises(Name, Description) values('Banco adutor', 'Exercício em máquina');
insert into tb_exercises(Name, Description) values('Agachamento com TRX', 'Agachamento no TRX');

--Inserindo uma ficha
insert into tb_records(IdStudent, IdTrainer, DateBegin, DateExpiration) values(103, 101, getDate(), '2017-08-24');

--Inserindo os exercicios de uma ficha
insert into tb_record_exercises values(1, 1, 3, 12);
insert into tb_record_exercises values(1, 2, 3, 12);
insert into tb_record_exercises values(1, 3, 3, 15);
insert into tb_record_exercises values(1, 4, 4, 12);
insert into tb_record_exercises values(1, 5, 4, 12);
