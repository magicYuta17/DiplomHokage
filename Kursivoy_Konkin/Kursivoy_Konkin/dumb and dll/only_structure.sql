CREATE DATABASE  IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mydb`;
-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	9.4.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients` (
  `ID_Client` int unsigned NOT NULL AUTO_INCREMENT,
  `FullName_client` varchar(70) NOT NULL,
  `phone` varchar(45) NOT NULL,
  `Age` int NOT NULL,
  `Status_client_ID_Status_client` int NOT NULL,
  `LTV` decimal(12,0) DEFAULT NULL,
  `Birthday` datetime DEFAULT NULL,
  `IsDeleted` int DEFAULT '0',
  PRIMARY KEY (`ID_Client`),
  KEY `fk_Clients_Status_client1_idx` (`Status_client_ID_Status_client`),
  CONSTRAINT `fk_Clients_Status_client1` FOREIGN KEY (`Status_client_ID_Status_client`) REFERENCES `status_client` (`ID_Status_client`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `contract`
--

DROP TABLE IF EXISTS `contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contract` (
  `ID_Contract` int unsigned NOT NULL AUTO_INCREMENT,
  `Name_contract` varchar(45) NOT NULL,
  `date_signing` date NOT NULL,
  `END_DATE` date NOT NULL,
  `Clients_ID_Client` int NOT NULL,
  `worker_ID_worker` int NOT NULL,
  `object_ID_object` int NOT NULL COMMENT 'Связь 1:1 с таблицей object',
  `status_contract_id` int DEFAULT NULL,
  PRIMARY KEY (`ID_Contract`),
  KEY `fk_Contract_Clients1_idx` (`Clients_ID_Client`),
  KEY `fk_Contract_worker1_idx` (`worker_ID_worker`),
  KEY `fk_Contract_object1_idx` (`object_ID_object`),
  CONSTRAINT `fk_Contract_object1` FOREIGN KEY (`object_ID_object`) REFERENCES `object` (`ID_object`),
  CONSTRAINT `fk_Contract_worker1` FOREIGN KEY (`worker_ID_worker`) REFERENCES `worker` (`ID_worker`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `object`
--

DROP TABLE IF EXISTS `object`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `object` (
  `ID_object` int NOT NULL AUTO_INCREMENT,
  `name_object` varchar(100) NOT NULL DEFAULT '',
  `square` decimal(50,0) NOT NULL,
  `cost` decimal(50,0) NOT NULL,
  `building_dates_plan` int NOT NULL,
  `number_floors` int NOT NULL,
  `parking_space` decimal(50,0) NOT NULL,
  `photo` varchar(50) DEFAULT NULL,
  `IsDeleted` int DEFAULT '0',
  `building_dates_fact` int NOT NULL DEFAULT '0',
  `prepay` decimal(10,0) GENERATED ALWAYS AS ((`cost` * (`procent_prepay` / 100))) STORED,
  `procent_prepay` int NOT NULL,
  PRIMARY KEY (`ID_object`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `role_worker`
--

DROP TABLE IF EXISTS `role_worker`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role_worker` (
  `ID_Role` int NOT NULL AUTO_INCREMENT,
  `Role` varchar(45) NOT NULL,
  PRIMARY KEY (`ID_Role`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `status_client`
--

DROP TABLE IF EXISTS `status_client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `status_client` (
  `ID_Status_client` int NOT NULL AUTO_INCREMENT,
  `status` varchar(45) DEFAULT NULL,
  `IsDeleted` int DEFAULT '0',
  PRIMARY KEY (`ID_Status_client`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `status_contract`
--

DROP TABLE IF EXISTS `status_contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `status_contract` (
  `status_contract_id` int NOT NULL AUTO_INCREMENT,
  `status_contract_name` varchar(45) NOT NULL,
  PRIMARY KEY (`status_contract_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `worker`
--

DROP TABLE IF EXISTS `worker`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `worker` (
  `ID_worker` int NOT NULL AUTO_INCREMENT,
  `ID_Clientsl` varchar(45) NOT NULL,
  `FIO` varchar(100) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  `phone` varchar(45) NOT NULL,
  `Role_worker_ID_Role` int NOT NULL,
  `IsDeleted` int DEFAULT '0',
  `photo` varchar(45) DEFAULT NULL,
  `password` char(8) NOT NULL DEFAULT '12345678' COMMENT 'Пароль пользователя (8 символов)',
  PRIMARY KEY (`ID_worker`),
  UNIQUE KEY `ID_worker_UNIQUE` (`ID_worker`),
  KEY `fk_worker_Role_worker1_idx` (`Role_worker_ID_Role`),
  CONSTRAINT `fk_worker_Role_worker1` FOREIGN KEY (`Role_worker_ID_Role`) REFERENCES `role_worker` (`ID_Role`)
) ENGINE=InnoDB AUTO_INCREMENT=334 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping events for database 'mydb'
--

--
-- Dumping routines for database 'mydb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-13  8:44:07
