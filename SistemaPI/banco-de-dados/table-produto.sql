CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    preco DECIMAL(6 , 2 ) NOT NULL,
    fornecedor_id INT NOT NULL,
    FOREIGN KEY (fornecedor_id) REFERENCES fornecedor(id)
);

SELECT * FROM produto;

drop table produto;

DESC produto;

@"SELECT 
    pedido.id,
    cliente.nome AS cliente,
    produto.nome AS produto,
    data_pedido,
    total
FROM
    pedido
        JOIN
    cliente ON pedido.cliente_id = cliente.id
        JOIN
    produto_pedido ON produto_pedido.produto_id = pedido.id
WHERE
    id = @param;"