-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th5 15, 2024 lúc 02:54 PM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `primemart`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `category`
--

CREATE TABLE `category` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `category`
--

INSERT INTO `category` (`id`, `name`, `created_at`, `updated_at`) VALUES
(1, 'Fruits and Vegetables', '2024-05-13 06:29:11', '2024-05-13 06:29:11'),
(2, 'Meat and Seafood', '2024-05-13 06:29:11', '2024-05-13 06:29:11'),
(3, 'Dairy and Eggs', '2024-05-13 06:29:11', '2024-05-13 06:29:11'),
(4, 'Bakery and Snacks', '2024-05-13 06:29:11', '2024-05-13 06:29:11'),
(5, 'Beverages', '2024-05-13 06:29:11', '2024-05-13 06:29:11'),
(6, 'Household and Cleaning', '2024-05-13 06:29:11', '2024-05-13 06:29:11'),
(7, 'Personal Care', '2024-05-13 06:29:11', '2024-05-13 06:29:11'),
(8, 'Baby and Mother Care', '2024-05-13 06:29:11', '2024-05-13 06:29:11'),
(9, 'Frozen Foods', '2024-05-13 06:29:11', '2024-05-13 06:29:11'),
(10, 'Dry Goods', '2024-05-13 06:29:11', '2024-05-13 06:29:11');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `collections`
--

CREATE TABLE `collections` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `section_id` int(11) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `updated_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `collections`
--

INSERT INTO `collections` (`id`, `name`, `section_id`, `created_at`, `updated_at`) VALUES
(1, 'Dole', 1, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(2, 'Green Giant', 1, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(3, 'Tyson', 2, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(4, 'Smithfield', 2, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(5, 'StarKist', 2, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(6, 'Perdue', 2, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(7, 'Horizon Organic', 3, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(8, 'Kraft', 3, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(9, 'Egglands Best', 3, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(10, 'Wonder Bread', 4, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(11, 'Pillsbury', 4, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(12, 'Lays', 4, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(13, 'Coca-Cola', 5, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(14, 'Tropicana', 5, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(15, 'Evian', 5, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(16, 'Clorox', 6, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(17, 'Dove', 6, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(18, 'Tide', 6, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(19, 'Head & Shoulders', 7, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(20, 'Dial', 7, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(21, 'Gerber', 8, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(22, 'Pampers', 8, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(23, 'Stouffers', 9, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(24, 'Ben & Jerrys', 9, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(25, 'Del Monte', 10, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(26, 'Barilla', 10, '2024-05-13 14:03:32', '2024-05-13 14:03:32'),
(27, 'Uncle Bens', 10, '2024-05-13 14:03:32', '2024-05-13 14:03:32');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `contact`
--

CREATE TABLE `contact` (
  `id` int(11) NOT NULL,
  `hoten` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `message_contact` varchar(255) NOT NULL,
  `id_user` int(11) DEFAULT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `updated_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `contact`
--

INSERT INTO `contact` (`id`, `hoten`, `email`, `message_contact`, `id_user`, `created_at`, `updated_at`) VALUES
(11, 'vo nhat hao', 'vonhathao641@gmail.com', 'hihi', 4, '2024-05-15 13:41:38', '2024-05-15 13:41:38'),
(12, 'vo nhat hao', 'vonhathao641@gmail.com', 'da hee\r\n', 4, '2024-05-15 13:06:44', '2024-05-15 13:06:44');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  `phone_number` varchar(20) NOT NULL,
  `email` varchar(150) NOT NULL,
  `address` varchar(200) NOT NULL,
  `note` varchar(255) DEFAULT NULL,
  `order_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `orders`
--

INSERT INTO `orders` (`id`, `fullname`, `phone_number`, `email`, `address`, `note`, `order_date`) VALUES
(182, 'Nguyễn Thành Nhân', '0123456789', 'nguyenthanhnhantg15@gmail.com', 'Ho Chi Minh', 'rtdcgfcggccv gh', '2024-05-15 11:23:59'),
(183, 'ADSdas', '0123456789', 'nguyenthanhnhantg1321@gmail.com', 'Ho Chi Minh', 'dsadasdsadas', '2024-05-15 12:00:54'),
(184, 'Nguyễn Thành Nhân', '0123456789', 'nguyenthanhnhantg15@gmail.com', 'Ho Chi Minh', 'dsadsa', '2024-05-15 12:42:46');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `order_details`
--

CREATE TABLE `order_details` (
  `id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `num` int(11) NOT NULL,
  `price` float NOT NULL,
  `status` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `order_details`
--

INSERT INTO `order_details` (`id`, `order_id`, `product_id`, `id_user`, `num`, `price`, `status`) VALUES
(196, 182, 6, 1, 1, 150000, 'Preparing the goods'),
(197, 182, 8, 1, 1, 30000, 'Preparing the goods'),
(198, 182, 18, 1, 1, 25000, 'Preparing the goods'),
(199, 182, 60, 1, 1, 19000, 'Preparing the goods'),
(200, 183, 39, 1, 1, 16000, 'Cancelled');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `title` varchar(200) NOT NULL,
  `price` float NOT NULL,
  `number` float NOT NULL,
  `thumbnail` varchar(500) NOT NULL,
  `thumbnail_1` varchar(500) NOT NULL,
  `thumbnail_2` varchar(500) NOT NULL,
  `thumbnail_3` varchar(500) NOT NULL,
  `thumbnail_4` varchar(500) NOT NULL,
  `thumbnail_5` varchar(500) NOT NULL,
  `content` longtext NOT NULL,
  `id_category` int(11) NOT NULL,
  `id_sanpham` int(11) NOT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `product`
--

