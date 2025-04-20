CREATE TABLE IF NOT EXISTS pedido (
    id INT AUTO_INCREMENT,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    data_pedido DATETIME DEFAULT CURRENT_TIMESTAMP,
    cliente_id INT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (produto_id)
        REFERENCES produto (id),
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

    
    select * from pedido;