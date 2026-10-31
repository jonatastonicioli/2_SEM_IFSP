USE exerc_01;

INSERT INTO pessoa (nome,cidade,cpf,rg) VALUES
('Arthur Barbosa',   'Poço Branco',   '111.111.111-11', 2222),
('Anna Souza',       'Natal',         '999.999.999-99', 1234),
('Davi Leite',       'Tibau do Sul',  '222.222.222-22', 3333),
('Victor Hugo',      'Natal',         '777.777.777-77', 8888),
('Gabriela Souza',   'Nova Cruz',     '333.333.333-33', 4444),
('Miguel Leite',     'Apodi',         '000.000.000-00', 1111),
('Anna Souza',       'Nova Cruz',     '444.444.444-44', 5555),
('Miguel Castro',    'Natal',         '888.888.888-88', 9999),
('Nicolas Alves',    'Currais Novos', '555.555.555-55', 6666),
('Eduardo Henrique', 'Parnamirim',    '666.666.666-66', 7777),
-- pacientes
('Anna Gabriela',    'Touros',        '444.404.444-44', 1005),
('Davi Leite',       'Canguaretama',  '202.202.202-22', 1003),
('Eduardo Luiz',     'Parnamirim',    '666.606.666-66', 1007),
('João Paulo',       'Nova Cruz',     '303.333.333-33', 1004),
('Leonardo Alves',   'Nísia Floresta','010.010.010-11', 1001),
('Miguel Castro',    'Parelhas',      '888.888.808-88', 1009),
('Nicolas Alves',    'Currais Novos', '555.505.555-55', 1006),
('Otávio Breno',     'Natal',         '999.909.999-99', 1010),
('Thiago Lucas',     'Poço Branco',   '101.101.101-00', 1002),
('Victor Hugo',      'Natal',         '777.777.707-77', 1008);

INSERT INTO medico (pessoa_id, especialidade) VALUES
((SELECT id FROM pessoa WHERE rg = 2222), 'Anestesiologia'),
((SELECT id FROM pessoa WHERE rg = 1234), 'Cardiologia'),
((SELECT id FROM pessoa WHERE rg = 3333), 'Cardiologia'),
((SELECT id FROM pessoa WHERE rg = 8888), 'Cardiologia'),
((SELECT id FROM pessoa WHERE rg = 4444), 'Dermatologia'),
((SELECT id FROM pessoa WHERE rg = 1111), 'Infectologia'),
((SELECT id FROM pessoa WHERE rg = 5555), 'Mastologia'),
((SELECT id FROM pessoa WHERE rg = 9999), 'Neurologia'),
((SELECT id FROM pessoa WHERE rg = 6666), 'Neurologia'),
((SELECT id FROM pessoa WHERE rg = 7777), 'Oftalmologia');

INSERT INTO paciente (pessoa_id, doenca) VALUES
((SELECT id FROM pessoa WHERE rg = 1005), 'Pericardite'),
((SELECT id FROM pessoa WHERE rg = 1003), 'Arritmia'),
((SELECT id FROM pessoa WHERE rg = 1007), 'Conjuntivite'),
((SELECT id FROM pessoa WHERE rg = 1004), 'Doença de Chagas'),
((SELECT id FROM pessoa WHERE rg = 1001), 'Epilepsia'),
((SELECT id FROM pessoa WHERE rg = 1009), 'Catarata'),
((SELECT id FROM pessoa WHERE rg = 1006), 'Espasmo das Pálpebras'),
((SELECT id FROM pessoa WHERE rg = 1010), 'Acne'),
((SELECT id FROM pessoa WHERE rg = 1002), 'Doença de Huntington'),
((SELECT id FROM pessoa WHERE rg = 1008), 'Glaucoma');

INSERT INTO consulta (medico_id, paciente_id, data_hora) VALUES
((SELECT id FROM pessoa WHERE cpf = '777.777.777-77'), (SELECT id FROM pessoa WHERE cpf = '555.505.555-55'), '2013-02-12 14:00:00'),
((SELECT id FROM pessoa WHERE cpf = '777.777.777-77'), (SELECT id FROM pessoa WHERE cpf = '444.404.444-44'), '2013-02-12 14:30:00'),
((SELECT id FROM pessoa WHERE cpf = '777.777.777-77'), (SELECT id FROM pessoa WHERE cpf = '777.777.707-77'), '2013-02-13 13:00:00'),
((SELECT id FROM pessoa WHERE cpf = '555.555.555-55'), (SELECT id FROM pessoa WHERE cpf = '101.101.101-00'), '2013-02-16 19:00:00'),
((SELECT id FROM pessoa WHERE cpf = '555.555.555-55'), (SELECT id FROM pessoa WHERE cpf = '010.010.010-11'), '2013-02-16 20:00:00'),
((SELECT id FROM pessoa WHERE cpf = '777.777.777-77'), (SELECT id FROM pessoa WHERE cpf = '666.606.666-66'), '2013-02-20 16:30:00'),
((SELECT id FROM pessoa WHERE cpf = '777.777.777-77'), (SELECT id FROM pessoa WHERE cpf = '888.888.808-88'), '2013-02-21 08:00:00'),
((SELECT id FROM pessoa WHERE cpf = '333.333.333-33'), (SELECT id FROM pessoa WHERE cpf = '999.909.999-99'), '2013-02-22 09:00:00'),
((SELECT id FROM pessoa WHERE cpf = '222.222.222-22'), (SELECT id FROM pessoa WHERE cpf = '202.202.202-22'), '2013-02-24 20:00:00'),
((SELECT id FROM pessoa WHERE cpf = '222.222.222-22'), (SELECT id FROM pessoa WHERE cpf = '303.333.333-33'), '2013-02-25 20:00:00');

INSERT INTO conta (numero, agencia, saldo, pessoa_id) VALUES
(1119, 12300,  200.99, (SELECT id FROM pessoa WHERE cpf = '222.222.222-22')),
(2229, 99900, 1872.99, (SELECT id FROM pessoa WHERE cpf = '666.606.666-66')),
(3339, 88800, -150.99, (SELECT id FROM pessoa WHERE cpf = '555.555.555-55')),
(4449, 77700,   50.43, (SELECT id FROM pessoa WHERE cpf = '303.333.333-33')),
(5559, 66600, 2040,    (SELECT id FROM pessoa WHERE cpf = '888.888.888-88')),
(6669, 55500,  -10.89, (SELECT id FROM pessoa WHERE cpf = '010.010.010-11')),
(7779, 44400,  300.89, (SELECT id FROM pessoa WHERE cpf = '101.101.101-00')),
(8889, 33300,  200.39, (SELECT id FROM pessoa WHERE cpf = '777.777.777-77')),
(9999, 22200, 2900.29, (SELECT id FROM pessoa WHERE cpf = '444.404.444-44')),
(1239, 11100, 3987.99, (SELECT id FROM pessoa WHERE cpf = '333.333.333-33'));