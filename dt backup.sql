-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2022 at 05:08 PM
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
(2, 'STEELWORKS AUTO SUPPLY\r\n', 'levycielo@gmail.com', '09453849384'),
(3, 'GRANDFABRICATION STEEL', 'emma@gmail.com', '09340695843'),
(4, 'CONSTRUCTION SUPPLY A', 'harry@gmail.com', '0983567124');

-- --------------------------------------------------------

--
-- Table structure for table `make`
--

CREATE TABLE `make` (
  `production_id` int(100) NOT NULL,
  `material_id` int(100) NOT NULL,
  `product_name` varchar(100) NOT NULL,
  `quantity` int(100) NOT NULL,
  `production_deadline` datetime NOT NULL,
  `status` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `make`
--

INSERT INTO `make` (`production_id`, `material_id`, `product_name`, `quantity`, `production_deadline`, `status`) VALUES
(6, 123466, 'cot holder', 10, '2022-08-18 20:44:31', 'complete'),
(7, 123465, 'blind plug', 8, '2022-08-18 20:44:31', 'work in progress'),
(8, 123465, 'connector', 20, '2022-08-18 20:46:49', 'complete');

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
(123460, 'insert nuts', 266, 2, 73, 2, 2, 'IS', 1),
(123465, 'acetal plastic sheet', 100, 15, 45, 20, 2, '', 3),
(123466, 'cutter', 85, 22, 9, 6, 2, '', 5),
(123471, 'TRICYCLE', 20000, 0, 10, 0, 0, '', 3),
(123472, 'MULTICAB', 200000, 0, 10, 0, 0, '', 8),
(123473, 'TESTTO', 12, 0, 100, 0, 0, '', 8),
(123474, 'TESTING', 11, 0, 10, 0, 0, '', 8),
(123475, 'TESTING THE ITEM', 10, 9, 7, 0, 0, '', 5),
(123476, 'ITEM NUMBER 1', 1011, 22, 8, 0, 0, '', 8),
(123477, 'ITEM NUMBER 2', 23, 0, 0, 0, 0, '', 8);

-- --------------------------------------------------------

--
-- Table structure for table `production_log`
--

CREATE TABLE `production_log` (
  `log_id` int(100) NOT NULL,
  `product_id` int(100) NOT NULL,
  `date` date NOT NULL,
  `time` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `quantity` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `production_log`
--

INSERT INTO `production_log` (`log_id`, `product_id`, `date`, `time`, `quantity`) VALUES
(1, 2230, '2022-08-02', '2022-08-18 18:55:02', 2),
(2, 2228, '2022-08-17', '2022-08-18 18:56:05', 10),
(3, 2229, '2022-08-17', '2022-08-18 18:56:05', 8);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_id` int(100) NOT NULL,
  `production_id` int(100) NOT NULL,
  `product_name` varchar(100) NOT NULL,
  `part_number` varchar(100) NOT NULL,
  `product_size` varchar(100) NOT NULL,
  `unit_length` varchar(100) NOT NULL,
  `product_dimension` varchar(100) NOT NULL,
  `sale_price` int(100) NOT NULL,
  `average_cost` int(100) NOT NULL,
  `profit` int(100) NOT NULL,
  `value_in_stock` int(100) NOT NULL,
  `in_stock` int(100) NOT NULL,
  `expected` int(100) NOT NULL,
  `committed` int(100) NOT NULL,
  `ordered` int(100) NOT NULL,
  `missing` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_id`, `production_id`, `product_name`, `part_number`, `product_size`, `unit_length`, `product_dimension`, `sale_price`, `average_cost`, `profit`, `value_in_stock`, `in_stock`, `expected`, `committed`, `ordered`, `missing`) VALUES
(2228, 8, 'connector', '62_7289_3801', 'small', '25mm', '36x30x30', 145, 0, 0, 0, 0, 0, 0, 0, 0),
(2229, 6, 'cot holder', 'd4-13', 'small', 'n/a', 'n/a', 525, 0, 0, 0, 0, 0, 0, 0, 0),
(2230, 7, 'blind plug', 'n/a', 'medium', 'n/a', 'n/a', 3000, 0, 0, 0, 0, 0, 0, 0, 0),
(2231, 8, 'connector', '5', '5', '5', '5', 5, 5, 5, 5, 5, 5, 5, 5, 5);

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `sales_id` int(11) NOT NULL,
  `sales_date` date NOT NULL,
  `user_id` int(11) UNSIGNED ZEROFILL NOT NULL,
  `customer_id` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`sales_id`, `sales_date`, `user_id`, `customer_id`) VALUES