INSERT INTO `product` (`id`, `title`, `price`, `number`, `thumbnail`, `thumbnail_1`, `thumbnail_2`, `thumbnail_3`, `thumbnail_4`, `thumbnail_5`, `content`, `id_category`, `id_sanpham`, `created_at`, `updated_at`) VALUES
(1, 'Coca-Cola', 10600, 100, 'uploads/cocacola.jpg', 'uploads/cocacola_2.jpg', 'uploads/cocacola_3.jpg', 'uploads/cocacola_4.jpg', 'uploads/cocacola_5.jpg', 'uploads/cocacola_6.jpg', 'Nước ngọt Coca-Cola.', 5, 13, '2024-05-13 14:16:07', '2024-05-13 17:38:24'),
(2, 'Pepsi', 10000, 100, 'uploads/pepsi.jpg', 'uploads/pepsi_1.jpg', 'uploads/pepsi_2.jpg', 'uploads/pepsi_3.jpg', 'uploads/pepsi_4.jpg', 'uploads/pepsi_5.jpg', 'Nước ngọt Pepsi.', 5, 13, '2024-05-13 14:07:52', '2024-05-13 17:48:26'),
(3, 'Fanta', 9500, 100, 'uploads/fanta.jpg', 'uploads/fanta_1.jpg', 'uploads/fanta_2.jpg', 'uploads/fanta.jpg', 'uploads/fanta_4.jpg', 'uploads/fanta_5.jpg', 'Nước ngọt Fanta.', 5, 13, '2024-05-13 14:07:52', '2024-05-13 17:33:30'),
(4, 'Mirinda', 9500, 100, 'uploads/mirinda.jpg', 'uploads/mirinda_2.jpg', 'uploads/mirinda_3.jpg', 'uploads/cocacola_4.jpg', 'uploads/mirinda_4.jpg', 'uploads/mirinda_5.jpg', 'Nước ngọt Mirinda.', 5, 13, '2024-05-13 14:07:52', '2024-05-13 17:32:34'),
(5, 'Sprite', 9200, 100, 'uploads/sprite.jpg', 'uploads/sprite_1.jpg', 'uploads/sprite_2.jpg', 'uploads/sprite_3.jpg', 'uploads/sprite_4.jpg', 'uploads/sprite_5.jpg', 'Nước ngọt Sprite.', 5, 13, '2024-05-13 14:07:52', '2024-05-13 17:55:39'),
(6, 'Apple', 150000, 50, 'uploads/apple.jpg', 'uploads/apple_1.jpg', 'uploads/apple_2.jpg', 'uploads/apple_3.jpg', 'uploads/apple_4.jpg', 'uploads/apple_5.jpg', 'Fresh apple.', 1, 1, '2024-05-13 14:32:30', '2024-05-15 08:12:45'),
(7, 'Banana', 40000, 70, 'uploads/banana.jpg', 'uploads/banana_1.jpg', 'uploads/banana_2.jpg', 'uploads/banana_3.jpg', 'uploads/banana_4.jpg', 'uploads/banana_5.jpg', 'Fresh banana.', 1, 1, '2024-05-13 14:32:30', '2024-05-13 18:09:02'),
(8, 'Orange', 30000, 40, 'uploads/orange.jpg', 'uploads/orange_1.jpg', 'uploads/orange_2.jpg', 'uploads/orange_3.jpg', 'uploads/orange_4.jpg', 'uploads/orange_5.jpg', 'Fresh orange.', 1, 1, '2024-05-13 14:32:30', '2024-05-13 18:30:16'),
(9, 'Grapes', 15000, 60, 'uploads/grapes_5.jpg', 'uploads/grapes_2.jpg', 'uploads/grapes_1.jpg', 'uploads/grapes_4.jpg', 'uploads/grapes_3.jpg', 'uploads/grapes.jpg', 'Fresh grapes.', 1, 1, '2024-05-13 14:32:30', '2024-05-13 18:22:24'),
(10, 'Watermelon', 20000, 30, 'uploads/watermelon.jpg', 'uploads/watermelon_1.jpg', 'uploads/watermelon_2.jpg', 'uploads/watermelon_3.jpg', 'uploads/watermelon_4.jpg', 'uploads/watermelon_5.jpg', 'Fresh watermelon.', 1, 1, '2024-05-13 14:32:30', '2024-05-13 18:26:32'),
(11, 'Carrot', 5000, 30, 'uploads/carrot.jpg', 'uploads/carrot_1.jpg', 'uploads/carrot_2.jpg', 'uploads/carrot_3.jpg', 'uploads/carrot_4.jpg', 'uploads/carrot_5.jpg', 'Fresh carrot.', 1, 2, '2024-05-13 14:47:05', '2024-05-15 09:30:04'),
(12, 'Broccoli', 7000, 25, 'uploads/broccoli.jpg', 'uploads/broccoli_1.jpg', 'uploads/broccoli_2.jpg', 'uploads/broccoli_3.jpg', 'uploads/broccoli_4.jpg', 'uploads/broccoli_5.jpg', 'Fresh broccoli.', 1, 1, '2024-05-13 14:47:05', '2024-05-13 18:34:40'),
(13, 'Tomato', 6000, 40, 'uploads/tomato_5.jpg', 'uploads/tomato_1.jpg', 'uploads/tomato.jpg', 'uploads/tomato_2.jpg', 'uploads/tomato_3.jpg', 'uploads/tomato_4.jpg', 'Fresh tomato.', 1, 2, '2024-05-13 14:47:05', '2024-05-15 09:24:05'),
(14, 'Cucumber', 4000, 35, 'uploads/cucumber.jpg', 'uploads/cucumber_1.jpg', 'uploads/cucumber_2.jpg', 'uploads/cucumber_3.jpg', 'uploads/cucumber_4.jpg', 'uploads/cucumber_5.jpg', 'Fresh cucumber.', 1, 2, '2024-05-13 14:47:05', '2024-05-15 09:54:04'),
(15, 'Bell Pepper', 8000, 30, 'uploads/bell_pepper.jpg', 'uploads/bell_pepper_1.jpg', 'uploads/bell_pepper_2.jpg', 'uploads/bell_pepper_3.jpg', 'uploads/bell_pepper_4.jpg', 'uploads/bell_pepper_5.jpg', 'Fresh bell pepper.', 1, 2, '2024-05-13 14:47:05', '2024-05-15 09:43:04'),
(17, 'Sirloin Steak', 28000, 25, 'uploads/sirloin_steak.jpg', 'uploads/sirloin_steak_1.jpg', 'uploads/sirloin_steak_2.jpg', 'uploads/sirloin_steak_3.jpg', 'uploads/sirloin_steak_4.jpg', 'uploads/sirloin_steak_5.jpg', 'Fresh sirloin steak.', 2, 3, '2024-05-13 14:47:05', '2024-05-13 19:12:15'),
(18, 'Ground Beef', 25000, 30, 'uploads/ground_beef.jpg', 'uploads/ground_beef_1.jpg', 'uploads/ground_beef_2.jpg', 'uploads/ground_beef_3.jpg', 'uploads/ground_beef_4.jpg', 'uploads/ground_beef_5.jpg', 'Fresh ground beef.', 2, 3, '2024-05-13 14:47:05', '2024-05-13 19:44:24'),
(19, 'Beef Ribs', 35000, 15, 'uploads/beef_ribs.jpg', 'uploads/beef_ribs_1.jpg', 'uploads/beef_ribs_2.jpg', 'uploads/beef_ribs_3.jpg', 'uploads/beef_ribs_4.jpg', 'uploads/beef_ribs_5.jpg', 'Fresh beef ribs.', 2, 3, '2024-05-13 14:47:05', '2024-05-13 19:41:32'),
(20, 'Beef Tenderloin', 40000, 10, 'uploads/beef_tenderloin.jpg', 'uploads/beef_tenderloin_1.jpg', 'uploads/beef_tenderloin_2.jpg', 'uploads/beef_tenderloin_3.jpg', 'uploads/beef_ribs_4.jpg', 'uploads/beef_tenderloin_5.jpg', 'Fresh beef tenderloin.', 2, 3, '2024-05-13 14:47:05', '2024-05-13 19:34:34'),
(22, 'Pork Belly', 18000, 25, 'uploads/pork_belly_3.jpg', 'uploads/pork_belly.jpg', 'uploads/pork_belly_1.jpg', 'uploads/pork_belly_2.jpg', 'uploads/pork_belly_4.jpg', 'uploads/pork_belly_5.jpg', 'Fresh pork belly.', 2, 4, '2024-05-13 14:47:05', '2024-05-13 19:34:38'),
(23, 'Pork Tenderloin', 22000, 20, 'uploads/pork_tenderloin_4.jpg', 'uploads/pork_tenderloin_5.jpg', 'uploads/pork_tenderloin_3.jpg', 'uploads/pork_tenderloin_1.jpg', 'uploads/pork_tenderloin_2.jpg', 'uploads/pork_tenderloin.jpg', 'Fresh pork tenderloin.', 2, 4, '2024-05-13 14:47:05', '2024-05-14 15:45:42'),
(30, 'Halibut', 32000, 20, 'uploads/halibut.jpg', 'uploads/halibut_1.jpg', 'uploads/halibut_2.jpg', 'uploads/halibut_3.jpg', 'uploads/halibut_4.jpg', 'uploads/halibut_5.jpg', 'Fresh halibut.', 2, 5, '2024-05-13 14:47:05', '2024-05-13 20:00:05'),
(33, 'Whole Chicken', 20000, 20, 'uploads/whole_chicken.jpg', 'uploads/whole_chicken_1.jpg', 'uploads/whole_chicken_2.jpg', 'uploads/whole_chicken_3.jpg', 'uploads/whole_chicken_4.jpg', 'uploads/whole_chicken_5.jpg', 'Fresh whole chicken.', 2, 6, '2024-05-13 14:47:05', '2024-05-13 20:52:16'),
(35, 'Turkey Breast', 30000, 20, 'uploads/turkey_breast.jpg', 'uploads/turkey_breast_1.jpg', 'uploads/turkey_breast_2.jpg', 'uploads/turkey_breast_3.jpg', 'uploads/turkey_breast_4.jpg', 'uploads/turkey_breast_5.jpg', 'Fresh turkey breast.', 2, 6, '2024-05-13 14:47:05', '2024-05-13 20:28:23'),
(36, 'Whole Milk', 15000, 40, 'uploads/whole_milk.jpg', 'uploads/whole_milk_1.jpg', 'uploads/whole_milk_2.jpg', 'uploads/whole_milk_3.jpg', 'uploads/whole_milk_4.jpg', 'uploads/whole_milk_5.jpg', 'Fresh whole milk.', 3, 7, '2024-05-13 15:07:52', '2024-05-13 20:55:24'),
(38, '2% Milk', 14000, 40, 'uploads/2_percent_milk.jpg', 'uploads/2_percent_milk_1.jpg', 'uploads/2_percent_milk_2.png', 'uploads/2_percent_milk_3.jpg', 'uploads/2_percent_milk_4.jpg', 'uploads/2_percent_milk_5.png', 'Fresh 2% milk.', 3, 7, '2024-05-13 15:07:52', '2024-05-13 20:31:29'),
(39, 'Almond Milk', 16000, 30, 'uploads/almond_milk.jpg', 'uploads/almond_milk_1.jpg', 'uploads/almond_milk_2.jpg', 'uploads/almond_milk_3.jpg', 'uploads/almond_milk_4.jpg', 'uploads/almond_milk_5.jpg', 'Fresh almond milk.', 3, 7, '2024-05-13 15:07:52', '2024-05-13 20:06:31'),
(41, 'Cheddar Cheese', 25000, 25, 'uploads/cheddar_cheese.jpg', 'uploads/cheddar_cheese_1.jpg', 'uploads/cheddar_cheese_2.jpg', 'uploads/cheddar_cheese_3.jpg', 'uploads/cheddar_cheese_4.jpg', 'uploads/cheddar_cheese_5.jpg', 'Fresh cheddar cheese.', 3, 8, '2024-05-13 15:07:52', '2024-05-13 20:36:34'),
(42, 'Mozzarella Cheese', 22000, 30, 'uploads/mozzarella_cheese.jpg', 'uploads/mozzarella_cheese_1.jpg', 'uploads/mozzarella_cheese_2.jpg', 'uploads/mozzarella_cheese_3.jpg', 'uploads/mozzarella_cheese_4.jpg', 'uploads/mozzarella_cheese_5.jpg', 'Fresh mozzarella cheese.', 3, 8, '2024-05-13 15:07:52', '2024-05-13 20:13:36'),
(44, 'Provolone Cheese', 26000, 25, 'uploads/provolone_cheese_1.jpg', 'uploads/provolone_cheese.jpg', 'uploads/provolone_cheese_2.jpg', 'uploads/provolone_cheese_3.jpg', 'uploads/provolone_cheese_4.jpg', 'uploads/provolone_cheese_5.jpg', 'Fresh provolone cheese.', 3, 8, '2024-05-13 15:07:52', '2024-05-13 20:02:44'),
(45, 'Parmesan Cheese', 30000, 20, 'uploads/parmesan_cheese.jpg', 'uploads/parmesan_cheese_1.jpg', 'uploads/parmesan_cheese_2.jpg', 'uploads/parmesan_cheese_3.jpg', 'uploads/parmesan_cheese_4.jpg', 'uploads/parmesan_cheese_5.jpg', 'Fresh parmesan cheese.', 3, 8, '2024-05-13 15:07:52', '2024-05-13 20:38:46'),
(47, 'Medium Eggs', 18000, 60, 'uploads/medium_eggs_4.jpg', 'uploads/medium_eggs_1.jpg', 'uploads/medium_eggs.jpg', 'uploads/medium_eggs_2.jpg', 'uploads/medium_eggs_3.jpg', 'uploads/medium_eggs_5.jpg', 'Fresh medium eggs.', 3, 9, '2024-05-13 15:07:52', '2024-05-13 20:21:54'),
(48, 'Organic Eggs', 25000, 40, 'uploads/organic_eggs_4.jpg', 'uploads/organic_eggs_1.jpg', 'uploads/organic_eggs.jpg', 'uploads/organic_eggs_3.jpg', 'uploads/organic_eggs_2.jpg', 'uploads/organic_eggs_5.jpg', 'Fresh organic eggs.', 3, 9, '2024-05-13 15:07:52', '2024-05-13 20:21:56'),
(55, 'Baguette', 16000, 25, 'uploads/baguette_1.jpg', 'uploads/baguette.jpg', 'uploads/baguette_2.jpg', 'uploads/baguette_4.jpg', 'uploads/baguette_3.jpg', 'uploads/baguette_5.jpg', 'Fresh baguette.', 4, 10, '2024-05-13 15:07:52', '2024-05-13 21:43:17'),
(57, 'Danish Pastry', 16000, 30, 'uploads/danish_pastry.jpg', 'uploads/danish_pastry_1.jpg', 'uploads/danish_pastry_2.jpg', 'uploads/danish_pastry_3.jpg', 'uploads/danish_pastry_4.jpg', 'uploads/danish_pastry_5.jpg', 'Fresh Danish pastry.', 4, 11, '2024-05-13 15:07:52', '2024-05-13 21:45:22'),
(59, 'Apple Turnovers', 18000, 30, 'uploads/apple_turnovers_1.jpg', 'uploads/apple_turnovers.jpg', 'uploads/apple_turnovers_2.jpg', 'uploads/apple_turnovers_3.jpg', 'uploads/apple_turnovers_4.jpg', 'uploads/apple_turnovers_5.jpg', 'Fresh apple turnovers.', 4, 11, '2024-05-13 15:07:52', '2024-05-14 16:50:10'),
(60, 'Pain au Chocolat', 19000, 35, 'uploads/pain_au_chocolat.jpg', 'uploads/pain_au_chocolat_1.jpg', 'uploads/pain_au_chocolat_2.jpg', 'uploads/pain_au_chocolat_3.jpg', 'uploads/pain_au_chocolat_4.jpg', 'uploads/pain_au_chocolat_5.jpg', 'Fresh pain au chocolat.', 4, 11, '2024-05-13 15:07:52', '2024-05-13 21:32:33'),
(61, 'Potato Chips', 10000, 40, 'uploads/potato_chips.jpg', 'uploads/potato_chips_1.jpg', 'uploads/potato_chips_2.jpg', 'uploads/potato_chips_3.jpg', 'uploads/potato_chips_4.jpg', 'uploads/potato_chips_5.jpg', 'Fresh potato chips.', 4, 12, '2024-05-13 15:07:52', '2024-05-13 21:49:34'),
(62, 'Tortilla Chips', 11000, 35, 'uploads/tortilla_chips.jpg', 'uploads/tortilla_chips_1.jpg', 'uploads/tortilla_chips_2.jpg', 'uploads/tortilla_chips_3.jpg', 'uploads/tortilla_chips_4.jpg', 'uploads/tortilla_chips_5.jpg', 'Fresh tortilla chips.', 4, 12, '2024-05-13 15:07:52', '2024-05-13 21:09:36'),
(64, 'Pita Chips', 13000, 25, 'uploads/pita_chips.jpg', 'uploads/pita_chips_1.jpg', 'uploads/pita_chips_2.jpg', 'uploads/pita_chips_3.jpg', 'uploads/pita_chips_4.jpg', 'uploads/pita_chips_5.jpg', 'Fresh pita chips.', 4, 12, '2024-05-13 15:07:52', '2024-05-13 21:53:39'),
(66, 'Orange Juice', 20000, 30, 'uploads/orange_juice_5.jpg', 'uploads/orange_juice.jpg', 'uploads/orange_juice_1.jpg', 'uploads/orange_juice_2.jpg', 'uploads/orange_juice_3.jpg', 'uploads/orange_juice_4.jpg', 'Fresh orange juice.', 5, 14, '2024-05-13 15:32:51', '2024-05-13 21:07:43'),
(67, 'Apple Juice', 18000, 35, 'uploads/apple_juice_4.jpg', 'uploads/apple_juice_1.jpg', 'uploads/apple_juice_2.jpg', 'uploads/apple_juice_3.jpg', 'uploads/apple_juice_1.jpg', 'uploads/apple_juice_5.jpg', 'Fresh apple juice.', 5, 14, '2024-05-13 15:32:51', '2024-05-14 16:14:17'),
(70, 'Pineapple Juice', 23000, 25, 'uploads/pineapple_juice_5.jpg', 'uploads/pineapple_juice.jpg', 'uploads/pineapple_juice_1.jpg', 'uploads/pineapple_juice_2.jpg', 'uploads/pineapple_juice_3.jpg', 'uploads/pineapple_juice_4.jpg', 'Fresh pineapple juice.', 5, 14, '2024-05-13 15:32:51', '2024-05-14 16:52:18'),
(72, 'Spring Water', 12000, 45, 'uploads/spring_water.jpg', 'uploads/spring_water_1.jpg', 'uploads/spring_water_2.jpg', 'uploads/spring_water_3.jpg', 'uploads/spring_water_4.jpg', 'uploads/spring_water_5.jpg', 'Fresh spring water.', 5, 15, '2024-05-13 15:32:51', '2024-05-13 21:51:53'),
(74, 'Sparkling Water', 13000, 45, 'uploads/sparkling_water_5.jpg', 'uploads/sparkling_water.jpg', 'uploads/sparkling_water_1.jpg', 'uploads/sparkling_water_2.jpg', 'uploads/sparkling_water_3.jpg', 'uploads/sparkling_water_4.jpg', 'Fresh sparkling water.', 5, 15, '2024-05-13 15:32:51', '2024-05-13 21:49:57'),
(75, 'Flavored Water', 14000, 40, 'uploads/flavored_water.jpg', 'uploads/flavored_water_1.jpg', 'uploads/flavored_water_2.jpg', 'uploads/flavored_water_3.jpg', 'uploads/flavored_water_4.jpg', 'uploads/flavored_water_5.jpg', 'Fresh flavored water.', 5, 15, '2024-05-13 15:32:51', '2024-05-13 21:45:59'),
(77, 'Disinfectant Spray', 22000, 25, 'uploads/disinfectant_spray_1.jpg', 'uploads/disinfectant_spray.jpg', 'uploads/disinfectant_spray_2.jpg', 'uploads/disinfectant_spray_3.jpg', 'uploads/disinfectant_spray_4.jpg', 'uploads/disinfectant_spray_5.jpg', 'Powerful disinfectant spray.', 6, 16, '2024-05-13 15:34:11', '2024-05-13 22:28:03'),
(78, 'Bleach', 18000, 35, 'uploads/bleach.jpg', 'uploads/bleach_1.jpg', 'uploads/bleach_2.jpg', 'uploads/bleach_3.jpg', 'uploads/bleach_4.jpg', 'uploads/bleach_5.jpg', 'Effective bleach for cleaning.', 6, 16, '2024-05-13 15:34:11', '2024-05-13 22:17:05'),
(79, 'Glass Cleaner', 16000, 40, 'uploads/glass_cleaner.jpg', 'uploads/glass_cleaner_1.jpg', 'uploads/glass_cleaner_2.jpg', 'uploads/glass_cleaner_3.jpg', 'uploads/glass_cleaner_4.jpg', 'uploads/glass_cleaner_5.jpg', 'Streak-free glass cleaner.', 6, 16, '2024-05-13 15:34:11', '2024-05-13 22:51:06'),
(81, 'Toilet Paper', 15000, 40, 'uploads/toilet_paper.jpg', 'uploads/toilet_paper_1.jpg', 'uploads/toilet_paper_2.jpg', 'uploads/toilet_paper_3.jpg', 'uploads/toilet_paper_4.jpg', 'uploads/toilet_paper_5.jpg', 'Soft toilet paper rolls.', 6, 17, '2024-05-13 15:34:11', '2024-05-13 22:33:24'),
(82, 'Hand Soap', 12000, 50, 'uploads/hand_soap.jpg', 'uploads/hand_soap_1.jpg', 'uploads/hand_soap_2.jpg', 'uploads/hand_soap_3.jpg', 'uploads/hand_soap_4.jpg', 'uploads/hand_soap_5.jpg', 'Gentle hand soap for daily use.', 6, 17, '2024-05-13 15:34:11', '2024-05-13 22:57:27'),
(83, 'Shower Gel', 18000, 35, 'uploads/shower_gel.jpg', 'uploads/shower_gel_1.jpg', 'uploads/shower_gel_2.jpg', 'uploads/shower_gel_3.jpg', 'uploads/shower_gel_4.jpg', 'uploads/shower_gel_5.jpg', 'Refreshing shower gel.', 6, 17, '2024-05-13 15:34:11', '2024-05-13 22:19:30'),
(84, 'Shampoo', 20000, 30, 'uploads/shampoo.jpg', 'uploads/shampoo_1.jpg', 'uploads/shampoo_2.jpg', 'uploads/shampoo_3.jpg', 'uploads/shampoo_4.jpg', 'uploads/shampoo_5.jpg', 'Nourishing shampoo for healthy hair.', 6, 17, '2024-05-13 15:34:11', '2024-05-13 22:29:32'),
(85, 'Conditioner', 22000, 25, 'uploads/conditioner.jpg', 'uploads/conditioner_1.jpg', 'uploads/conditioner_2.jpg', 'uploads/conditioner_3.jpg', 'uploads/conditioner_4.jpg', 'uploads/conditioner_5.jpg', 'Moisturizing conditioner for soft hair.', 6, 17, '2024-05-13 15:34:11', '2024-05-13 22:13:34'),
(87, 'Fabric Softener', 20000, 30, 'uploads/fabric_softener.jpg', 'uploads/fabric_softener_1.jpg', 'uploads/fabric_softener_2.jpg', 'uploads/fabric_softener_4.jpg', 'uploads/fabric_softener_5.jpg', 'uploads/fabric_softener.jpg', 'Gentle fabric softener.', 6, 18, '2024-05-13 15:38:21', '2024-05-13 22:48:38'),
(88, 'Stain Remover', 18000, 35, 'uploads/stain_remover.jpg', 'uploads/stain_remover_1.png', 'uploads/stain_remover_2.jpg', 'uploads/stain_remover_3.jpg', 'uploads/stain_remover_4.jpg', 'uploads/stain_remover_5.jpg', 'Effective stain remover.', 6, 18, '2024-05-13 15:38:21', '2024-05-13 22:17:41'),
(90, 'Laundry Bags', 12000, 50, 'uploads/laundry_bags.jpg', 'uploads/laundry_bags_1.jpg', 'uploads/laundry_bags_2.jpg', 'uploads/laundry_bags_3.jpg', 'uploads/laundry_bags_4.jpg', 'uploads/laundry_bags_5.jpg', 'Convenient laundry bags.', 6, 18, '2024-05-13 15:38:21', '2024-05-13 22:19:43'),
(91, 'Moisturizing Shampoo', 22000, 25, 'uploads/moisturizing_shampoo.jpg', 'uploads/moisturizing_shampoo_1.jpg', 'uploads/moisturizing_shampoo_2.jpg', 'uploads/moisturizing_shampoo_3.jpg', 'uploads/moisturizing_shampoo_4.jpg', 'uploads/moisturizing_shampoo_5.jpg', 'Hydrating shampoo for dry hair.', 7, 19, '2024-05-13 15:38:21', '2024-05-13 22:01:46'),
(94, 'Clarifying Shampoo', 21000, 30, 'uploads/clarifying_shampoo_3.jpg', 'uploads/clarifying_shampoo_1.jpg', 'uploads/clarifying_shampoo_2.jpg', 'uploads/clarifying_shampoo.jpg', 'uploads/clarifying_shampoo_4.jpg', 'uploads/clarifying_shampoo_5.jpg', 'Deep-cleansing shampoo.', 7, 19, '2024-05-13 15:38:21', '2024-05-14 16:47:25'),
(95, 'Anti-Dandruff Shampoo', 24000, 20, 'uploads/anti_dandruff_shampoo_1.jpg', 'uploads/anti_dandruff_shampoo.jpg', 'uploads/anti_dandruff_shampoo_2.jpg', 'uploads/anti_dandruff_shampoo_3.jpg', 'uploads/anti_dandruff_shampoo_4.jpg', 'uploads/anti_dandruff_shampoo_5.jpg', 'Shampoo for controlling dandruff.', 7, 19, '2024-05-13 15:38:21', '2024-05-14 16:45:27'),
(96, 'Bar Soap', 15000, 40, 'uploads/bar_soap_2.jpg', 'uploads/bar_soap_1.jpg', 'uploads/bar_soap_2.jpg', 'uploads/bar_soap_3.jpg', 'uploads/bar_soap_4.jpg', 'uploads/bar_soap_5.jpg', 'Traditional bar soap.', 7, 20, '2024-05-13 15:38:21', '2024-05-14 16:10:29'),
(97, 'Liquid Hand Soap', 12000, 50, 'uploads/liquid_hand_soap.jpg', 'uploads/liquid_hand_soap_1.jpg', 'uploads/liquid_hand_soap_2.jpg', 'uploads/liquid_hand_soap_3.jpg', 'uploads/liquid_hand_soap_4.jpg', 'uploads/liquid_hand_soap_5.jpg', 'Convenient liquid hand soap.', 7, 20, '2024-05-13 15:38:21', '2024-05-13 22:07:56'),
(98, 'Body Wash', 18000, 35, 'uploads/body_wash.jpg', 'uploads/body_wash_1.jpg', 'uploads/body_wash_2.jpg', 'uploads/body_wash_3.jpg', 'uploads/body_wash_4.jpg', 'uploads/body_wash_5.jpg', 'Refreshing body wash.', 7, 20, '2024-05-13 15:38:21', '2024-05-13 22:14:57'),
(99, 'Antibacterial Soap', 16000, 40, 'uploads/antibacterial_soap.jpg', 'uploads/antibacterial_soap_1.jpg', 'uploads/antibacterial_soap_2.jpg', 'uploads/antibacterial_soap_3.jpg', 'uploads/antibacterial_soap_4.jpg', 'uploads/antibacterial_soap_5.jpg', 'Antibacterial bar soap.', 7, 20, '2024-05-13 15:38:21', '2024-05-13 22:35:58'),
(102, 'Baby Puree', 22000, 25, 'uploads/baby_puree.jpg', 'uploads/baby_puree_1.jpg', 'uploads/baby_puree_2.jpg', 'uploads/baby_puree_3.jpg', 'uploads/baby_puree_4.jpg', 'uploads/baby_puree_5.jpg', 'Delicious baby puree.', 8, 21, '2024-05-13 15:38:21', '2024-05-13 23:46:02'),
(103, 'Baby Snacks', 18000, 35, 'uploads/baby_snacks.jpg', 'uploads/baby_snacks_1.jpg', 'uploads/baby_snacks_2.jpg', 'uploads/baby_snacks_3.jpg', 'uploads/baby_snacks_4.jpg', 'uploads/baby_snacks_5.jpg', 'Healthy snacks for babies.', 8, 21, '2024-05-13 15:38:21', '2024-05-13 23:21:05'),
(104, 'Baby Biscuits', 20000, 30, 'uploads/baby_biscuits.jpg', 'uploads/baby_biscuits_1.jpg', 'uploads/baby_biscuits_2.jpg', 'uploads/baby_biscuits_3.jpg', 'uploads/baby_biscuits_4.jpg', 'uploads/baby_biscuits_5.jpg', 'Crunchy baby biscuits.', 8, 21, '2024-05-13 15:38:21', '2024-05-13 23:58:08'),
(106, 'Newborn Diapers', 35000, 15, 'uploads/newborn_diapers.jpg', 'uploads/newborn_diapers_1.jpg', 'uploads/newborn_diapers_2.jpg', 'uploads/newborn_diapers_3.jpg', 'uploads/newborn_diapers_4.jpg', 'uploads/newborn_diapers_5.jpg', 'Soft diapers for newborns.', 8, 22, '2024-05-13 15:38:21', '2024-05-13 23:44:20'),
(107, 'Infant Diapers', 32000, 20, 'uploads/infant_diapers.jpg', 'uploads/infant_diapers_1.jpg', 'uploads/infant_diapers_2.jpg', 'uploads/infant_diapers_3.jpg', 'uploads/infant_diapers_4.jpg', 'uploads/infant_diapers_5.jpg', 'Comfortable diapers for infants.', 8, 22, '2024-05-13 15:38:21', '2024-05-13 23:54:22'),
(110, 'Swim Diapers', 25000, 35, 'uploads/swim_diapers.jpg', 'uploads/swim_diapers_1.jpg', 'uploads/swim_diapers_2.jpg', 'uploads/swim_diapers_3.jpg', 'uploads/swim_diapers_4.jpg', 'uploads/swim_diapers_5.jpg', 'Disposable swim diapers.', 8, 22, '2024-05-13 15:38:21', '2024-05-13 23:44:24'),
(116, 'Vanilla Ice Cream', 25000, 20, 'uploads/vanilla_ice_cream.jpg', 'uploads/vanilla_ice_cream_1.jpg', 'uploads/vanilla_ice_cream_2.jpg', 'uploads/vanilla_ice_cream_3.jpg', 'uploads/vanilla_ice_cream_4.jpg', 'uploads/vanilla_ice_cream_5.jpg', 'Creamy vanilla ice cream.', 9, 24, '2024-05-13 15:45:59', '2024-05-13 23:31:39'),
(117, 'Chocolate Ice Cream', 27000, 25, 'uploads/chocolate_ice_cream.jpg', 'uploads/chocolate_ice_cream_1.jpg', 'uploads/chocolate_ice_cream_2.jpg', 'uploads/chocolate_ice_cream_3.jpg', 'uploads/chocolate_ice_cream_4.jpg', 'uploads/chocolate_ice_cream_5.jpg', 'Rich chocolate ice cream.', 9, 24, '2024-05-13 15:45:59', '2024-05-13 23:08:41'),
(118, 'Strawberry Ice Cream', 28000, 25, 'uploads/strawberry_ice_cream.jpg', 'uploads/strawberry_ice_cream_1.jpg', 'uploads/strawberry_ice_cream_2.jpg', 'uploads/strawberry_ice_cream_3.jpg', 'uploads/strawberry_ice_cream_4.jpg', 'uploads/strawberry_ice_cream_5.jpg', 'Refreshing strawberry ice cream.', 9, 24, '2024-05-13 15:45:59', '2024-05-13 23:55:42'),
(121, 'Canned Tuna', 18000, 40, 'uploads/canned_tuna.jpg', 'uploads/canned_tuna_1.jpg', 'uploads/canned_tuna_2.jpg', 'uploads/canned_tuna_3.jpg', 'uploads/canned_tuna_4.jpg', 'uploads/canned_tuna_5.jpg', 'High-quality canned tuna.', 10, 25, '2024-05-13 15:45:59', '2024-05-13 23:26:50'),
(126, 'Spaghetti', 12000, 70, 'uploads/spaghetti.jpg', 'uploads/spaghetti_1.jpg', 'uploads/spaghetti_2.jpg', 'uploads/spaghetti_3.jpg', 'uploads/spaghetti_4.jpg', 'uploads/spaghetti_5.jpg', 'Traditional spaghetti pasta.', 10, 26, '2024-05-13 15:45:59', '2024-05-14 00:50:01'),
(127, 'Fettuccine', 14000, 65, 'uploads/fettuccine.jpg', 'uploads/fettuccine_1.jpg', 'uploads/fettuccine_2.jpg', 'uploads/fettuccine_3.png', 'uploads/fettuccine_4.jpg', 'uploads/fettuccine_5.jpg', 'Classic fettuccine pasta.', 10, 26, '2024-05-13 15:45:59', '2024-05-14 00:18:04'),
(128, 'Penne', 13000, 75, 'uploads/penne.jpg', 'uploads/penne_1.jpg', 'uploads/penne_2.jpg', 'uploads/penne_3.jpg', 'uploads/penne_4.jpg', 'uploads/penne_5.jpg', 'Versatile penne pasta.', 10, 26, '2024-05-13 15:45:59', '2024-05-14 00:52:06'),
(129, 'Rotini', 12000, 70, 'uploads/rotini.png', 'uploads/rotini_1.jpg', 'uploads/rotini_2.jpg', 'uploads/rotini_3.jpg', 'uploads/rotini_4.jpg', 'uploads/rotini_5.jpg', 'Spiral-shaped rotini pasta.', 10, 26, '2024-05-13 15:45:59', '2024-05-14 00:36:08'),
(131, 'Jasmine Rice', 25000, 80, 'uploads/jasmine_rice.jpg', 'uploads/jasmine_rice_1.jpg', 'uploads/jasmine_rice_2.jpg', 'uploads/jasmine_rice_3.jpg', 'uploads/jasmine_rice_4.jpg', 'uploads/jasmine_rice_5.jpg', 'Fragrant jasmine rice.', 10, 27, '2024-05-13 15:45:59', '2024-05-14 00:21:11'),
(132, 'Basmati Rice', 27000, 75, 'uploads/basmati_rice.jpg', 'uploads/basmati_rice_1.jpg', 'uploads/basmati_rice_2.jpg', 'uploads/basmati_rice_3.jpg', 'uploads/basmati_rice_4.jpg', 'uploads/basmati_rice_5.jpg', 'Aromatic basmati rice.', 10, 27, '2024-05-13 15:45:59', '2024-05-14 00:29:12'),
(133, 'Brown Rice', 28000, 70, 'uploads/brown_rice.jpg', 'uploads/brown_rice_1.jpg', 'uploads/brown_rice_2.jpg', 'uploads/brown_rice_3.jpg', 'uploads/brown_rice_4.jpg', 'uploads/brown_rice_5.jpg', 'Healthy brown rice.', 10, 27, '2024-05-13 15:45:59', '2024-05-14 00:37:13'),
(134, 'Arborio Rice', 30000, 65, 'uploads/arborio_rice.jpg', 'uploads/arborio_rice_1.jpg', 'uploads/arborio_rice_2.jpg', 'uploads/arborio_rice_3.jpg', 'uploads/arborio_rice_5.jpg', 'uploads/arborio_rice_4.jpg', 'Creamy arborio rice.', 10, 27, '2024-05-13 15:45:59', '2024-05-14 00:40:14');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `user`
--

