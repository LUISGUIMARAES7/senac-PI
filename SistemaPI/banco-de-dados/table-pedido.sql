CREATE TABLE IF NOT EXISTS pedido (
    id INT AUTO_INCREMENT,
    data_pedido DATETIME DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(6,2) NOT NULL,
    cliente_id INT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

    DROP TABLE pedido;
    SELECT * FROM pedido;
    
    select pedido.id, cliente.nome as cliente, produto.nome as produto,data_pedido, total
    from pedido
    join cliente on pedido.cliente_id = cliente.id
    join produto on pedido.produto_id = produto.id;
    
INSERT INTO pedido (produto_id, quantidade, cliente_id, total)
VALUES (@quantidade, @cliente_id, @total);

SELECT 
    pedido.id,
    cliente.nome AS cliente,
    total
FROM
	pedido
        JOIN
    cliente ON pedido.cliente_id = cliente.id
        JOIN
	produto_pedido ON pedido.id = produto_pedido.id_pedido; 
    
select * from pedido;