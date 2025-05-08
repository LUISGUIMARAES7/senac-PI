CREATE TABLE IF NOT EXISTS produto_pedido (
    id INT AUTO_INCREMENT,
    id_produto INT NOT NULL,
    id_pedido INT NOT NULL,
    quantidade INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (id_produto)
        REFERENCES produto (id),
    FOREIGN KEY (id_pedido)
        REFERENCES pedido (id)
);

DROP TABLE produto_pedido;

select * from produto_pedido;

create database senac_pi;


@"SELECT 
	pedido.id AS pedido_id,
	pedido.total AS pedido_total,
	pedido.data_pedido AS pedido_data,
	cliente.id As cliente_id,
	cliente.nome AS cliente_nome,
	produto.id AS produto_id,
	produto.nome AS produto_nome,
	produto.preco AS produto_preco,
	produto_pedido.id AS produtopedido_id,
	produto_pedido.id_produto AS produtopedido_produto_id,
	produto_pedido.id_pedido AS produtopedido_pedido_id
FROM
	pedido
JOIN cliente ON pedido.cliente_id = cliente.id
JOIN produto_pedido ON pedido.id = produto_pedido.id_pedido
JOIN produto ON produto_pedido.id_produto = produto.id;"

