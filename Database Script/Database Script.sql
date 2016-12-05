


--------------------------------------------------------
-- This is WebAPIMySQLSampleDb application database Before Production.
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `WebAPIMySQLSampleDb` ;
USE `WebAPIMySQLSampleDb` ;

DROP TABLE IF EXISTS `WebAPIMySQLSampleDb`.`status` ;

CREATE TABLE IF NOT EXISTS `WebAPIMySQLSampleDb`.`status` (
  `StatusId` INT NOT NULL AUTO_INCREMENT,
  `StatusCode` VARCHAR(45) NOT NULL,
  `StatusName` VARCHAR(45) NOT NULL,
  `CreatedOn` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  `LastModifiedDateTime` TIMESTAMP NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`StatusId`))
ENGINE = InnoDB;

DROP TABLE IF EXISTS `WebAPIMySQLSampleDb`.`priority` ;

CREATE TABLE IF NOT EXISTS `WebAPIMySQLSampleDb`.`priority` (
  `PriorityId` INT NOT NULL AUTO_INCREMENT,
  `PriorityCode` VARCHAR(45) NOT NULL,
  `PriorityName` VARCHAR(45) NOT NULL,
  `CreatedOn` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  `LastModifiedDateTime` TIMESTAMP NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`PriorityId`))
ENGINE = InnoDB;



DROP TABLE IF EXISTS `WebAPIMySQLSampleDb`.`company` ;

CREATE TABLE IF NOT EXISTS `WebAPIMySQLSampleDb`.`company` (
  `CompanyUniqueID` CHAR(36) NOT NULL UNIQUE,
  `CompanyName` VARCHAR(45) NULL,
  `CompanyAddress` VARCHAR(45) NULL,
  `CompanyCity` VARCHAR(45) NOT NULL,
  `StatusId` INT NULL,
  `CreatedOn` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  `LastModifiedDateTime` TIMESTAMP NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`CompanyUniqueID`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `WebAPIMySQLSampleDb`.`accounts`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `WebAPIMySQLSampleDb`.`accounts` ;

CREATE TABLE IF NOT EXISTS `WebAPIMySQLSampleDb`.`accounts` (
  `AccountUniqueId` CHAR(36) NOT NULL UNIQUE,
  `AccountName` VARCHAR(45) NOT NULL,
  `AccountAddress` VARCHAR(45) NULL,
  `AccountCity` VARCHAR(45) NULL,
  `AccountStateId` INT NULL,
  `CompanyUniqueId` CHAR(36) NOT NULL,
  `StatusId` INT NULL,
   `CreatedOn` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  `LastModifiedDateTime` TIMESTAMP NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`AccountUniqueId`))
ENGINE = InnoDB;



ALTER TABLE `WebAPIMySQLSampleDb`.`accounts`
    ADD CONSTRAINT `FK_AccountsCompanyUniqueId` 
    FOREIGN KEY (`CompanyUniqueId`)
    REFERENCES `WebAPIMySQLSampleDb`.`company` (`CompanyUniqueId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION;
    

-- -----------------------------------------------------
-- Table `WebAPIMySQLSampleDb`.`employee`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `WebAPIMySQLSampleDb`.`employee` ;

CREATE TABLE IF NOT EXISTS `WebAPIMySQLSampleDb`.`employee` (
  `AccountUniqueId` CHAR(36) NOT NULL ,
  `EmployeeUniqueId` CHAR(36) NOT NULL UNIQUE,
  `EmployeeFirstName` VARCHAR(45) NOT NULL,
  `EmployeeLastName` VARCHAR(45) NOT NULL,
  `EmployeeUserName` VARCHAR(45) NOT NULL,
  `EmployeePassword` VARCHAR(45) NOT NULL,
  `EmployeePasswordSalt` VARCHAR(45) NOT NULL,
  `StatusId` INT NULL,
  `IsPasswordReset` bool NULL DEFAULT 0,
   `CreatedOn` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  `LastModifiedDateTime` TIMESTAMP NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`EmployeeUniqueId`))
ENGINE = InnoDB;

    
    
ALTER TABLE `WebAPIMySQLSampleDb`.`employee`
    ADD CONSTRAINT `FK_EmployeeStatusId` 
    FOREIGN KEY (`StatusId`)
    REFERENCES `WebAPIMySQLSampleDb`.`status` (`statusId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION;
    
ALTER TABLE `WebAPIMySQLSampleDb`.`employee`
    ADD CONSTRAINT `FK_EmployeeAccountUniqueId` 
    FOREIGN KEY (`AccountUniqueId`)
    REFERENCES `WebAPIMySQLSampleDb`.`accounts` (`AccountUniqueId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION;
    
    