CREATE TABLE `user` (
  `id_user` int(11) NOT NULL,
  `fullname` varchar(200) NOT NULL,
  `tendangnhap` varchar(200) NOT NULL,
  `email` varchar(100) NOT NULL,
  `diachi` varchar(200) NOT NULL,
  `matkhau` varchar(100) NOT NULL,
  `dienthoai` int(20) NOT NULL,
  `role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `user`
--

INSERT INTO `user` (`id_user`, `fullname`, `tendangnhap`, `email`, `diachi`, `matkhau`, `dienthoai`, `role`) VALUES
(1, 'Chu Chu', 'Admin_Chu', 'admin@gmail.com', 'TP.HCM', '9999', 123456789, 'admin'),
(2, 'User', 'user_luxury', 'userluxury@gmail.com', 'TPHCM', '9999', 123452289, 'user'),
(3, 'Thanh Nhan', 'admin', 'admin@gmail.com', 'TP.HCM', 'admin', 123456789, 'admin'),
(4, 'Nhat Hao', 'nhathao', 'nhathao@gmail.com', 'TP.HCM', '123456', 123456789, 'user');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `collections`
--
ALTER TABLE `collections`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `contact`
--
ALTER TABLE `contact`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_ibfk_1` (`id_user`);

--
-- Chỉ mục cho bảng `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `order_details`
--
ALTER TABLE `order_details`
  ADD PRIMARY KEY (`id`),
  ADD KEY `order_details_ibfk_1` (`product_id`),
  ADD KEY `order_details_ibfk_2` (`order_id`),
  ADD KEY `order_details_ibfk_3` (`id_user`);

--
-- Chỉ mục cho bảng `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_category` (`id_category`),
  ADD KEY `id_sanpham` (`id_sanpham`);

--
-- Chỉ mục cho bảng `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `category`
--
ALTER TABLE `category`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT cho bảng `collections`
--
ALTER TABLE `collections`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- AUTO_INCREMENT cho bảng `contact`
--
ALTER TABLE `contact`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT cho bảng `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=185;

--
-- AUTO_INCREMENT cho bảng `order_details`
--
ALTER TABLE `order_details`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=202;

--
-- AUTO_INCREMENT cho bảng `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=136;

--
-- AUTO_INCREMENT cho bảng `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `contact`
--
ALTER TABLE `contact`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `user` (`id_user`);

--
-- Các ràng buộc cho bảng `order_details`
--
ALTER TABLE `order_details`
  ADD CONSTRAINT `order_details_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `order_details_ibfk_2` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`),
  ADD CONSTRAINT `order_details_ibfk_3` FOREIGN KEY (`id_user`) REFERENCES `user` (`id_user`);

--
-- Các ràng buộc cho bảng `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`id_category`) REFERENCES `category` (`id`),
  ADD CONSTRAINT `sanpham_ibfk_1` FOREIGN KEY (`id_sanpham`) REFERENCES `collections` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
