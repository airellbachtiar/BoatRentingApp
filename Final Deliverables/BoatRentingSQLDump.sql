-- phpMyAdmin SQL Dump
-- version 4.9.3
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Generation Time: Dec 23, 2021 at 04:31 PM
-- Server version: 5.7.26-log
-- PHP Version: 7.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbi450046`
--

-- --------------------------------------------------------

--
-- Table structure for table `coupon`
--

CREATE TABLE `coupon` (
  `CouponID` int(20) NOT NULL,
  `Code` varchar(50) NOT NULL,
  `Discount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `coupon`
--

INSERT INTO `coupon` (`CouponID`, `Code`, `Discount`) VALUES
(1, 'Discount5%', 5),
(2, 'Discount10%', 10),
(3, '15%Discount', 15);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustomerID` int(20) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Street` varchar(50) NOT NULL,
  `ZipCode` varchar(20) NOT NULL,
  `HouseNumber` int(20) NOT NULL,
  `City` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`CustomerID`, `Name`, `Username`, `Email`, `PhoneNumber`, `Password`, `Street`, `ZipCode`, `HouseNumber`, `City`) VALUES
(1, 'Airell Rasendriya Bachtiar', 'airell', 'airell.bachtiar@gmai', '2147483647', 'ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb', '', '', 0, ''),
(2, 'TestCustomer', 'customer', 'test@email.com', '0681117755', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8', '', '', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EmployeeID` int(20) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `PhoneNumber` varchar(20) DEFAULT NULL,
  `Password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EmployeeID`, `Name`, `Username`, `Email`, `PhoneNumber`, `Password`) VALUES
