SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Table `mydb`.`Car`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`Car` (
  `idCar` INT NOT NULL ,
  `Vehicle description` VARCHAR(45) NOT NULL ,
  `Performance` INT NOT NULL ,
  `Colour` VARCHAR(45) NULL ,
  `Seating` INT NOT NULL ,
  `Body Shape` VARCHAR(45) NOT NULL ,
  `max. Speed` INT NOT NULL ,
  `Capacity` INT NOT NULL ,
  `Registration date` DATE NOT NULL ,
  `Laderaum` INT NOT NULL ,
  `Location` VARCHAR(45) NOT NULL ,
  `Gearing` VARCHAR(45) NOT NULL ,
  `License plate` VARCHAR(45) NOT NULL ,
  `Environmental badge` INT NOT NULL ,
  `Rate of consumption` INT NOT NULL ,
  `Status` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idCar`) );


-- -----------------------------------------------------
-- Table `mydb`.`Person`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`Person` (
  `idPerson` INT NOT NULL ,
  `Name` VARCHAR(45) NOT NULL ,
  `BirthDate` DATE NOT NULL ,
  `Password` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idPerson`) );


-- -----------------------------------------------------
-- Table `mydb`.`User`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`User` (
  `Username` VARCHAR(45) NOT NULL ,
  `Place of residence` VARCHAR(45) NULL ,
  `email` VARCHAR(45) NULL ,
  `Person_idPerson` INT NOT NULL ,
  PRIMARY KEY (`Username`) ,
  INDEX `fk_User_Person1_idx` (`Person_idPerson` ASC) ,
  CONSTRAINT `fk_User_Person1`
    FOREIGN KEY (`Person_idPerson` )
    REFERENCES `mydb`.`Person` (`idPerson` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`Damage`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`Damage` (
  `idDamage` INT NOT NULL ,
  `Date` DATE NULL ,
  `Damage description` VARCHAR(45) NULL ,
  `Car_idCar` INT NOT NULL ,
  PRIMARY KEY (`idDamage`) ,
  INDEX `fk_Damage_Car1_idx` (`Car_idCar` ASC) ,
  CONSTRAINT `fk_Damage_Car1`
    FOREIGN KEY (`Car_idCar` )
    REFERENCES `mydb`.`Car` (`idCar` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`Rent`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`Rent` (
  `idRent` INT NOT NULL ,
  `Duration` VARCHAR(45) NOT NULL ,
  `Car_idCar` INT NOT NULL ,
  `Person_idPerson` INT NOT NULL ,
  PRIMARY KEY (`idRent`) ,
  INDEX `fk_Rent_Car1_idx` (`Car_idCar` ASC) ,
  INDEX `fk_Rent_Person1_idx` (`Person_idPerson` ASC) ,
  CONSTRAINT `fk_Rent_Car1`
    FOREIGN KEY (`Car_idCar` )
    REFERENCES `mydb`.`Car` (`idCar` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Rent_Person1`
    FOREIGN KEY (`Person_idPerson` )
    REFERENCES `mydb`.`Person` (`idPerson` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`Admin`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`Admin` (
  `idAdmin` INT NOT NULL ,
  `Person_idPerson` INT NOT NULL ,
  PRIMARY KEY (`idAdmin`) ,
  INDEX `fk_Admin_Person1_idx` (`Person_idPerson` ASC) ,
  CONSTRAINT `fk_Admin_Person1`
    FOREIGN KEY (`Person_idPerson` )
    REFERENCES `mydb`.`Person` (`idPerson` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

USE `mydb` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
