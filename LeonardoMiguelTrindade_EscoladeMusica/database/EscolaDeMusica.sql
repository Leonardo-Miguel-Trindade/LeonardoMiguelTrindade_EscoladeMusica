
CREATE DATABASE IF NOT EXISTS escola_de_musica
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE escola_de_musica;


CREATE TABLE IF NOT EXISTS alunos (
    matricula INT NOT NULL,
    nome VARCHAR(50) NOT NULL,
    endereco VARCHAR(50) NOT NULL,
    cpf VARCHAR(14) NOT NULL,
    telefone VARCHAR(15) NOT NULL,
    instrumento VARCHAR(20) NOT NULL,
    PRIMARY KEY (matricula)
);


CREATE TABLE IF NOT EXISTS aulas (
    id INT NOT NULL AUTO_INCREMENT,
    instrumento VARCHAR(20) NOT NULL,
    dia ENUM('SEGUNDA', 'TERCA', 'QUARTA', 'QUINTA', 'SEXTA') NOT NULL,
    professor VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
);
