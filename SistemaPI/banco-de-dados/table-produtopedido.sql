CREATE TABLE IF NOT EXISTS produto_pedido(
	id INT AUTO_INCREMENT,
	id_produto INT NOT NULL,
    id_pedido INT NOT NULL,
    
    PRIMARY KEY (id),
    FOREIGN KEY (id_produto) REFERENCES produto(id),
    FOREIGN KEY (id_pedido) REFERENCES pedido(id)
);

DROP TABLE produto_pedido;