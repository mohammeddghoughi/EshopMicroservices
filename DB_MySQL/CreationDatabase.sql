CREATE DATABASE eshop CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
CREATE USER 'eshopUser'@'%' IDENTIFIED BY 'eshopUser';
GRANT SELECT, INSERT, UPDATE, DELETE ON eshop.* TO 'eshopUser'@'%';