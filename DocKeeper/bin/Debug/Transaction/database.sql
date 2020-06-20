-- MySQL dump 10.13  Distrib 5.1.40, for Win32 (ia32)
--
-- Host: 172.20.10.4    Database: dockeeper
-- ------------------------------------------------------
-- Server version	5.5.9

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
-- Current Database: `dockeeper`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `dockeeper` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `dockeeper`;

--
-- Table structure for table `tbl20180907`
--

DROP TABLE IF EXISTS `tbl20180907`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl20180907` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `refnumber` varchar(105) CHARACTER SET latin1 NOT NULL,
  `trntype` varchar(45) NOT NULL,
  `filename` varchar(500) CHARACTER SET latin1 NOT NULL,
  `archievedname` text NOT NULL,
  `extension` varchar(45) NOT NULL,
  `attachment` longblob,
  `filesize` bigint(20) unsigned NOT NULL,
  `datesaved` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=83 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl20180909`
--

DROP TABLE IF EXISTS `tbl20180909`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl20180909` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `refnumber` varchar(105) CHARACTER SET latin1 NOT NULL,
  `trntype` varchar(45) NOT NULL,
  `filename` varchar(500) CHARACTER SET latin1 NOT NULL,
  `archievedname` text NOT NULL,
  `extension` varchar(45) NOT NULL,
  `attachment` longblob,
  `filesize` bigint(20) unsigned NOT NULL,
  `datesaved` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=66 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblaccounts`
--

DROP TABLE IF EXISTS `tblaccounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblaccounts` (
  `accountid` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fullname` varchar(45) NOT NULL,
  `position` text,
  `username` varchar(45) NOT NULL,
  `password` varchar(100) NOT NULL,
  `adminuser` tinyint(1) NOT NULL DEFAULT '0',
  `datereg` datetime NOT NULL,
  PRIMARY KEY (`accountid`)
) ENGINE=MyISAM AUTO_INCREMENT=314 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblattachmentlogs`
--

DROP TABLE IF EXISTS `tblattachmentlogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblattachmentlogs` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `refnumber` varchar(105) CHARACTER SET latin1 NOT NULL,
  `databasename` varchar(45) NOT NULL,
  `filename` text NOT NULL,
  `archievedname` text NOT NULL,
  `filesize` bigint(20) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=301 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblcategory`
--

DROP TABLE IF EXISTS `tblcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcategory` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `description` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10003 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblcompanysettings`
--

DROP TABLE IF EXISTS `tblcompanysettings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcompanysettings` (
  `unitcode` varchar(7) NOT NULL,
  `companyname` text NOT NULL,
  `compadd` text NOT NULL,
  `telephone` text NOT NULL,
  PRIMARY KEY (`unitcode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbldochistory`
--

DROP TABLE IF EXISTS `tbldochistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbldochistory` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `refcode` varchar(205) NOT NULL,
  `remarks` text NOT NULL,
  `historydate` datetime NOT NULL,
  `historyby` varchar(15) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=112 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbldocuments`
--

DROP TABLE IF EXISTS `tbldocuments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbldocuments` (
  `refcode` varchar(25) NOT NULL,
  `seriesno` int(10) unsigned NOT NULL DEFAULT '0',
  `doctitle` text NOT NULL,
  `description` text NOT NULL,
  `category` varchar(15) NOT NULL,
  `referenceno` varchar(45) NOT NULL,
  `docdate` date NOT NULL,
  `datesaved` datetime NOT NULL,
  `savedby` varchar(15) NOT NULL,
  `passprotected` tinyint(1) NOT NULL DEFAULT '0',
  `password` text NOT NULL,
  `deleted` tinyint(1) NOT NULL DEFAULT '0',
  `deletedby` varchar(15) DEFAULT NULL,
  `datedeleted` datetime DEFAULT NULL,
  PRIMARY KEY (`refcode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblgeneralsettings`
--

DROP TABLE IF EXISTS `tblgeneralsettings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblgeneralsettings` (
  `id` int(10) unsigned NOT NULL DEFAULT '0',
  `orgname` text NOT NULL,
  `orgoffice` text NOT NULL,
  `orgtelephone` text NOT NULL,
  `orgaddress` text NOT NULL,
  `headercenter` tinyint(1) NOT NULL DEFAULT '0',
  `allowableattachsize` double NOT NULL DEFAULT '0',
  `archiveddir` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbllogin`
--

DROP TABLE IF EXISTS `tbllogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbllogin` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `userid` text NOT NULL,
  `intime` datetime DEFAULT NULL,
  `outtime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9115 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-09-10  0:32:39
