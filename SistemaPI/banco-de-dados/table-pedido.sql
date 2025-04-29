CREATE TABLE IF NOT EXISTS pedido (
    id INT AUTO_INCREMENT,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    data_pedido DATETIME DEFAULT CURRENT_TIMESTAMP,
    total decimal(6,2) NOT NULL,
    cliente_id INT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (produto_id)
        REFERENCES produto (id),
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

    DROP TABLE pedido;
    select * from pedido;
    
    select pedido.id, cliente.nome as cliente, produto.nome as produto,data_pedido, total
    from pedido
    join cliente on pedido.cliente_id = cliente.id
    join produto on pedido.produto_id = produto.id;
    
INSERT INTO pedido (produto_id, quantidade, cliente_id, total)
VALUES (@quantidade, @cliente_id, @total);