CREATE TABLE IF NOT EXISTS fornecedor (
    id INT AUTO_INCREMENT,
    nome VARCHAR(20) UNIQUE NOT NULL,
    PRIMARY KEY (id)
);

INSERT INTO fornecedor (nome) VALUES ('Natura');
INSERT INTO fornecedor (nome) VALUES ('Avon');
INSERT INTO fornecedor (nome) VALUES ('O Boticário');
INSERT INTO fornecedor (nome) VALUES ('Eudora');

select * from fornecedor;