(1011, '2022-08-01', 00000000001, 3),
(1022, '2022-08-07', 00000000009, 4),
(1033, '2022-08-14', 00000000005, 2);

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
(1, 1011, 2230, 20, 1000),
(2, 1011, 2228, 10, 200),
(3, 1022, 2228, 100, 20000),
(4, 1022, 2229, 20, 1200),
(5, 1033, 2230, 1, 100),
(6, 1033, 2230, 3, 480);

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
(1, 'John', 'cezarjohn@gmail.com', '532300765'),
(3, 'm hardware', 'm@gmail.com', '09094240054'),
(5, 'n hardware', 'n@gmail.com', '09097870042'),
(8, 'GRAB A TRIKE', 'grab.a.trike@gmail.com', '09458493821');

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
(00000000002, 'Janine', 'Grimaldo', 'jajagrim', 'janine', 21, 'janine.grimaldo@gmail.com', '09459604859', 'USER', '31275a29615a5b000388e18470c0f55bceec1b76'),
(00000000003, 'Mitchie', 'Lamo', 'mitchie', 'password', 22, '\r\nmitshellapotter@gmail.com', '09282393885', 'ADMINISTRATOR', '645b2b997e229bfcf4e6a0e7fe765b15b506fd93'),
(00000000004, 'Levy', 'Cielo', 'cielolevy_', 'levylevs27', 21, '\r\nlevycielo4@gmail.com', '09271800604', 'ADMINISTRATOR', '17cda4943d451ab29ec4caa5579dda308cdce6e6'),
(00000000005, 'Mark Joseph', 'Corpuz', 'emphirador', 'shielamae', 24, 'markjosepharevalocorpuz@gmail.com', '09352978371', 'USER', '665e6fd2d762a397101a0c118888cfdaa30517ca'),
(00000000009, 'Collins', 'Mendoza', 'kolls', 'Mendoz@', 23, 'kolls.mendoza10@gmail.com', '09760251781', 'ADMINISTRATOR', '03187d4ba2d2415a545524d94140fcf4036965b3'),
(00000000018, 'Levy', 'Cielo', 'levs', '123', 21, 'levylevs@gmail.com', '09434950392', 'USER', '8ee26c1576907ca9c703e7b5d1f4d251622594da'),
(00000000019, 'm', 'm', 'mm', 'mm', 21, 'aa@gmail.com', '09065410819', 'ADMINISTRATOR', 'db266d0423a9de2500070377239fede89bee4521');

--
-- Indexes for dumped tables
--

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
  ADD KEY `fk_materials_id` (`material_id`);

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
  ADD KEY `fk_product_id_log` (`product_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`),
  ADD KEY `fk_production_id` (`production_id`);

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
  MODIFY `customer_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `make`
--
ALTER TABLE `make`
  MODIFY `production_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `materials`
--
ALTER TABLE `materials`
  MODIFY `material_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123478;

--
-- AUTO_INCREMENT for table `production_log`
--
ALTER TABLE `production_log`
  MODIFY `log_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2232;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `sales_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100223;

--
-- AUTO_INCREMENT for table `sales_details`
--
ALTER TABLE `sales_details`
  MODIFY `sale_details_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11222;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `supplier_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `make`
--
ALTER TABLE `make`
  ADD CONSTRAINT `fk_materials_id` FOREIGN KEY (`material_id`) REFERENCES `materials` (`material_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `materials`
--
ALTER TABLE `materials`
  ADD CONSTRAINT `fk_materials_supplier` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`supplier_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `production_log`
--
ALTER TABLE `production_log`
  ADD CONSTRAINT `fk_product_id_log` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `fk_production_id` FOREIGN KEY (`production_id`) REFERENCES `make` (`production_id`) ON DELETE CASCADE ON UPDATE CASCADE;

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
