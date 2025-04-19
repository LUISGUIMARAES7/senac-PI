CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    preco DECIMAL(6 , 2 ) NOT NULL,
    quantidade INT NOT NULL
);

INSERT INTO produto (nome, preco, quantidade)
VALUES 
	('ana connda',200.00,10 );
    
     select * from produto;