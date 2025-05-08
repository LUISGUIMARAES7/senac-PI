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

SELECT 
    pedido.id AS pedido_id,
    pedido.total AS pedido_total,
    pedido.data_pedido AS pedido_data,
    cliente.id AS cliente_id,
    cliente.nome AS cliente_nome,
    produto.id AS produto_id,
    produto.nome AS produto_nome,
    produto.preco AS produto_preco,
    produto_pedido.id AS produtopedido_id,
    produto_pedido.id_produto AS produtopedido_produto_id,
    produto_pedido.id_pedido AS produtopedido_pedido_id,
    produto_pedido.quantidade AS produtopedido_quantidade,  -- Verifique se está retornando a quantidade
    produto_pedido.total AS produtopedido_total
FROM
    pedido
JOIN cliente ON pedido.cliente_id = cliente.id
JOIN produto_pedido ON pedido.id = produto_pedido.id_pedido
JOIN produto ON produto_pedido.id_produto = produto.id
WHERE pedido.id = 2;

