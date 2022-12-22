-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2022 at 10:26 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dt`
--

-- --------------------------------------------------------

--
-- Table structure for table `components`
--

CREATE TABLE `components` (
  `component_id` int(100) NOT NULL,
  `production_id` int(100) NOT NULL,
  `material_id` int(100) NOT NULL,
  `quantity` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customer_id` int(100) NOT NULL,
  `company_name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `contact_no` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customer_id`, `company_name`, `email`, `contact_no`) VALUES
(10001, 'Company A', 'acompany@gmail.com', '09245553498'),
(10002, 'Company B', 'bcompany@gmail.com', '09347645836'),
(10003, 'Company C', 'ccompany@gmail.com', '09367846234'),
(10004, 'Company D', 'dcompany@gmail.com', '09256745678'),
(10005, 'Company E', 'ecompany@gmail.com', '09764587435'),
(10006, 'Company F', 'fcompany@gmail.com', '09764587231'),
(10007, 'Company G', 'gcompany@gmail.com', '09875634868'),
(10008, 'Company H', 'hcompany@gmail.com', '09652143875'),
(10009, 'Company I', 'icompany@gmail.com', '09653487456'),
(10010, 'Company J', 'jcompany@gmail.com', '09873412765');

-- --------------------------------------------------------

--
-- Table structure for table `make`
--

