-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: comisaria
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `afirma`
--

DROP TABLE IF EXISTS `afirma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `afirma` (
  `Nro_Denuncia` int(11) NOT NULL,
  `DNI` char(10) NOT NULL,
  PRIMARY KEY (`Nro_Denuncia`,`DNI`),
  KEY `RefTestigo29` (`DNI`),
  CONSTRAINT `RefDenuncia28` FOREIGN KEY (`Nro_Denuncia`) REFERENCES `denuncia` (`Nro_Denuncia`),
  CONSTRAINT `RefTestigo29` FOREIGN KEY (`DNI`) REFERENCES `testigo` (`DNI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `afirma`
--

LOCK TABLES `afirma` WRITE;
/*!40000 ALTER TABLE `afirma` DISABLE KEYS */;
/*!40000 ALTER TABLE `afirma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comisaria`
--

DROP TABLE IF EXISTS `comisaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `comisaria` (
  `codigo` char(10) NOT NULL,
  `localidad` char(10) DEFAULT NULL,
  `domicilio` char(10) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comisaria`
--

LOCK TABLES `comisaria` WRITE;
/*!40000 ALTER TABLE `comisaria` DISABLE KEYS */;
INSERT INTO `comisaria` VALUES ('C001','Capital','Salta 521');
/*!40000 ALTER TABLE `comisaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `denuncia`
--

DROP TABLE IF EXISTS `denuncia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `denuncia` (
  `Nro_Denuncia` int(11) NOT NULL AUTO_INCREMENT,
  `hora` datetime DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `nro_expF` char(10) DEFAULT NULL,
  `lugar` char(10) DEFAULT NULL,
  `descripcion` char(10) DEFAULT NULL,
  `forma` char(10) DEFAULT NULL,
  `DNI_denunciante` char(10) NOT NULL,
  `DNI_oficial` char(10) NOT NULL,
  `ID_delito` char(10) NOT NULL,
  `ID_fis` char(10) NOT NULL,
  `ID_dep` char(10) NOT NULL,
  `DNI` char(10) NOT NULL,
  PRIMARY KEY (`Nro_Denuncia`),
  KEY `RefDenunciante21` (`DNI_denunciante`),
  KEY `RefOficial22` (`DNI_oficial`),
  KEY `RefTipo_Delito23` (`ID_delito`),
  KEY `RefFiscalia24` (`ID_fis`),
  KEY `RefDivision_o_dependencia25` (`ID_dep`),
  KEY `RefOficial35` (`DNI`),
  CONSTRAINT `RefDenunciante21` FOREIGN KEY (`DNI_denunciante`) REFERENCES `denunciante` (`DNI`),
  CONSTRAINT `RefDivision_o_dependencia25` FOREIGN KEY (`ID_dep`) REFERENCES `dependencia` (`ID_dep`),
  CONSTRAINT `RefFiscalia24` FOREIGN KEY (`ID_fis`) REFERENCES `fiscalia` (`ID_fis`),
  CONSTRAINT `RefOficial22` FOREIGN KEY (`DNI_oficial`) REFERENCES `oficial` (`DNI`),
  CONSTRAINT `RefOficial35` FOREIGN KEY (`DNI`) REFERENCES `oficial` (`DNI`),
  CONSTRAINT `RefTipo_Delito23` FOREIGN KEY (`ID_delito`) REFERENCES `tipodelito` (`ID_delito`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `denuncia`
--

LOCK TABLES `denuncia` WRITE;
/*!40000 ALTER TABLE `denuncia` DISABLE KEYS */;
INSERT INTO `denuncia` VALUES (1,'2018-11-27 12:23:00','2018-11-27','EF001','YB','hurto','oral','26867511','46867513','De001','F001','DEP001','46867513');
/*!40000 ALTER TABLE `denuncia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `denunciado`
--

DROP TABLE IF EXISTS `denunciado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `denunciado` (
  `DNI` char(10) NOT NULL,
  PRIMARY KEY (`DNI`),
  CONSTRAINT `RefPersona15` FOREIGN KEY (`DNI`) REFERENCES `persona` (`DNI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `denunciado`
--

LOCK TABLES `denunciado` WRITE;
/*!40000 ALTER TABLE `denunciado` DISABLE KEYS */;
INSERT INTO `denunciado` VALUES ('16867510');
/*!40000 ALTER TABLE `denunciado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `denunciante`
--

DROP TABLE IF EXISTS `denunciante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `denunciante` (
  `DNI` char(10) NOT NULL,
  PRIMARY KEY (`DNI`),
  CONSTRAINT `RefPersona14` FOREIGN KEY (`DNI`) REFERENCES `persona` (`DNI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `denunciante`
--

LOCK TABLES `denunciante` WRITE;
/*!40000 ALTER TABLE `denunciante` DISABLE KEYS */;
INSERT INTO `denunciante` VALUES ('26867511');
/*!40000 ALTER TABLE `denunciante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dependencia`
--

DROP TABLE IF EXISTS `dependencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dependencia` (
  `ID_dep` char(10) NOT NULL,
  `nombre` char(10) DEFAULT NULL,
  PRIMARY KEY (`ID_dep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dependencia`
--

LOCK TABLES `dependencia` WRITE;
/*!40000 ALTER TABLE `dependencia` DISABLE KEYS */;
INSERT INTO `dependencia` VALUES ('DEP001','dependen');
/*!40000 ALTER TABLE `dependencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fiscalia`
--

DROP TABLE IF EXISTS `fiscalia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fiscalia` (
  `ID_fis` char(10) NOT NULL,
  `nro_expD` char(10) DEFAULT NULL,
  `nombre` char(10) DEFAULT NULL,
  `ID_dep` char(10) NOT NULL,
  PRIMARY KEY (`ID_fis`),
  KEY `RefDivision_o_dependencia34` (`ID_dep`),
  CONSTRAINT `RefDivision_o_dependencia34` FOREIGN KEY (`ID_dep`) REFERENCES `dependencia` (`ID_dep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fiscalia`
--

LOCK TABLES `fiscalia` WRITE;
/*!40000 ALTER TABLE `fiscalia` DISABLE KEYS */;
INSERT INTO `fiscalia` VALUES ('F001','ED001','casita','DEP001');
/*!40000 ALTER TABLE `fiscalia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `oficial`
--

DROP TABLE IF EXISTS `oficial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `oficial` (
  `DNI` char(10) NOT NULL,
  `cargo` char(10) DEFAULT NULL,
  `turno` char(10) DEFAULT NULL,
  `codigo` char(10) NOT NULL,
  PRIMARY KEY (`DNI`),
  KEY `RefComisaria33` (`codigo`),
  CONSTRAINT `RefComisaria33` FOREIGN KEY (`codigo`) REFERENCES `comisaria` (`codigo`),
  CONSTRAINT `RefPersona17` FOREIGN KEY (`DNI`) REFERENCES `persona` (`DNI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `oficial`
--

LOCK TABLES `oficial` WRITE;
/*!40000 ALTER TABLE `oficial` DISABLE KEYS */;
INSERT INTO `oficial` VALUES ('46867513','Suboficial','Mañana','C001');
/*!40000 ALTER TABLE `oficial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `DNI` char(10) NOT NULL,
  `apellido` char(10) DEFAULT NULL,
  `domicilio` char(10) DEFAULT NULL,
  `localidad` char(10) DEFAULT NULL,
  `fechaN` date DEFAULT NULL,
  `nombre` char(10) DEFAULT NULL,
  PRIMARY KEY (`DNI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES ('16867510','Suarez','mica 183','YB','1991-11-26','Lucia'),('26867511','Marcial','micasa 123','Capital','1990-11-26','Debora'),('36867512','Vargas','mica 1073','YB','1995-05-26','Mariel'),('46867513','Pepe','mica 35','Capital','1965-10-26','Juan Pablo');
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `testigo`
--

DROP TABLE IF EXISTS `testigo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `testigo` (
  `DNI` char(10) NOT NULL,
  PRIMARY KEY (`DNI`),
  CONSTRAINT `RefPersona16` FOREIGN KEY (`DNI`) REFERENCES `persona` (`DNI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `testigo`
--

LOCK TABLES `testigo` WRITE;
/*!40000 ALTER TABLE `testigo` DISABLE KEYS */;
INSERT INTO `testigo` VALUES ('36867512');
/*!40000 ALTER TABLE `testigo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiene`
--

DROP TABLE IF EXISTS `tiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiene` (
  `DNI` char(10) NOT NULL,
  `Nro_Denuncia` int(11) NOT NULL,
  PRIMARY KEY (`DNI`,`Nro_Denuncia`),
  KEY `RefDenuncia31` (`Nro_Denuncia`),
  CONSTRAINT `RefDenuncia31` FOREIGN KEY (`Nro_Denuncia`) REFERENCES `denuncia` (`Nro_Denuncia`),
  CONSTRAINT `RefDenunciado30` FOREIGN KEY (`DNI`) REFERENCES `denunciado` (`DNI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiene`
--

LOCK TABLES `tiene` WRITE;
/*!40000 ALTER TABLE `tiene` DISABLE KEYS */;
INSERT INTO `tiene` VALUES ('16867510',1);
/*!40000 ALTER TABLE `tiene` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipodelito`
--

DROP TABLE IF EXISTS `tipodelito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipodelito` (
  `ID_delito` char(10) NOT NULL,
  `nombre` char(10) DEFAULT NULL,
  PRIMARY KEY (`ID_delito`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipodelito`
--

LOCK TABLES `tipodelito` WRITE;
/*!40000 ALTER TABLE `tipodelito` DISABLE KEYS */;
INSERT INTO `tipodelito` VALUES ('De001','hurto');
/*!40000 ALTER TABLE `tipodelito` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-27 15:02:29
