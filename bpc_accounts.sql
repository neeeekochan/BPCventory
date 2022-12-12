-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 30, 2022 at 05:17 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bpc_accounts`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(10) UNSIGNED ZEROFILL NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `age` int(10) NOT NULL,
  `email` varchar(100) NOT NULL,
  `mobile number` varchar(50) NOT NULL,
  `privileges` varchar(50) NOT NULL,
  `unique_ID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `firstname`, `lastname`, `username`, `password`, `age`, `email`, `mobile number`, `privileges`, `unique_ID`) VALUES
(0000000001, 'Nicko', 'Osabel', 'nekochan', '122100', 21, 'nickoosabel@gmail.com', '09760247407', 'ADMINISTRATOR', 'E647DAD6B1287A4F4575D97D0B1FEF7043B0216B'),
(0000000002, 'Janine', 'Grimaldo', 'jajagrim', '12345', 21, 'janine.grimaldo@gmail.com', '09xxxxxxxxx', 'ADMINISTRATOR', '31275A29615A5B000388E18470C0F55BCEEC1B76'),
(0000000003, 'Mitchie', 'Lamo', 'mitchie', 'password', 22, '\r\nmitshellapotter@gmail.com', '09282393885', 'ADMINISTRATOR', '645B2B997E229BFCF4E6A0E7FE765B15B506FD93'),
(0000000004, 'Levy', 'Cielo', 'cielolevy_', 'levylevs27', 21, '\r\nlevycielo4@gmail.com', '09271800604', 'ADMINISTRATOR', '17CDA4943D451AB29EC4CAA5579DDA308CDCE6E6');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(10) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
