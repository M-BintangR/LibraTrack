-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.30 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for libra_track
DROP DATABASE IF EXISTS `libra_track`;
CREATE DATABASE IF NOT EXISTS `libra_track` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `libra_track`;

-- Dumping structure for table libra_track.books
DROP TABLE IF EXISTS `books`;
CREATE TABLE IF NOT EXISTS `books` (
  `id_book` int NOT NULL AUTO_INCREMENT,
  `title` varchar(50) DEFAULT NULL,
  `genre` varchar(50) DEFAULT NULL,
  `stok` int DEFAULT NULL,
  `synopsis` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `author` varchar(50) DEFAULT NULL,
  `publisher` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_book`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table libra_track.books: ~1 rows (approximately)
REPLACE INTO `books` (`id_book`, `title`, `genre`, `stok`, `synopsis`, `author`, `publisher`) VALUES
	(1, 'Attack On Titan', 'Action', 2, 'Seorang anak bernama Eren, yang bisa merubah titan', 'Hajime', 'Wit Studio');

-- Dumping structure for table libra_track.rent_books
DROP TABLE IF EXISTS `rent_books`;
CREATE TABLE IF NOT EXISTS `rent_books` (
  `id_rent_book` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL DEFAULT '0',
  `book_id` int NOT NULL DEFAULT '0',
  `date_rent` datetime DEFAULT NULL,
  `date_finish` date DEFAULT NULL,
  `status_rent` enum('FINISH','RENT') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'RENT',
  `status_admin` enum('RETURNED','NONE') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'NONE',
  PRIMARY KEY (`id_rent_book`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table libra_track.rent_books: ~4 rows (approximately)
REPLACE INTO `rent_books` (`id_rent_book`, `user_id`, `book_id`, `date_rent`, `date_finish`, `status_rent`, `status_admin`) VALUES
	(1, 1, 1, '2025-02-01 23:02:22', '2022-04-01', 'RENT', 'NONE'),
	(2, 3, 1, '2025-02-02 03:29:25', '2022-01-02', 'RENT', 'NONE'),
	(3, 2, 1, '2025-02-02 07:47:49', '2022-02-11', 'FINISH', 'RETURNED'),
	(4, 2, 1, '2025-02-02 07:51:42', '2022-02-05', 'FINISH', 'RETURNED');

-- Dumping structure for table libra_track.users
DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `role` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `address` text,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table libra_track.users: ~3 rows (approximately)
REPLACE INTO `users` (`id_user`, `name`, `role`, `password`, `email`, `city`, `address`) VALUES
	(1, 'admin', 'admin', 'admin123', 'admin@gmail.com', 'Palopo', 'Jl Raya Besar Palopo'),
	(2, 'pengguna', 'user', 'user123', 'user@gmail.com', 'Makassar', 'Jl Raya Makassar'),
	(3, 'Muhammad Bintang', 'user', 'bintang123', 'muhbintang650@gmail.com', 'Makassar', 'Jl Perintis Kemerdekaan Km 19');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
