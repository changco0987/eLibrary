-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 10, 2022 at 04:56 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `elibrary_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `admintb`
--

CREATE TABLE `admintb` (
  `id` int(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `name` varchar(20) NOT NULL,
  `contact` int(11) NOT NULL,
  `address` varchar(40) NOT NULL,
  `admissionCode` int(10) NOT NULL,
  `positionId` int(10) NOT NULL,
  `imageName` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admintb`
--

INSERT INTO `admintb` (`id`, `username`, `password`, `name`, `contact`, `address`, `admissionCode`, `positionId`, `imageName`) VALUES
(1, 'admin', 'admin', 'admin', 423234, 'admin442', 1233, 1, ''),
(2, 'batman', 'batman', 'jacod', 988127309, 'asdsda', 32131, 2, '');

-- --------------------------------------------------------

--
-- Table structure for table `authorinfotb`
--

CREATE TABLE `authorinfotb` (
  `id` int(10) NOT NULL,
  `authorName` varchar(30) NOT NULL,
  `address` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `authorinfotb`
--

INSERT INTO `authorinfotb` (`id`, `authorName`, `address`) VALUES
(1, 'alcantara', ''),
(2, 'alcantara', ''),
(3, 'alcantara', ''),
(4, 'alex', ''),
(5, 'alcantara', ''),
(6, 'adasd', ''),
(7, 'dasdasdasd', ''),
(8, 'dasdasd', ''),
(9, 'dasdasd', ''),
(10, 'adadd', ''),
(11, 'adasdasd', ''),
(12, 'adad', ''),
(13, 'micheal bay', ''),
(14, 'micheal bay', ''),
(15, 'asdad', ''),
(16, 'dasd', ''),
(17, 'micheal bay', ''),
(18, 'das', ''),
(19, 'add', ''),
(20, 'mc dambo', ''),
(21, 'yamete', ''),
(22, 'ichiro oda', ''),
(23, 'ochiro oda', ''),
(24, 'machito', ''),
(25, 'harold', ''),
(26, 'myka', '');

-- --------------------------------------------------------

--
-- Table structure for table `booksinfotb`
--

CREATE TABLE `booksinfotb` (
  `id` int(10) NOT NULL,
  `bookTitle` varchar(100) DEFAULT NULL,
  `authorInfoId` int(10) DEFAULT NULL,
  `yearPublished` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `subject` varchar(20) DEFAULT NULL,
  `synopsis` varchar(200) DEFAULT NULL,
  `preview` varchar(100) DEFAULT NULL,
  `adminId` int(10) DEFAULT NULL,
  `imageName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `booksinfotb`
--

INSERT INTO `booksinfotb` (`id`, `bookTitle`, `authorInfoId`, `yearPublished`, `subject`, `synopsis`, `preview`, `adminId`, `imageName`) VALUES
(2, 'random', 4, '2019-01-06 16:00:00', 'math', 'wadadasdas', '1', 1, '289023834_5659582674052080_7777795445969658313_n.jpg'),
(3, 'dino world', 6, '2022-07-10 00:05:37', 'english', 'adasd', '1', 1, ''),
(4, 'ocean park', 7, '2022-07-10 00:05:43', 'filipino', 'adadasd', '1', 1, ''),
(5, 'elfili', 8, '2022-07-10 00:07:12', 'math', 'adad', '1', 1, ''),
(6, 'kathang isip', 9, '2022-07-10 00:07:09', 'math', 'dada', '1', 1, ''),
(7, 'kwento ng isa bata', 10, '2022-07-10 00:07:06', 'science', 'dasd', '1', 1, ''),
(8, 'the dark ages', 11, '2022-07-10 00:07:13', 'math', 'adasd', '2', 2, ''),
(9, 'sarimanok', 12, '2022-07-10 00:06:31', 'dad', 'dasd', '2', 2, ''),
(12, 'age of empires', 16, '2022-07-10 00:06:59', 'science', '', '0', NULL, ''),
(13, 'jurrasic park s2', 17, '2022-07-10 00:07:17', 'math', '', '0', NULL, ''),
(14, 'jurrasic park s2', 13, '2022-07-10 00:07:22', 'engslish', '', '0', NULL, ''),
(15, 'gundam reborn', 18, '2022-07-10 00:07:04', 'science', '', '0', NULL, ''),
(16, 'one piece saga', 19, '2022-07-10 00:07:01', 'science', '', '0', NULL, ''),
(17, 'transformers', 13, '1994-07-13 16:00:00', 'science', 'ConvertICO is a free online PNG to ICO file converter. It is fast, free and easy to use. It is used to convert Desktop Icons, App Icons as well as the much needed favicons for websites. Go ahead and g', '1', 1, ''),
(18, 'dangerous crow', 20, '2019-05-14 16:00:00', '', '', '0', NULL, ''),
(19, 'Yugioh master s1', 21, '1989-01-30 16:00:00', '', '', '0', NULL, ''),
(22, 'the great lion', 26, '2022-06-09 16:00:00', '', '', NULL, NULL, '');

-- --------------------------------------------------------

--
-- Table structure for table `borrowtb`
--

CREATE TABLE `borrowtb` (
  `id` int(10) NOT NULL,
  `booksInfoId` int(11) DEFAULT NULL,
  `userId` int(11) DEFAULT NULL,
  `startDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `returnDate` timestamp NULL DEFAULT NULL,
  `remarks` varchar(20) DEFAULT NULL,
  `adminId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `borrowtb`
--

INSERT INTO `borrowtb` (`id`, `booksInfoId`, `userId`, `startDate`, `returnDate`, `remarks`, `adminId`) VALUES
(2, 5, 1, '2022-07-09 16:00:00', '2022-07-22 16:00:00', 'accepted', 1),
(3, 6, 1, '2022-07-09 16:00:00', '2022-07-28 16:00:00', 'pending', NULL),
(4, 4, 1, '2022-07-09 16:00:00', '0000-00-00 00:00:00', 'pending', NULL),
(5, 16, 1, '2022-07-09 16:00:00', '2023-02-16 16:00:00', 'pending', NULL),
(6, 6, 1, '2022-07-09 16:00:00', '2022-07-11 16:00:00', 'pending', NULL),
(7, 18, 4, '2022-07-09 16:00:00', '2022-07-09 16:00:00', 'accepted', 1),
(8, 6, 4, '2022-07-09 16:00:00', '2022-07-09 16:00:00', 'pending', NULL),
(9, 5, 4, '2022-07-09 16:00:00', '2022-07-09 16:00:00', 'pending', NULL),
(10, 5, 4, '2022-07-09 16:00:00', '2022-07-09 16:00:00', 'accepted', 1),
(11, 7, 4, '2022-07-09 16:00:00', '2022-07-09 16:00:00', 'pending', NULL),
(12, 18, 4, '2022-07-09 16:00:00', '2022-07-09 16:00:00', 'decline', 1),
(13, 4, 4, '2022-07-09 16:00:00', '2022-07-09 16:00:00', 'decline', 1),
(14, 4, 4, '2022-07-09 16:00:00', '2021-06-17 16:00:00', 'decline', 1);

-- --------------------------------------------------------

--
-- Table structure for table `donatetb`
--

CREATE TABLE `donatetb` (
  `id` int(10) NOT NULL,
  `userId` int(11) DEFAULT NULL,
  `booksInfoId` int(11) DEFAULT NULL,
  `recieveDate` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `adminId` int(11) DEFAULT NULL,
  `remark` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `donatetb`
--

INSERT INTO `donatetb` (`id`, `userId`, `booksInfoId`, `recieveDate`, `adminId`, `remark`) VALUES
(5, 1, 16, '2022-07-09 23:06:53', 1, 'accepted'),
(6, 1, 18, '2022-07-10 00:17:27', 1, 'accepted'),
(7, 1, 19, '2022-06-29 16:00:00', NULL, 'pending'),
(8, 4, 22, '2022-07-21 16:00:00', NULL, 'pending');

-- --------------------------------------------------------

--
-- Table structure for table `positiontb`
--

CREATE TABLE `positiontb` (
  `id` int(10) NOT NULL,
  `jobPosition` varchar(20) NOT NULL,
  `salary` int(10) NOT NULL,
  `jobDescription` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `positiontb`
--

INSERT INTO `positiontb` (`id`, `jobPosition`, `salary`, `jobDescription`) VALUES
(1, 'librarian', 30000, ''),
(2, 'assistant librarian', 20000, ''),
(3, 'technical librarian', 25000, '');

-- --------------------------------------------------------

--
-- Table structure for table `usertb`
--

CREATE TABLE `usertb` (
  `id` int(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `name` varchar(20) NOT NULL,
  `emailAddress` varchar(30) NOT NULL,
  `contact` int(11) NOT NULL,
  `address` varchar(50) NOT NULL,
  `imageName` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usertb`
--

INSERT INTO `usertb` (`id`, `username`, `password`, `name`, `emailAddress`, `contact`, `address`, `imageName`) VALUES
(1, 'admin', 'admin0123', 'jamesyap', 'admin123@gmail.com', 83434343, '123 tondo mnl', '289023834_5659582674052080_7777795445969658313_n.jpg'),
(3, 'asdasdas', 'aaa', 'test sdasd', 'asdadas', 3432424, 'ad', ''),
(4, 'chito', 'chito', 'chito miranda', 'chito@gmail.com', 94950421, 'mctan094950421', ''),
(5, 'lolo', 'lolo', 'lolo lolo', 'lolo@gmail.com', 934354545, 'lolo0934354545', ''),
(6, 'martin', 'martin', 'martin young', 'martin12@gmail.com', 2147483647, 'martin st. tondo', 'icons8-right-arrow-32.png');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admintb`
--
ALTER TABLE `admintb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `authorinfotb`
--
ALTER TABLE `authorinfotb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `booksinfotb`
--
ALTER TABLE `booksinfotb`
  ADD PRIMARY KEY (`id`),
  ADD KEY `authorInfoId` (`authorInfoId`),
  ADD KEY `adminId` (`adminId`);

--
-- Indexes for table `borrowtb`
--
ALTER TABLE `borrowtb`
  ADD PRIMARY KEY (`id`),
  ADD KEY `booksInfoId` (`booksInfoId`),
  ADD KEY `userId` (`userId`),
  ADD KEY `adminId` (`adminId`);

--
-- Indexes for table `donatetb`
--
ALTER TABLE `donatetb`
  ADD PRIMARY KEY (`id`),
  ADD KEY `userId` (`userId`),
  ADD KEY `adminId` (`adminId`),
  ADD KEY `donatetb_ibfk_2` (`booksInfoId`);

--
-- Indexes for table `positiontb`
--
ALTER TABLE `positiontb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `usertb`
--
ALTER TABLE `usertb`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admintb`
--
ALTER TABLE `admintb`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `authorinfotb`
--
ALTER TABLE `authorinfotb`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `booksinfotb`
--
ALTER TABLE `booksinfotb`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `borrowtb`
--
ALTER TABLE `borrowtb`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `donatetb`
--
ALTER TABLE `donatetb`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `positiontb`
--
ALTER TABLE `positiontb`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `usertb`
--
ALTER TABLE `usertb`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `booksinfotb`
--
ALTER TABLE `booksinfotb`
  ADD CONSTRAINT `booksinfotb_ibfk_1` FOREIGN KEY (`authorInfoId`) REFERENCES `authorinfotb` (`id`),
  ADD CONSTRAINT `booksinfotb_ibfk_2` FOREIGN KEY (`adminId`) REFERENCES `admintb` (`id`);

--
-- Constraints for table `borrowtb`
--
ALTER TABLE `borrowtb`
  ADD CONSTRAINT `borrowtb_ibfk_1` FOREIGN KEY (`booksInfoId`) REFERENCES `booksinfotb` (`id`),
  ADD CONSTRAINT `borrowtb_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `usertb` (`id`),
  ADD CONSTRAINT `borrowtb_ibfk_3` FOREIGN KEY (`adminId`) REFERENCES `admintb` (`id`);

--
-- Constraints for table `donatetb`
--
ALTER TABLE `donatetb`
  ADD CONSTRAINT `donatetb_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `usertb` (`id`),
  ADD CONSTRAINT `donatetb_ibfk_2` FOREIGN KEY (`booksInfoId`) REFERENCES `booksinfotb` (`id`),
  ADD CONSTRAINT `donatetb_ibfk_3` FOREIGN KEY (`adminId`) REFERENCES `admintb` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
