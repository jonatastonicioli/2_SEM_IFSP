USE exerc_01;

SET SQL_SAFE_UPDATES = 0;

-- a)
UPDATE pessoa SET nome = 'Pedro Bial' WHERE cpf = '444.444.444-44';
-- b)
UPDATE pessoa SET nome = 'Silvio Santos', cidade = 'Apodi' WHERE rg = '1001';
-- c)
UPDATE conta SET saldo = 0.0 WHERE numero = 9999 AND agencia = 22200;
-- d)
UPDATE consulta SET medico_id = (SELECT id FROM pessoa WHERE cpf = '888.888.888-88') WHERE paciente_id = (SELECT id FROM pessoa WHERE cpf = '010.010.010-11');
-- e)
UPDATE conta SET saldo = saldo + 200 WHERE saldo<0;
-- f)
INSERT INTO consulta (medico_id, paciente_id, data_hora) VALUES
((SELECT id FROM pessoa WHERE rg = 1234), (SELECT id FROM pessoa WHERE rg=1004), '2013-02-28 07:00:00');
-- g)
UPDATE conta SET saldo =  saldo/2 WHERE saldo>=1000;
-- h)
DELETE FROM consulta WHERE paciente_id = (SELECT id FROM pessoa WHERE rg=1008);
DELETE FROM paciente WHERE pessoa_id = (SELECT id FROM pessoa WHERE rg=1008);
DELETE FROM pessoa WHERE rg = 1008;
-- i)
DELETE FROM consulta WHERE data_hora BETWEEN '2013-02-16' AND '2013-02-22';
-- j)
DELETE FROM consulta WHERE paciente_id = (SELECT id FROM pessoa WHERE cpf = '303.333.333-33');