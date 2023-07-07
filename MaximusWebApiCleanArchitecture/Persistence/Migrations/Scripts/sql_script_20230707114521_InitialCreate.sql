CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20230707114521_InitialCreate') THEN

    ALTER DATABASE CHARACTER SET utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20230707114521_InitialCreate') THEN

    CREATE TABLE `Stations` (
        `Id` char(36) COLLATE ascii_general_ci NOT NULL,
        `Name` longtext CHARACTER SET utf8mb4 NULL,
        `Latitude` float NULL,
        `Longitude` float NULL,
        `Altitude` double NULL,
        `ConnectionStatus` int NOT NULL,
        `LastUpdated` datetime(6) NULL,
        `UnitOfMeasurement` int NOT NULL,
        `DateCreated` datetime(6) NOT NULL,
        `DateUpdated` datetime(6) NULL,
        `DateDeleted` datetime(6) NULL,
        CONSTRAINT `PK_Stations` PRIMARY KEY (`Id`)
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20230707114521_InitialCreate') THEN

    CREATE TABLE `StationData` (
        `Id` char(36) COLLATE ascii_general_ci NOT NULL,
        `Temperature` double NULL,
        `Dewpoint` double NULL,
        `Humidity` double NULL,
        `WindSpeed` double NULL,
        `WindGust` double NULL,
        `WindDirection` int NULL,
        `DailyRain` double NULL,
        `SolarRadiation` double NULL,
        `StationId` char(36) COLLATE ascii_general_ci NOT NULL,
        `DateCreated` datetime(6) NOT NULL,
        `DateUpdated` datetime(6) NULL,
        `DateDeleted` datetime(6) NULL,
        CONSTRAINT `PK_StationData` PRIMARY KEY (`Id`),
        CONSTRAINT `FK_StationData_Stations_StationId` FOREIGN KEY (`StationId`) REFERENCES `Stations` (`Id`) ON DELETE CASCADE
    ) CHARACTER SET=utf8mb4;

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20230707114521_InitialCreate') THEN

    CREATE INDEX `IX_StationData_StationId` ON `StationData` (`StationId`);

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

DROP PROCEDURE IF EXISTS MigrationsScript;
DELIMITER //
CREATE PROCEDURE MigrationsScript()
BEGIN
    IF NOT EXISTS(SELECT 1 FROM `__EFMigrationsHistory` WHERE `MigrationId` = '20230707114521_InitialCreate') THEN

    INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
    VALUES ('20230707114521_InitialCreate', '7.0.2');

    END IF;
END //
DELIMITER ;
CALL MigrationsScript();
DROP PROCEDURE MigrationsScript;

COMMIT;

