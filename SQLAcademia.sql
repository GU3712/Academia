CREATE DATABASE AcademiaDB;
GO

USE AcademiaDB;
GO


CREATE TABLE Aluno (
    id_aluno INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(14) NOT NULL UNIQUE,
    data_nascimento DATE NOT NULL,
    telefone VARCHAR(20)
);


CREATE TABLE Plano (
    id_plano INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    valor DECIMAL(10,2) NOT NULL
);


CREATE TABLE Matricula (
    id_matricula INT IDENTITY(1,1) PRIMARY KEY,
    id_aluno INT NOT NULL,
    id_plano INT NOT NULL,
    data_inicio DATE NOT NULL,
    data_fim DATE NOT NULL,
    status VARCHAR(20) NOT NULL,
    FOREIGN KEY (id_aluno) REFERENCES Aluno(id_aluno),
    FOREIGN KEY (id_plano) REFERENCES Plano(id_plano)
);


CREATE TABLE Instrutor (
    id_instrutor INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cref VARCHAR(20) NOT NULL
);


CREATE TABLE Ficha_Treino (
    id_treino INT IDENTITY(1,1) PRIMARY KEY,
    id_aluno INT NOT NULL,
    id_instrutor INT NOT NULL,
    data_criacao DATE NOT NULL,
    objetivo VARCHAR(100),
    FOREIGN KEY (id_aluno) REFERENCES Aluno(id_aluno),
    FOREIGN KEY (id_instrutor) REFERENCES Instrutor(id_instrutor)
);


CREATE TABLE Exercicio (
    id_exercicio INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    grupo_muscular VARCHAR(50) NOT NULL
);


CREATE TABLE Ficha_Exercicio (
    id_treino INT NOT NULL,
    id_exercicio INT NOT NULL,
    series INT NOT NULL,
    repeticoes INT NOT NULL,
    carga_kg DECIMAL(5,2),
    PRIMARY KEY (id_treino, id_exercicio),
    FOREIGN KEY (id_treino) REFERENCES Ficha_Treino(id_treino) ON DELETE CASCADE,
    FOREIGN KEY (id_exercicio) REFERENCES Exercicio(id_exercicio)
);