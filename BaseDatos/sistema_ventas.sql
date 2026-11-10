-- =========================================================
-- Base de datos: sistema_ventas
-- ProyectoP5 - Script unificado para MySQL 8.0+
-- IMPORTANTE: este script elimina y vuelve a crear las tablas.
-- Ejecutarlo únicamente en una base de datos de pruebas.
-- =========================================================

CREATE DATABASE IF NOT EXISTS sistema_ventas
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE sistema_ventas;

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

DROP TABLE IF EXISTS detalle_venta;
DROP TABLE IF EXISTS ventas;
DROP TABLE IF EXISTS producto_accesorio;
DROP TABLE IF EXISTS producto_cable;
DROP TABLE IF EXISTS producto_audio;
DROP TABLE IF EXISTS productos;
DROP TABLE IF EXISTS clientes;

SET FOREIGN_KEY_CHECKS = 1;

-- ---------------------------------------------------------
-- Tabla: clientes
-- ---------------------------------------------------------
CREATE TABLE clientes (
  id INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(120) NOT NULL,
  telefono VARCHAR(25) DEFAULT NULL,
  correo VARCHAR(150) DEFAULT NULL,
  activo TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ---------------------------------------------------------
-- Tabla: productos (clase padre)
-- ---------------------------------------------------------
CREATE TABLE productos (
  id INT NOT NULL AUTO_INCREMENT,
  codigo VARCHAR(30) NOT NULL,
  nombre VARCHAR(120) NOT NULL,
  descripcion VARCHAR(255) DEFAULT NULL,
  precio DECIMAL(12,2) NOT NULL,
  categoria VARCHAR(50) NOT NULL,
  marca VARCHAR(100) DEFAULT NULL,
  stock INT NOT NULL DEFAULT 0,
  activo TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (id),
  UNIQUE KEY codigo (codigo),
  CONSTRAINT chk_producto_precio CHECK (precio >= 0),
  CONSTRAINT chk_producto_stock CHECK (stock >= 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ---------------------------------------------------------
-- Tablas hijas de productos
-- ---------------------------------------------------------
CREATE TABLE producto_audio (
  producto_id INT NOT NULL,
  tiene_microfono TINYINT(1) NOT NULL,
  tipo_conexion VARCHAR(50) NOT NULL,
  PRIMARY KEY (producto_id),
  CONSTRAINT fk_audio_producto
    FOREIGN KEY (producto_id) REFERENCES productos (id)
    ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE producto_cable (
  producto_id INT NOT NULL,
  metros DECIMAL(6,2) NOT NULL,
  conectores VARCHAR(100) NOT NULL,
  PRIMARY KEY (producto_id),
  CONSTRAINT fk_cable_producto
    FOREIGN KEY (producto_id) REFERENCES productos (id)
    ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE producto_accesorio (
  producto_id INT NOT NULL,
  tipo_alimentacion VARCHAR(50) NOT NULL,
  compatibilidad VARCHAR(150) NOT NULL,
  PRIMARY KEY (producto_id),
  CONSTRAINT fk_accesorio_producto
    FOREIGN KEY (producto_id) REFERENCES productos (id)
    ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ---------------------------------------------------------
-- Tablas de ventas
-- ---------------------------------------------------------
CREATE TABLE ventas (
  id INT NOT NULL AUTO_INCREMENT,
  fecha DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  cliente_id INT NOT NULL,
  total DECIMAL(12,2) NOT NULL DEFAULT 0.00,
  PRIMARY KEY (id),
  KEY idx_ventas_fecha (fecha),
  KEY idx_ventas_cliente (cliente_id),
  CONSTRAINT fk_venta_cliente
    FOREIGN KEY (cliente_id) REFERENCES clientes (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE detalle_venta (
  id INT NOT NULL AUTO_INCREMENT,
  venta_id INT NOT NULL,
  producto_id INT NOT NULL,
  cantidad INT NOT NULL,
  precio_unitario DECIMAL(12,2) NOT NULL,
  subtotal DECIMAL(12,2) NOT NULL,
  PRIMARY KEY (id),
  KEY fk_detalle_producto (producto_id),
  KEY idx_detalle_venta (venta_id),
  CONSTRAINT fk_detalle_producto
    FOREIGN KEY (producto_id) REFERENCES productos (id),
  CONSTRAINT fk_detalle_venta
    FOREIGN KEY (venta_id) REFERENCES ventas (id),
  CONSTRAINT chk_detalle_cantidad CHECK (cantidad > 0),
  CONSTRAINT chk_detalle_precio CHECK (precio_unitario >= 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ---------------------------------------------------------
-- Datos de prueba: clientes
-- Se usan datos ficticios para no distribuir datos personales.
-- ---------------------------------------------------------
INSERT INTO clientes (id, nombre, telefono, correo, activo) VALUES
(1, 'Ana Rodriguez', '8888-1111', 'ana@example.com', 1),
(2, 'Carlos Mendez', '8888-2222', 'carlos@example.com', 1),
(3, 'Maria Vargas', '8888-3333', 'maria@example.com', 1),
(4, 'Cliente de prueba', '8000-0000', 'cliente@example.com', 1);

-- ---------------------------------------------------------
-- Datos de prueba: productos
-- Se conservan los registros exportados, incluidos los inactivos.
-- ---------------------------------------------------------
INSERT INTO productos
(id, codigo, nombre, descripcion, precio, categoria, marca, stock, activo)
VALUES
(1, 'P001', 'Mouse inalambrico', 'Mouse USB inalambrico', 7500.00, 'Accesorio', 'Dell', 20, 1),
(2, 'P002', 'Teclado USB', 'Teclado estandar', 8500.00, 'Accesorio', NULL, 15, 1),
(3, 'P003', 'Audifonos', 'Audifonos con microfono', 12000.00, 'Audio', NULL, 10, 1),
(4, 'P004', 'Cable USB', 'Cable de datos', 2500.00, 'Cable', NULL, 30, 1),
(5, 'P005', 'Cable USB-C', 'Cable de datos USB', 3500.00, 'Cable', 'Generica', 20, 1),
(6, 'P006', 'Mouse Gamer', 'Mouse gamer inalambrico', 12000.00, 'Accesorio', 'Logitech', 10, 0),
(7, 'P007', 'Audifonos Gamer', 'Audifonos con microfono', 15000.00, 'Audio', 'Logitech', 12, 1),
(10, 'P008', 'Cable USB-C', NULL, 0.00, 'Cable', NULL, 20, 1),
(11, 'P009', 'asd', NULL, 0.00, 'Cable', 'a', 0, 0);

-- ---------------------------------------------------------
-- Datos de las tablas hijas
-- ---------------------------------------------------------
INSERT INTO producto_accesorio
(producto_id, tipo_alimentacion, compatibilidad)
VALUES
(1, 'Bateria', 'Por definir'),
(2, 'USB', 'Por definir'),
(6, 'Bateria', 'Windows');

INSERT INTO producto_audio
(producto_id, tiene_microfono, tipo_conexion)
VALUES
(3, 1, 'Jack 3.5 mm'),
(7, 1, 'Jack 3.5 mm');

INSERT INTO producto_cable
(producto_id, metros, conectores)
VALUES
(4, 1.50, 'USB-A a USB-C'),
(5, 1.50, 'USB-A a USB-C'),
(10, 1.50, 'USB-A a USB-C'),
(11, 0.00, 'a');

-- Reiniciar los siguientes IDs para continuar después de los datos importados.
ALTER TABLE clientes AUTO_INCREMENT = 5;
ALTER TABLE productos AUTO_INCREMENT = 12;

-- ventas y detalle_venta quedan vacías, igual que en el respaldo recibido.
