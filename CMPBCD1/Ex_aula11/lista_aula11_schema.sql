DROP SCHEMA IF EXISTS exerc_01;
CREATE SCHEMA exerc_01;

USE exerc_01;

CREATE TABLE pessoa (
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100),
cidade VARCHAR(100),
cpf CHAR(14),
rg INT(11)
);

CREATE TABLE medico(
pessoa_id INT PRIMARY KEY NOT NULL,
especialidade VARCHAR(50),
FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
	ON UPDATE CASCADE
    ON DELETE RESTRICT
);

CREATE TABLE conta(
id INT PRIMARY KEY AUTO_INCREMENT,
numero INT(11),
agencia INT(11),
saldo FLOAT,
pessoa_id INT NOT NULL,
FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
	ON UPDATE CASCADE
    ON DELETE RESTRICT
);

CREATE TABLE paciente(
pessoa_id INT PRIMARY KEY NOT NULL,
doenca VARCHAR(50),
FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
	ON DELETE RESTRICT 
    ON UPDATE CASCADE
);

CREATE TABLE consulta(
medico_id INT NOT NULL,
paciente_id INT NOT NULL,
data_hora DATETIME,
PRIMARY KEY (medico_id, paciente_id, data_hora),

FOREIGN KEY (medico_id) REFERENCES medico(pessoa_id)
	ON DELETE RESTRICT 
    ON UPDATE CASCADE,
    
FOREIGN KEY (paciente_id) REFERENCES paciente(pessoa_id)
	ON DELETE RESTRICT 
    ON UPDATE CASCADE
);

CREATE UNIQUE INDEX cpf ON pessoa (cpf);
CREATE UNIQUE INDEX rg ON pessoa(rg);

CREATE UNIQUE INDEX idx_numero_agencia ON conta (numero,agencia);
CREATE UNIQUE INDEX idx_medico_data_hora ON consulta (medico_id,data_hora);
CREATE UNIQUE INDEX idx_paciente_data_hora ON consulta(paciente_id,data_hora);

CREATE INDEX idx_nome ON pessoa (nome)