CREATE TABLE `make` (
  `production_id` int(100) NOT NULL,
  `product_id` int(100) NOT NULL,
  `quantity` int(100) NOT NULL,
  `production_deadline` datetime NOT NULL,
  `status` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `materials`
--

CREATE TABLE `materials` (
  `material_id` int(100) NOT NULL,
  `material_name` varchar(100) NOT NULL,
  `average_cost` int(100) NOT NULL,
  `in_stock` int(100) NOT NULL,
  `expected` int(100) NOT NULL,
  `committed` int(100) NOT NULL,
  `missing` int(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  `supplier_id` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `materials`
--

INSERT INTO `materials` (`material_id`, `material_name`, `average_cost`, `in_stock`, `expected`, `committed`, `missing`, `status`, `supplier_id`) VALUES
(30001, 'Acetal Rod', 49, 1000, 0, 0, 0, '', 20001),
(30002, 'Acetal Sheet (6x6x4)', 275, 1000, 0, 0, 0, '', 20001),
(30003, 'Acetal Sheet (7.5x7x5)', 344, 1000, 0, 0, 0, '', 20001),
(30004, 'Stainless Rod', 23, 1000, 0, 0, 0, '', 20002),
(30005, 'Aluminum Sheet (6x6x4)', 159, 1000, 0, 0, 0, '', 20002),
(30006, 'Aluminum Sheet (7.5x7x5)', 194, 1000, 0, 0, 0, '', 20002),
(30007, 'Set Screw Allen', 13, 1000, 0, 0, 0, '', 20003),
(30008, 'Spring', 28, 1000, 0, 0, 0, '', 20003),
(30009, 'Anchor Nut', 5, 1000, 0, 0, 0, '', 20003),
(30010, 'Acrylic Clear (6x6x4)', 17, 1000, 0, 0, 0, '', 20004),
(30011, 'Acrylic Clear (7.5x7x5)', 20, 1000, 0, 0, 0, '', 20004),
(30012, 'Electric Wire', 5, 1000, 0, 0, 0, '', 20005),
(30013, 'Microswitch', 15, 1000, 0, 0, 0, '', 20005),
(30014, 'LED', 5, 1000, 0, 0, 0, '', 20005),
(30015, 'Cylindrical Magnet', 40, 1000, 0, 0, 0, '', 20005),
(30016, 'Acetal Sheet (5x4x4)', 126, 1000, 0, 0, 0, '', 20001),
(30017, 'Acetal Sheet (2.5x2x2)', 63, 1000, 0, 0, 0, '', 20001),
(30018, 'Acetal Sheet (3x3x3)', 137, 1000, 0, 0, 0, '', 20001),
(30019, 'Acetal Sheet (3.75x3.5x2.5)', 172, 1000, 0, 0, 0, '', 20001);

-- --------------------------------------------------------

--
-- Table structure for table `production_log`
--

CREATE TABLE `production_log` (
  `log_id` int(100) NOT NULL,
  `production_id` int(100) NOT NULL,
  `datetime` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `quantity` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_id` int(100) NOT NULL,
  `product_name` varchar(100) NOT NULL,
  `part_number` varchar(100) NOT NULL,
  `product_size` varchar(100) NOT NULL,
  `unit_length` varchar(100) NOT NULL,
  `product_dimension` varchar(100) NOT NULL,
  `sale_price` int(100) NOT NULL,
  `average_cost` int(100) NOT NULL,
  `profit` int(100) NOT NULL,
  `in_stock` int(100) NOT NULL,
  `expected` int(100) NOT NULL,
  `ordered` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_id`, `product_name`, `part_number`, `product_size`, `unit_length`, `product_dimension`, `sale_price`, `average_cost`, `profit`, `in_stock`, `expected`, `ordered`) VALUES
(40001, 'SUB ASSY BODY WITH LOCKPIN', '62 7289*3801*30', 'Small', '25MM', '36x30x30 ', 565, 330, 235, 1000, 0, 0),
(40002, 'SUB ASSY BODY WITH LOCKPIN', '504 7287*1915*90', 'Small', '22MM', '30x30x30 ', 565, 330, 235, 1000, 0, 0),
(40003, 'SUB ASSY BODY WITH LOCK PIN', '506 7289*1915*30\r\n', 'Small', '23MM', '30x30x30', 565, 330, 235, 1000, 0, 0),
(40004, 'SUB ASSY BODY WITH LOCK PIN', '126 7219*1025*30\r\n', ' Small', '25MM', '30x35x30', 565, 330, 235, 1000, 0, 0),
(40005, 'SUB ASSY BODY WITH LOCKPIN', ' 79 7289*8228*30', 'Small', '25MM', '37x30x30 ', 565, 330, 235, 1000, 0, 0),
(40006, 'SUB ASSY BODY WITH LOCKPIN', '57 7289*7040*30', 'Medium', '35MM', '45x33x30 ', 870, 479, 391, 0, 0, 0),
(40007, 'SUB ASSY BODY WITH LOCKPIN', '84 7289*8077*30', 'Medium', '30MM', '42x35x35 ', 870, 479, 391, 1000, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `sales_id` int(11) NOT NULL,
  `sales_date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `user_id` int(11) UNSIGNED ZEROFILL NOT NULL,
  `customer_id` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`sales_id`, `sales_date`, `user_id`, `customer_id`) VALUES
(100257, '2020-11-04 06:59:23', 00000000003, 10002),
(100258, '2020-12-08 07:00:48', 00000000003, 10003),
(100259, '2021-01-13 05:02:37', 00000000003, 10010),
(100260, '2021-01-19 07:03:56', 00000000003, 10001),
(100261, '2021-02-10 07:09:11', 00000000003, 10009),
(100262, '2021-02-17 08:10:26', 00000000003, 10004),
(100263, '2021-03-02 07:12:41', 00000000003, 10001),
(100264, '2021-03-10 07:13:28', 00000000003, 10010),
(100265, '2021-04-08 07:16:42', 00000000003, 10006),
(100266, '2021-04-16 07:17:19', 00000000003, 10004),
(100267, '2021-05-05 07:21:41', 00000000003, 10009),
(100268, '2021-05-12 07:22:44', 00000000003, 10001),
(100269, '2021-05-19 07:23:28', 00000000003, 10006),
(100270, '2021-06-09 07:24:19', 00000000003, 10003),
(100271, '2021-06-16 07:25:59', 00000000003, 10002),
(100272, '2021-07-07 07:28:33', 00000000004, 10002),
(100273, '2021-07-14 07:28:55', 00000000004, 10003),
(100274, '2021-07-21 07:29:56', 00000000004, 10005),
(100275, '2021-08-11 03:31:21', 00000000004, 10009),
(100276, '2021-08-25 07:32:19', 00000000004, 10002),
(100277, '2021-09-15 07:32:49', 00000000004, 10007),
(100278, '2021-09-20 07:33:06', 00000000004, 10006),
(100279, '2021-09-27 07:33:34', 00000000004, 10002),
(100280, '2021-10-13 07:35:29', 00000000004, 10008),
(100281, '2021-10-20 07:38:13', 00000000004, 10002),
(100282, '2021-10-28 07:42:56', 00000000004, 10008),
(100283, '2021-11-10 07:44:56', 00000000004, 10001),
(100284, '2021-11-25 07:46:30', 00000000004, 10004),
(100285, '2021-12-08 07:48:04', 00000000004, 10005),
(100286, '2021-12-14 08:38:26', 00000000004, 10009),
(100287, '2021-12-22 07:50:13', 00000000004, 10010),
(100288, '2022-01-05 07:51:05', 00000000004, 10001),
(100289, '2022-01-12 08:39:53', 00000000004, 10002),
(100290, '2022-01-26 07:58:26', 00000000004, 10004),
(100291, '2022-02-09 08:00:08', 00000000004, 10009),
(100292, '2022-02-23 08:00:45', 00000000004, 10002),
(100293, '2022-03-09 08:01:01', 00000000004, 10009),
(100294, '2022-03-13 08:06:29', 00000000004, 10006),
(100295, '2022-04-13 08:13:40', 00000000004, 10010),
(100296, '2022-04-26 08:13:56', 00000000004, 10005),
(100297, '2022-04-30 08:14:20', 00000000004, 10004),
(100298, '2022-05-04 08:45:48', 00000000004, 10001),
(100299, '2022-05-25 08:46:04', 00000000004, 10003),
(100300, '2022-06-01 08:47:12', 00000000004, 10007),
(100301, '2022-06-15 08:48:25', 00000000004, 10006),
(100302, '2022-06-29 08:49:08', 00000000004, 10010),
(100303, '2022-07-06 08:50:36', 00000000004, 10009),
(100304, '2022-07-20 08:51:14', 00000000004, 10008),
(100305, '2022-08-10 08:51:49', 00000000004, 10003),
(100306, '2022-08-24 08:52:45', 00000000004, 10006),
(100307, '2022-09-01 08:53:53', 00000000004, 10005),
(100308, '2022-09-14 08:54:15', 00000000004, 10004),
(100309, '2022-09-28 08:55:01', 00000000004, 10003),
(100310, '2022-10-12 08:55:49', 00000000004, 10002),
(100311, '2022-10-26 09:15:00', 00000000004, 10001),
(100312, '2022-10-31 08:57:23', 00000000004, 10005),
(100313, '2022-11-09 08:58:04', 00000000004, 10008),
(100314, '2022-11-16 09:01:58', 00000000004, 10001),
(100315, '2022-11-30 09:02:15', 00000000004, 10004),
(100316, '2022-12-07 09:02:53', 00000000004, 10008),
(100317, '2022-12-13 09:03:44', 00000000004, 10010),
(100318, '2022-12-13 09:04:10', 00000000004, 10002);

-- --------------------------------------------------------

--
-- Table structure for table `sales_details`
--

CREATE TABLE `sales_details` (
  `sale_details_id` int(100) NOT NULL,
  `sales_id` int(100) NOT NULL,
  `product_id` int(100) NOT NULL,
  `sale_quantity` int(100) NOT NULL,
  `total` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sales_details`
--

INSERT INTO `sales_details` (`sale_details_id`, `sales_id`, `product_id`, `sale_quantity`, `total`) VALUES
(11243, 100257, 40003, 6, 3390),
(11244, 100257, 40004, 8, 4520),
(11245, 100257, 40006, 8, 6960),
(11246, 100257, 40001, 6, 3390),
(11247, 100258, 40003, 8, 4520),
(11248, 100258, 40006, 7, 6090),
(11249, 100258, 40002, 9, 5085),
(11250, 100258, 40007, 4, 3480),
(11251, 100259, 40005, 16, 9040),
(11252, 100259, 40001, 12, 6780),
(11253, 100259, 40004, 3, 1695),
(11254, 100259, 40001, 5, 2825),
(11255, 100260, 40004, 8, 4520),
(11256, 100260, 40007, 10, 8700),
(11257, 100260, 40005, 13, 7345),
(11258, 100260, 40002, 7, 3955),
(11259, 100261, 40002, 13, 7345),
(11260, 100261, 40001, 15, 8475),
(11261, 100261, 40004, 9, 5085),
(11262, 100261, 40002, 10, 5650),
(11263, 100262, 40006, 5, 4350),
(11264, 100262, 40002, 9, 5085),
(11265, 100262, 40004, 8, 4520),
(11266, 100262, 40005, 6, 3390),
(11267, 100262, 40007, 7, 6090),
(11268, 100263, 40003, 12, 6780),
(11269, 100263, 40001, 7, 3955),
(11270, 100263, 40002, 9, 5085),
(11271, 100263, 40006, 8, 6960),
(11272, 100263, 40005, 8, 4520),
(11273, 100264, 40001, 10, 5650),
(11274, 100265, 40003, 15, 8475),
(11275, 100265, 40002, 11, 6215),
(11276, 100266, 40001, 6, 3390),
(11277, 100266, 40003, 14, 7910),
(11278, 100266, 40005, 10, 5650),
(11279, 100267, 40007, 7, 6090),
(11280, 100267, 40002, 7, 3955),
(11281, 100267, 40003, 8, 4520),
(11282, 100267, 40004, 8, 4520),
(11283, 100268, 40001, 5, 2825),
(11284, 100268, 40002, 10, 5650),
(11285, 100268, 40003, 15, 8475),
(11286, 100268, 40004, 20, 11300),
(11287, 100269, 40003, 13, 7345),
(11288, 100270, 40004, 12, 6780),
(11289, 100270, 40003, 9, 5085),
(11290, 100270, 40005, 7, 3955),
(11291, 100271, 40002, 12, 6780),
(11292, 100271, 40006, 8, 6960),
(11293, 100271, 40002, 10, 5650),
(11294, 100271, 40005, 7, 3955),
(11295, 100271, 40007, 8, 6960),
(11296, 100271, 40001, 9, 5085),
(11297, 100272, 40002, 15, 8475),
(11298, 100273, 40004, 24, 13560),
(11299, 100274, 40006, 5, 4350),
(11300, 100274, 40002, 6, 3390),
(11301, 100275, 40003, 4, 2260),
(11302, 100275, 40005, 2, 1130),
(11303, 100275, 40001, 7, 3955),
(11304, 100276, 40004, 8, 4520),
(11305, 100276, 40003, 7, 3955),
(11306, 100276, 40001, 6, 3390),
(11307, 100276, 40005, 5, 2825),
(11308, 100276, 40007, 9, 7830),
(11309, 100277, 40003, 7, 3955),
(11310, 100277, 40004, 8, 4520),
(11311, 100278, 40001, 10, 5650),
(11312, 100279, 40007, 8, 6960),
(11313, 100280, 40001, 2, 1130),
(11314, 100280, 40002, 3, 1695),
(11315, 100280, 40005, 4, 2260),
(11316, 100280, 40004, 7, 3955),
(11317, 100280, 40007, 3, 2610),
(11318, 100281, 40002, 13, 7345),
(11319, 100282, 40004, 3, 1695),
(11320, 100282, 40003, 5, 2825),
(11321, 100283, 40004, 10, 5650),
(11322, 100284, 40005, 17, 9605),
(11323, 100284, 40002, 13, 7345),
(11324, 100285, 40004, 14, 7910),
(11325, 100286, 40003, 10, 5650),
(11326, 100286, 40001, 5, 2825),
(11327, 100287, 40007, 7, 6090),
(11328, 100287, 40001, 6, 3390),
(11329, 100287, 40002, 5, 2825),
(11330, 100287, 40003, 5, 2825),
(11331, 100287, 40004, 4, 2260),
(11332, 100287, 40005, 8, 4520),
(11333, 100288, 40002, 11, 6215),
(11334, 100289, 40001, 23, 12995),
(11335, 100290, 40003, 4, 2260),
(11336, 100290, 40005, 3, 1695),
(11337, 100290, 40002, 5, 2825),
(11338, 100291, 40003, 13, 7345),
(11339, 100291, 40002, 120, 67800),
(11340, 100291, 40003, 200, 113000),
(11341, 100292, 40005, 12, 6780),
(11342, 100293, 40002, 12, 6780),
(11343, 100294, 40002, 12, 6780),
(11344, 100294, 40003, 11, 6215),
(11345, 100295, 40002, 11, 6215),
(11346, 100295, 40006, 15, 13050),
(11347, 100295, 40004, 17, 9605),
(11348, 100296, 40006, 25, 21750),
(11349, 100297, 40003, 9, 5085),
(11350, 100297, 40004, 11, 6215),
(11351, 100298, 40003, 25, 14125),
(11352, 100298, 40004, 13, 7345),
(11353, 100299, 40004, 12, 6780),
(11354, 100300, 40006, 18, 15660),
(11355, 100300, 40003, 9, 5085),
(11356, 100300, 40001, 12, 6780),
(11357, 100301, 40005, 20, 11300),
(11358, 100301, 40002, 11, 6215),
(11359, 100301, 40006, 11, 9570),
(11360, 100301, 40007, 9, 7830),
(11361, 100302, 40003, 8, 4520),
(11362, 100302, 40005, 7, 3955),
(11363, 100302, 40007, 13, 11310),
(11364, 100303, 40004, 21, 11865),
(11365, 100304, 40006, 6, 5220),
(11366, 100304, 40002, 4, 2260),
(11367, 100304, 40003, 8, 4520),
(11368, 100305, 40003, 13, 7345),
(11369, 100305, 40004, 12, 6780),
(11370, 100305, 40007, 9, 7830),
(11371, 100306, 40003, 40, 22600),
(11372, 100307, 40003, 9, 5085),
(11373, 100307, 40006, 6, 5220),
(11374, 100307, 40001, 1, 565),
(11375, 100308, 40002, 14, 7910),
(11376, 100309, 40005, 10, 5650),
(11377, 100309, 40007, 10, 8700),
(11378, 100309, 40003, 10, 5650),
(11379, 100310, 40003, 8, 4520),
(11380, 100310, 40004, 8, 4520),
(11381, 100310, 40005, 8, 4520),
(11382, 100311, 40003, 12, 6780),
(11383, 100311, 40006, 16, 13920),
(11384, 100312, 40001, 5, 2825),
(11385, 100312, 40002, 5, 2825),
(11386, 100312, 40005, 7, 3955),
(11387, 100313, 40004, 4, 2260),
(11388, 100313, 40007, 5, 4350),
(11389, 100313, 40001, 6, 3390),
(11390, 100314, 40003, 13, 7345),
(11391, 100314, 40002, 12, 6780),
(11392, 100315, 40006, 20, 17400),
(11393, 100316, 40004, 12, 6780),
(11394, 100316, 40003, 12, 6780),
(11395, 100316, 40001, 8, 4520),
(11396, 100317, 40003, 5, 2825),
(11397, 100317, 40002, 7, 3955),
(11398, 100317, 40005, 6, 3390),
(11399, 100318, 40003, 20, 11300);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `supplier_id` int(100) NOT NULL,
  `company_name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `contact_no` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`supplier_id`, `company_name`, `email`, `contact_no`) VALUES
(20001, 'Supplier 1', '1supplier@gmail.com', '09564324523'),
(20002, 'Supplier 2', '2supplier@gmail.com', '09741286438'),
(20003, 'Supplier 3', '3supplier@gmail.com', '09562348763'),
(20004, 'Supplier 4', '4supplier@gmail.com', '09561263496'),
(20005, 'Supplier 5', '5supplier@gmail.com', '09534782367');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) UNSIGNED ZEROFILL NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `age` int(10) NOT NULL,
  `email` varchar(100) NOT NULL,
  `mobile_number` varchar(50) NOT NULL,
  `privileges` varchar(50) NOT NULL,
  `unique_ID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `firstname`, `lastname`, `username`, `password`, `age`, `email`, `mobile_number`, `privileges`, `unique_ID`) VALUES
(00000000001, 'Enrico', 'Osabel', 'nekochan', '122100', 21, 'nickoosabel@gmail.com', '09760247407', 'ADMINISTRATOR', 'e647dad6b1287a4f4575d97d0b1fef7043b0216b'),
(00000000002, 'Janine', 'Grimaldo', 'jajagrim', 'janine', 21, 'janine.grimaldo@gmail.com', '09459604859', 'ADMINISTRATOR', '31275a29615a5b000388e18470c0f55bceec1b76'),
(00000000003, 'Mitchie', 'Lamo', 'mitchie', 'password', 22, '\r\nmitshellapotter@gmail.com', '09282393885', 'ADMINISTRATOR', '645b2b997e229bfcf4e6a0e7fe765b15b506fd93'),
(00000000004, 'Levy', 'Cielo', 'cielolevy_', 'levylevs27', 21, '\r\nlevycielo4@gmail.com', '09271800604', 'ADMINISTRATOR', '17cda4943d451ab29ec4caa5579dda308cdce6e6'),
(00000000005, 'Mark Joseph', 'Corpuz', 'emphirador', 'shielamae', 24, 'markjosepharevalocorpuz@gmail.com', '09352978371', 'USER', '665e6fd2d762a397101a0c118888cfdaa30517ca'),
(00000000021, 'Sarah Jane ', 'Encinares', 'sarahjane', 'encinares', 29, 'sjencinares@gmail.com', '09522356098', 'ADMINISTRATOR', '322745b20ec3d80443401c0722de73de58f0492a'),
(00000000022, 'Jeron', 'Ricamata', 'jeron', 'ricamata', 27, 'jeronricamata@gmail.com', '09123456789', 'USER', '5b0719c5d562622cdd39f1f417ffdf1818756be5'),
(00000000023, 'Patima', 'Rogelio', 'patima', 'rogelio', 29, 'patimarogelio@gmail.com', '12345678901', 'ADMINISTRATOR', '3682aa541bc2f0e57f20167240c87176f7e9396d'),
(00000000024, 'Delfin', 'Pernia', 'delfin', 'pernia', 44, 'jayrbpc@gmail.com', '090909090909', 'ADMINISTRATOR', '781280bdb04d3d98fb863d47747df2b2fd0a3b3d'),
(00000000025, 'Lizel', 'Pablo', 'lizel', 'pablo', 29, 'lizelPablo@gmail.com', '09896732764', 'USER', '9a5aaac0509808e86c8cfb7c897a1ae8a6752df8');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `components`
--
ALTER TABLE `components`
  ADD PRIMARY KEY (`component_id`),
  ADD KEY `Components_Make_FK` (`production_id`),
  ADD KEY `Components_Materials_FK` (`material_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `make`
--
ALTER TABLE `make`
  ADD PRIMARY KEY (`production_id`),
  ADD KEY `make_product_fk` (`product_id`);

--
-- Indexes for table `materials`
--
ALTER TABLE `materials`
  ADD PRIMARY KEY (`material_id`),
  ADD KEY `fk_materials_supplier` (`supplier_id`);

--
-- Indexes for table `production_log`
--
ALTER TABLE `production_log`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `Log_Production_FK` (`production_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`sales_id`),
  ADD KEY `fk_user_id` (`user_id`),
  ADD KEY `fk_customer_id` (`customer_id`);

--
-- Indexes for table `sales_details`
--
ALTER TABLE `sales_details`
  ADD PRIMARY KEY (`sale_details_id`),
  ADD KEY `fk_products_id` (`product_id`),
  ADD KEY `fk_sales_id` (`sales_id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`supplier_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `customer_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12214;

--
-- AUTO_INCREMENT for table `make`
--
ALTER TABLE `make`
  MODIFY `production_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `materials`
--
ALTER TABLE `materials`
  MODIFY `material_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=300015;

--
-- AUTO_INCREMENT for table `production_log`
--
ALTER TABLE `production_log`
  MODIFY `log_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40008;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `sales_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100319;

--
-- AUTO_INCREMENT for table `sales_details`
--
ALTER TABLE `sales_details`
  MODIFY `sale_details_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11400;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `supplier_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3432435;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `components`
--
ALTER TABLE `components`
  ADD CONSTRAINT `Components_Make_FK` FOREIGN KEY (`production_id`) REFERENCES `make` (`production_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Components_Materials_FK` FOREIGN KEY (`material_id`) REFERENCES `materials` (`material_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `make`
--
ALTER TABLE `make`
  ADD CONSTRAINT `make_product_fk` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `materials`
--
ALTER TABLE `materials`
  ADD CONSTRAINT `fk_materials_supplier` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`supplier_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `production_log`
--
ALTER TABLE `production_log`
  ADD CONSTRAINT `Log_Production_FK` FOREIGN KEY (`production_id`) REFERENCES `make` (`production_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `fk_customer_id` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_user_id` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sales_details`
--
ALTER TABLE `sales_details`
  ADD CONSTRAINT `fk_products_id` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_sales_id` FOREIGN KEY (`sales_id`) REFERENCES `sales` (`sales_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
