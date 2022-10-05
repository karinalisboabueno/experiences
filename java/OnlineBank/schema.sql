create database if not exists online_bank;

use online_bank;

CREATE TABLE `cliente` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `endereco` text NOT NULL,
  `email` varchar(45) NOT NULL,
  `senha` varchar(8) NOT NULL,
  UNIQUE KEY `email` (`email`),
  PRIMARY KEY (`id_cliente`)
) ;

CREATE TABLE `conta` (
  `id_conta` int NOT NULL AUTO_INCREMENT,
  `numero_conta` varchar(12) DEFAULT NULL,
  `id_cliente` int NOT NULL,
  `tipo_conta` varchar(20) DEFAULT NULL,
  `saldo` decimal(10,0) DEFAULT '0',
  PRIMARY KEY (`id_conta`),
  UNIQUE KEY `numero_conta` (`numero_conta`),
  KEY `id_cliente` (`id_cliente`),
  CONSTRAINT `conta_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE CASCADE 
) ;

CREATE TABLE `movimento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_conta` int NOT NULL,
  `data_atual` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `montante` decimal(10,0) NOT NULL,
  `tipo` varchar(1) NOT NULL,
  `saldo` decimal(10,0) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_conta` (`id_conta`),
  CONSTRAINT `movimento_ibfk_1` FOREIGN KEY (`id_conta`) REFERENCES `conta` (`id_conta`) ON DELETE CASCADE 
) ;
