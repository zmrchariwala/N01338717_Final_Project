-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 05, 2019 at 05:17 AM
-- Server version: 5.7.26
-- PHP Version: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `page_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `pages`
--

DROP TABLE IF EXISTS `pages`;
CREATE TABLE IF NOT EXISTS `pages` (
  `pageid` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `pagetitle` varchar(255) NOT NULL,
  `pagebody` mediumtext NOT NULL,
  `pagedate` date NOT NULL,
  `pageauthor` varchar(255) NOT NULL,
  `pagestatus` varchar(255) NOT NULL,
  PRIMARY KEY (`pageid`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pages`
--

INSERT INTO `pages` (`pageid`, `pagetitle`, `pagebody`, `pagedate`, `pageauthor`, `pagestatus`) VALUES
(10, 'Page 10', 'Ramdon things', '2019-11-20', 'Williams', 'Unpublish'),
(7, 'Page 6', 'Random stuffs', '2019-12-16', 'Peter', 'Published'),
(9, 'Page 9', 'It is a good page', '2019-12-20', 'Robert', 'Published'),
(11, 'Page 11', 'This is dummy page', '2019-12-04', 'Smith', 'Published'),
(13, 'Page 12', 'This is all about page 12.', '2019-12-04', 'Williams', 'Published');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
