-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 25-11-2026 a las 17:13:10
-- Versión del servidor: 8.4.3
-- Versión de PHP: 8.3.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sistema_ventas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id` int NOT NULL,
  `nombre` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telefono` varchar(25) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `correo` varchar(150) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `activo` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id`, `nombre`, `telefono`, `correo`, `activo`) VALUES
(1, 'Ana Rodriguez', '8888-1111', 'ana@example.com', 1),
(2, 'Carlos Mendez', '8888-2222', 'carlos@example.com', 1),
(3, 'Maria Vargas', '8888-3333', 'maria@example.com', 1),
(4, 'Cliente de prueba', '8000-0000', 'cliente@example.com', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_venta`
--

CREATE TABLE `detalle_venta` (
  `id` int NOT NULL,
  `venta_id` int NOT NULL,
  `producto_id` int NOT NULL,
  `cantidad` int NOT NULL,
  `precio_unitario` decimal(12,2) NOT NULL,
  `subtotal` decimal(12,2) NOT NULL
) ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int NOT NULL,
  `codigo` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nombre` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `descripcion` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `precio` decimal(12,2) NOT NULL,
  `categoria` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `marca` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `stock` int NOT NULL DEFAULT '0',
  `activo` tinyint(1) NOT NULL DEFAULT '1'
) ;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `codigo`, `nombre`, `descripcion`, `precio`, `categoria`, `marca`, `stock`, `activo`) VALUES
(1, 'P001', 'Mouse inalambrico', 'Mouse USB inalambrico', 7500.00, 'Accesorio', 'Dell', 20, 1),
(2, 'P002', 'Teclado USB', 'Teclado estandar', 8500.00, 'Accesorio', NULL, 15, 1),
(3, 'P003', 'Audifonos', 'Audifonos con microfono', 12000.00, 'Audio', NULL, 10, 1),
(4, 'P004', 'Cable USB', 'Cable de datos', 2500.00, 'Cable', NULL, 30, 1),
(5, 'P005', 'Cable USB-C', 'Cable de datos USB', 3500.00, 'Cable', 'Generica', 20, 1),
(6, 'P006', 'Mouse Gamer', 'Mouse gamer inalambrico', 12000.00, 'Accesorio', 'Logitech', 10, 0),
(7, 'P007', 'Audifonos Gamer', 'Audifonos con microfono', 15000.00, 'Audio', 'Logitech', 12, 1),
(10, 'P008', 'Cable USB-C', NULL, 0.00, 'Cable', NULL, 20, 1),
(11, 'P009', 'asd', NULL, 0.00, 'Cable', 'a', 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_accesorio`
--

CREATE TABLE `producto_accesorio` (
  `producto_id` int NOT NULL,
  `tipo_alimentacion` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `compatibilidad` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `producto_accesorio`
--

INSERT INTO `producto_accesorio` (`producto_id`, `tipo_alimentacion`, `compatibilidad`) VALUES
(1, 'Bateria', 'Por definir'),
(2, 'USB', 'Por definir'),
(6, 'Bateria', 'Windows');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_audio`
--

CREATE TABLE `producto_audio` (
  `producto_id` int NOT NULL,
  `tiene_microfono` tinyint(1) NOT NULL,
  `tipo_conexion` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `producto_audio`
--

INSERT INTO `producto_audio` (`producto_id`, `tiene_microfono`, `tipo_conexion`) VALUES
(3, 1, 'Jack 3.5 mm'),
(7, 1, 'Jack 3.5 mm');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_cable`
--

CREATE TABLE `producto_cable` (
  `producto_id` int NOT NULL,
  `metros` decimal(6,2) NOT NULL,
  `conectores` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `producto_cable`
--

INSERT INTO `producto_cable` (`producto_id`, `metros`, `conectores`) VALUES
(4, 1.50, 'USB-A a USB-C'),
(5, 1.50, 'USB-A a USB-C'),
(10, 1.50, 'USB-A a USB-C'),
(11, 0.00, 'a');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int NOT NULL,
  `nombre` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `telefono` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `correo` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `activo` tinyint(1) NOT NULL DEFAULT '1',
  `rol` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `telefono`, `correo`, `activo`, `rol`) VALUES
(1, 'Ana Rodríguez', '8888-1111', 'ana@example.com', 0, ''),
(2, 'Carlos Méndez', '8888-2222', 'carlos@example.com', 1, ''),
(3, 'María Vargas', '8888-3333', 'maria@example.com', 0, ''),
(4, 'PEDRO2', '1221', 'RERNU', 1, ''),
(5, 'ANDERSON', '8888', 'NAUDGUE@.COM', 1, ''),
(6, 'pedro', '11111', 'sashdi@', 1, ''),
(7, 'pedro', 'a', 'a', 1, '1-ADMINISTRADOR'),
(8, 'newuirh', 'hbfeuhfi', 'njedghbfouiwerg', 1, '3-BODEGUERO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `id` int NOT NULL,
  `fecha` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `cliente_id` int NOT NULL,
  `total` decimal(12,2) NOT NULL DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_detalle_producto` (`producto_id`),
  ADD KEY `idx_detalle_venta` (`venta_id`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `codigo` (`codigo`);

--
-- Indices de la tabla `producto_accesorio`
--
ALTER TABLE `producto_accesorio`
  ADD PRIMARY KEY (`producto_id`);

--
-- Indices de la tabla `producto_audio`
--
ALTER TABLE `producto_audio`
  ADD PRIMARY KEY (`producto_id`);

--
-- Indices de la tabla `producto_cable`
--
ALTER TABLE `producto_cable`
  ADD PRIMARY KEY (`producto_id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idx_ventas_fecha` (`fecha`),
  ADD KEY `idx_ventas_cliente` (`cliente_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `detalle_venta`
--
ALTER TABLE `detalle_venta`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD CONSTRAINT `fk_detalle_producto` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`id`),
  ADD CONSTRAINT `fk_detalle_venta` FOREIGN KEY (`venta_id`) REFERENCES `ventas` (`id`);

--
-- Filtros para la tabla `producto_accesorio`
--
ALTER TABLE `producto_accesorio`
  ADD CONSTRAINT `fk_accesorio_producto` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `producto_audio`
--
ALTER TABLE `producto_audio`
  ADD CONSTRAINT `fk_audio_producto` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `producto_cable`
--
ALTER TABLE `producto_cable`
  ADD CONSTRAINT `fk_cable_producto` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `fk_venta_cliente` FOREIGN KEY (`cliente_id`) REFERENCES `clientes` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
