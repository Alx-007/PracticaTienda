CREATE DATABASE presentaciontienda;
USE presentaciontienda;

CREATE TABLE productos (
idP INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(255) NOT NULL,
descripcion VARCHAR(255),
precio DOUBLE NOT NULL
);

INSERT INTO productos VALUES
(NULL, 'Coca Cola', 'Bebida de Cola', 19.99),
(NULL, 'Pepsi', 'Bebida de Cola', 18.99);

SELECT * FROM productos;