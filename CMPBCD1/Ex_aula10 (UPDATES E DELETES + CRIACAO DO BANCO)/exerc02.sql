USE exerc01;

#inicio exercicio 2

#SHOW VARIABLES LIKE 'sql_safe_updates';
SET SQL_SAFE_UPDATES = 0; #desativando a trava que protege alguns updates


UPDATE pessoa SET nome = 'Pedro Bial' WHERE cpf = '444.444.444-44';

UPDATE pessoa SET nome = 'Silvio Santos', cidade = 'Apodi' WHERE rg = 1001;

UPDATE conta SET saldo = 0.0 WHERE numero = 9999 AND agencia = 22200;

UPDATE consulta SET medico_id = (SELECT id FROM pessoa WHERE cpf ='888.888.888-88') WHERE paciente_id = (SELECT id FROM pessoa WHERE cpf = '010.010.010-11');

UPDATE conta SET saldo = saldo + 200 WHERE saldo<0;

INSERT INTO consulta(medico_id, paciente_id, data_hora) VALUES
((SELECT id FROM pessoa WHERE rg = 1234), (SELECT id FROM pessoa WHERE rg = 1004), '2013-02-28 07:00:00');

UPDATE conta SET saldo =  saldo/2 WHERE saldo >=1000;

#deletando de baixo para cima pois o delete é restrict e não permite apagar tabelas com foreigns keys
DELETE FROM consulta WHERE paciente_id = (SELECT id FROM pessoa WHERE rg=1008);
DELETE FROM paciente WHERE pessoa_id = (SELECT id FROM pessoa WHERE rg=1008);
DELETE FROM pessoa WHERE rg = 1008;

#data aceita operadores
DELETE FROM consulta WHERE data_hora >= '2013-02-16' AND data_hora < '2013-02-22';
# ou DELETE FROM consulta WHERE data_hora BETWEEN '2013-02-16 00:00:00' AND '2013-02-21 23:59:59';

DELETE FROM consulta WHERE paciente_id = (SELECT id FROM pessoa WHERE cpf = '303.333.333-33');