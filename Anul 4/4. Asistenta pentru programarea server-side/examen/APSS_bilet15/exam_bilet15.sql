-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2023 at 09:36 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `exam_bilet15`
--

-- --------------------------------------------------------

--
-- Table structure for table `vehicles`
--

CREATE TABLE `vehicles` (
  `id` int(10) NOT NULL,
  `name` text NOT NULL,
  `type` text NOT NULL,
  `capacity` float NOT NULL,
  `year` year(4) NOT NULL,
  `status` tinyint(1) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vehicles`
--

INSERT INTO `vehicles` (`id`, `name`, `type`, `capacity`, `year`, `status`, `created_at`, `updated_at`) VALUES
(5, 'Swift', 'Sedan', 5, '2020', 1, '2023-12-26 07:02:34', '2023-12-26 07:02:34'),
(6, 'Explorer', 'SUV', 7, '2019', 0, '2023-12-26 07:03:03', '2023-12-26 07:03:03'),
(7, 'Civic', 'Sedan', 5, '2021', 0, '2023-12-26 07:03:28', '2023-12-26 07:03:28'),
(8, 'Privus', 'Hybrid', 4, '2022', 1, '2023-12-26 07:03:45', '2023-12-26 07:03:45'),
(9, 'Model S', 'Electric', 4, '2018', 1, '2023-12-26 07:04:04', '2023-12-26 07:04:04'),
(10, 'Transit', 'Van', 6, '2017', 1, '2023-12-26 07:04:40', '2023-12-26 07:04:40'),
(11, 'Name1', 'Type1', 6, '2023', 0, '2023-12-26 07:05:26', '2023-12-26 07:05:26');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `vehicles`
--
ALTER TABLE `vehicles`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `vehicles`
--
ALTER TABLE `vehicles`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
