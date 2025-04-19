CREATE TABLE cliente (
    id INT AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) UNIQUE NOT NULL,
    telefone INT UNIQUE NOT NULL,
    PRIMARY KEY (id)
);

INSERT INTO cliente (nome,email,telefone) 
VALUES 
	('João Silva','Sulva@email.com',355151515 );
    
    select * from cliente;