(1, 'a', 'a', 'a.a@a.a', '', 'ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb'),
(2, 'Test User', 'test', 'test@email.com', '', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8');

-- --------------------------------------------------------

--
-- Table structure for table `exclusivecoupon`
--

CREATE TABLE `exclusivecoupon` (
  `CouponID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `IsRedeemed` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `exclusivecoupon`
--

INSERT INTO `exclusivecoupon` (`CouponID`, `CustomerID`, `IsRedeemed`) VALUES
(3, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `inventoryboat`
--

CREATE TABLE `inventoryboat` (
  `ItemID` int(20) NOT NULL,
  `InventoryBoatID` int(20) NOT NULL,
  `Capacity` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `inventoryboat`
--

INSERT INTO `inventoryboat` (`ItemID`, `InventoryBoatID`, `Capacity`) VALUES
(1, 1, 0),
(1, 2, 2),
(1, 3, 2),
(1, 4, 2),
(1, 5, 2),
(1, 6, 2),
(1, 7, 2),
(1, 8, 2),
(1, 9, 2),
(1, 10, 2);

-- --------------------------------------------------------

--
-- Table structure for table `inventoryitem`
--

CREATE TABLE `inventoryitem` (
  `ItemID` int(20) NOT NULL,
  `InventoryItemID` int(20) NOT NULL,
  `Status` varchar(20) NOT NULL,
  `IsAvailable` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `inventoryitem`
--

INSERT INTO `inventoryitem` (`ItemID`, `InventoryItemID`, `Status`, `IsAvailable`) VALUES
(1, 1, 'Rented', 0),
(1, 2, 'On_Maintenance', 0),
(1, 3, 'Rented', 0),
(1, 4, 'Available', 1),
(1, 5, 'Available', 1),
(1, 6, 'Available', 1),
(1, 7, 'Available', 1),
(1, 8, 'Available', 1),
(1, 9, 'Available', 1),
(1, 10, 'Available', 1),
(8, 11, 'Available', 1),
(8, 12, 'Available', 1),
(8, 13, 'Available', 1),
(8, 14, 'Available', 1),
(8, 15, 'Available', 1),
(8, 16, 'Available', 1),
(8, 17, 'Available', 1),
(8, 18, 'Rented', 0);

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `ItemID` int(20) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Cost` double DEFAULT NULL,
  `Deposit` double DEFAULT NULL,
  `Description` text,
  `IsBoat` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`ItemID`, `Name`, `Cost`, `Deposit`, `Description`, `IsBoat`) VALUES
(1, 'Kayak', 1, 50, '1 peddle included', 1),
(2, 'Water Container', 2.5, 0, 'Capacity of 5 litres', 0),
(3, 'Canoe', 20, 50, '2 peddles included', 1),
(4, 'Sailboat Laser', 74, 800, '', 1),
(5, 'Sailboat Valk', 115, 2500, '', 1),
(6, 'Life Jacket', 0, 25, '', 0),
(7, 'Cool Box', 2.5, 0, 'Capacity of 25 litres', 0),
(8, 'Navigation Device', 5, 50, '', 0),
(9, 'Spare Peddle', 7.5, 25, '', 0),
(10, 'Tent', 4.5, 100, '', 0),
(11, 'Electric Furnace', 2.15, 0, '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `limitedcoupon`
--

CREATE TABLE `limitedcoupon` (
  `CouponID` int(20) NOT NULL,
  `TotalUses` int(20) NOT NULL,
  `RemainingUses` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `limitedcoupon`
--

INSERT INTO `limitedcoupon` (`CouponID`, `TotalUses`, `RemainingUses`) VALUES
(1, 10, 9);

-- --------------------------------------------------------

--
-- Table structure for table `maintenance`
--

CREATE TABLE `maintenance` (
  `InventoryItemID` int(20) NOT NULL,
  `MaintenanceID` int(20) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `maintenance`
--

INSERT INTO `maintenance` (`InventoryItemID`, `MaintenanceID`, `StartDate`, `EndDate`) VALUES
(2, 4, '2021-12-19', '2021-12-20');

-- --------------------------------------------------------

--
-- Table structure for table `renteditem`
--

CREATE TABLE `renteditem` (
  `ReferenceNumber` int(20) NOT NULL,
  `InventoryItemID` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `renteeaddress`
--

CREATE TABLE `renteeaddress` (
  `ReferenceNumber` int(20) NOT NULL,
  `Street` varchar(50) NOT NULL,
  `Zipcode` varchar(20) NOT NULL,
  `HouseNumber` int(20) NOT NULL,
  `City` varchar(50) NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `ReferenceNumber` int(20) NOT NULL,
  `CustomerID` int(20) NOT NULL,
  `Location` varchar(100) NOT NULL,
  `DateCreated` date NOT NULL,
  `StartDate` date NOT NULL,
  `Duration` int(10) NOT NULL,
  `CouponID` int(20) NOT NULL,
  `DamagePrice` double NOT NULL,
  `FinalPrice` double NOT NULL,
  `Status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `timecoupon`
--

CREATE TABLE `timecoupon` (
  `CouponID` int(20) NOT NULL,
  `EndDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `timecoupon`
--

INSERT INTO `timecoupon` (`CouponID`, `EndDate`) VALUES
(2, '2021-12-22');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `coupon`
--
ALTER TABLE `coupon`
  ADD PRIMARY KEY (`CouponID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmployeeID`);

--
-- Indexes for table `exclusivecoupon`
--
ALTER TABLE `exclusivecoupon`
  ADD KEY `exclusivecoupon_couponID` (`CouponID`);

--
-- Indexes for table `inventoryboat`
--
ALTER TABLE `inventoryboat`
  ADD PRIMARY KEY (`InventoryBoatID`),
  ADD KEY `inventoryboat_ItemID` (`ItemID`);

--
-- Indexes for table `inventoryitem`
--
ALTER TABLE `inventoryitem`
  ADD PRIMARY KEY (`InventoryItemID`),
  ADD KEY `inventoryitem_ItemID` (`ItemID`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `limitedcoupon`
--
ALTER TABLE `limitedcoupon`
  ADD KEY `limitedcoupon_couponID` (`CouponID`);

--
-- Indexes for table `maintenance`
--
ALTER TABLE `maintenance`
  ADD PRIMARY KEY (`MaintenanceID`),
  ADD KEY `maintenance_InventoryItemID` (`InventoryItemID`);

--
-- Indexes for table `renteditem`
--
ALTER TABLE `renteditem`
  ADD KEY `renteditem_ReferenceNumber` (`ReferenceNumber`),
  ADD KEY `renteditem_InventoryItemD` (`InventoryItemID`);

--
-- Indexes for table `renteeaddress`
--
ALTER TABLE `renteeaddress`
  ADD KEY `renteeaddress_ReferenceNumber` (`ReferenceNumber`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`ReferenceNumber`);

--
-- Indexes for table `timecoupon`
--
ALTER TABLE `timecoupon`
  ADD KEY `timecoupon_couponID` (`CouponID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `exclusivecoupon`
--
ALTER TABLE `exclusivecoupon`
  ADD CONSTRAINT `exclusivecoupon_couponID` FOREIGN KEY (`CouponID`) REFERENCES `coupon` (`CouponID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `inventoryboat`
--
ALTER TABLE `inventoryboat`
  ADD CONSTRAINT `inventoryboat_InventoryItemID` FOREIGN KEY (`InventoryBoatID`) REFERENCES `inventoryitem` (`InventoryItemID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `inventoryboat_ItemID` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `inventoryitem`
--
ALTER TABLE `inventoryitem`
  ADD CONSTRAINT `inventoryitem_ItemID` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `limitedcoupon`
--
ALTER TABLE `limitedcoupon`
  ADD CONSTRAINT `limitedcoupon_couponID` FOREIGN KEY (`CouponID`) REFERENCES `coupon` (`CouponID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `maintenance`
--
ALTER TABLE `maintenance`
  ADD CONSTRAINT `maintenance_InventoryItemID` FOREIGN KEY (`InventoryItemID`) REFERENCES `inventoryitem` (`InventoryItemID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `renteditem`
--
ALTER TABLE `renteditem`
  ADD CONSTRAINT `renteditem_InventoryItemD` FOREIGN KEY (`InventoryItemID`) REFERENCES `inventoryitem` (`InventoryItemID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `renteditem_ReferenceNumber` FOREIGN KEY (`ReferenceNumber`) REFERENCES `reservation` (`ReferenceNumber`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `renteeaddress`
--
ALTER TABLE `renteeaddress`
  ADD CONSTRAINT `renteeaddress_ReferenceNumber` FOREIGN KEY (`ReferenceNumber`) REFERENCES `reservation` (`ReferenceNumber`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `timecoupon`
--
ALTER TABLE `timecoupon`
  ADD CONSTRAINT `timecoupon_couponID` FOREIGN KEY (`CouponID`) REFERENCES `coupon` (`CouponID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
