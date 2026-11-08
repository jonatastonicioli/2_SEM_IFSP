USE bloco1;

SELECT medico.nome, medico.idade FROM medico WHERE medico.idade>30 ORDER BY medico.idade DESC;

SELECT DISTINCT medico.especialidade FROM medico;

SELECT medico.nome FROM medico WHERE  medico.nome LIKE 'A%a';

SELECT medico.nome FROM medico WHERE ambulatorio_id IS NULL;

SELECT medico.nome FROM medico WHERE data_contrato BETWEEN '2012-05-01' AND '2012-09-30';

SELECT medico.nome FROM medico WHERE medico.especialidade IN ('Cardiologia','Neurologia','Mastologia');

SELECT medico.salario*1.15 'Salário Reajustado' FROM medico;

SELECT medico.nome FROM medico ORDER BY medico.salario DESC LIMIT 1;

SELECT medico.especialidade, AVG(medico.salario) FROM medico GROUP BY medico.especialidade HAVING COUNT(medico.especialidade)> 1;

SELECT medico.nome, medico.especialidade, ambulatorio.andar FROM medico INNER JOIN ambulatorio ON ambulatorio.id = medico.ambulatorio_id ORDER BY ambulatorio.andar, medico.nome;

SELECT medico.nome, ambulatorio.numero FROM medico LEFT JOIN ambulatorio ON medico.ambulatorio_id = ambulatorio.id;

SELECT ambulatorio.numero, COUNT(medico.ambulatorio_id) FROM medico RIGHT JOIN ambulatorio ON ambulatorio.id = medico.ambulatorio_id GROUP BY ambulatorio.numero;

SELECT medico.nome, medico.especialidade, ambulatorio.andar FROM medico, ambulatorio WHERE medico.ambulatorio_id = ambulatorio.id ORDER BY ambulatorio.andar, medico.nome;

SELECT medico.nome FROM medico WHERE medico.ambulatorio_id IN (SELECT id FROM ambulatorio WHERE ambulatorio.andar = '2');

SELECT medico.nome FROM medico WHERE medico.salario > ALL (SELECT medico.salario FROM medico WHERE medico.especialidade = 'Ortopedia');

SELECT medico.nome FROM medico WHERE medico.salario > ANY (SELECT medico.salario FROM medico WHERE medico.especialidade = 'Neurologia');

SELECT medico.nome FROM medico WHERE medico.salario > (SELECT AVG(medico.salario) FROM medico);

UPDATE medico SET medico.salario = medico.salario *1.10 WHERE medico.ambulatorio_id = (SELECT id FROM ambulatorio WHERE ambulatorio.numero = '101');

INSERT INTO medico (nome, rg, idade, salario, especialidade, data_contrato, ambulatorio_id) VALUES 
('Rita', 7777, 30, 5000, 'Pediatria', '2013-03-01',(SELECT id FROM ambulatorio WHERE ambulatorio.numero = '302'));

DELETE FROM medico WHERE medico.ambulatorio_id IN (SELECT id FROM ambulatorio WHERE ambulatorio.andar = '3');