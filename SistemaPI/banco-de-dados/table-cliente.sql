CREATE TABLE cliente (
    id INT AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) UNIQUE NOT NULL,
    telefone VARCHAR(11) UNIQUE NOT NULL,
    PRIMARY KEY (id)
);

INSERT INTO cliente (nome, email, telefone) VALUES 
("Anakin Skywalker Silva", "darth@gmail.com", "11555554444");

SELECT * FROM cliente;