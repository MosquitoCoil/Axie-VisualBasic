-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2021 at 12:49 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbsupercell`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_characters`
--

CREATE TABLE `tbl_characters` (
  `id` int(15) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `damage` varchar(255) DEFAULT NULL,
  `speed` varchar(255) DEFAULT NULL,
  `target` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_characters`
--

INSERT INTO `tbl_characters` (`id`, `name`, `damage`, `speed`, `target`) VALUES
(23, 'Jaymar', '200', '35', 'Bird'),
(25, 'Nicole', '156', '56', 'Bird');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_characters`
--
ALTER TABLE `tbl_characters`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_characters`
--
ALTER TABLE `tbl_characters`
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
