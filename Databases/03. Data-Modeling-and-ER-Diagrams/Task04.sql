-- MySQL Script generated by MySQL Workbench
-- 01/12/15 17:21:57
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Faculties`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Faculties` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Faculties` (
  `FacultyID` INT NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`FacultyID`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Students`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Students` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Students` (
  `StudentID` INT NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `Faculties_FacultyID` INT NOT NULL,
  PRIMARY KEY (`StudentID`, `Faculties_FacultyID`),
  CONSTRAINT `fk_Students_Faculties1`
    FOREIGN KEY (`Faculties_FacultyID`)
    REFERENCES `Faculties` (`FacultyID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_Students_Faculties1_idx` ON `Students` (`Faculties_FacultyID` ASC);

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Departments`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Departments` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Departments` (
  `DepartmentID` INT NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `Faculties_FacultyID` INT NOT NULL,
  PRIMARY KEY (`DepartmentID`, `Faculties_FacultyID`),
  CONSTRAINT `fk_Departments_Faculties1`
    FOREIGN KEY (`Faculties_FacultyID`)
    REFERENCES `Faculties` (`FacultyID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_Departments_Faculties1_idx` ON `Departments` (`Faculties_FacultyID` ASC);

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Professors`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Professors` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Professors` (
  `ProfessorID` INT NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `Departments_DepartmentID` INT NOT NULL,
  PRIMARY KEY (`ProfessorID`, `Departments_DepartmentID`),
  CONSTRAINT `fk_Professors_Departments1`
    FOREIGN KEY (`Departments_DepartmentID`)
    REFERENCES `Departments` (`DepartmentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_Professors_Departments1_idx` ON `Professors` (`Departments_DepartmentID` ASC);

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Courses`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Courses` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Courses` (
  `CoursesID` INT NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `Professors_ProfessorID` INT NOT NULL,
  `Professors_Departments_DepartmentID` INT NOT NULL,
  PRIMARY KEY (`CoursesID`, `Professors_ProfessorID`, `Professors_Departments_DepartmentID`),
  CONSTRAINT `fk_Courses_Professors1`
    FOREIGN KEY (`Professors_ProfessorID` , `Professors_Departments_DepartmentID`)
    REFERENCES `Professors` (`ProfessorID` , `Departments_DepartmentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_Courses_Professors1_idx` ON `Courses` (`Professors_ProfessorID` ASC, `Professors_Departments_DepartmentID` ASC);

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Students_Courses`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Students_Courses` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Students_Courses` (
  `Courses_CoursesID` INT NOT NULL,
  `Students_StudentID` INT NOT NULL,
  PRIMARY KEY (`Courses_CoursesID`, `Students_StudentID`),
  CONSTRAINT `fk_Students_Courses_Courses1`
    FOREIGN KEY (`Courses_CoursesID`)
    REFERENCES `Courses` (`CoursesID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Students_Courses_Students1`
    FOREIGN KEY (`Students_StudentID`)
    REFERENCES `Students` (`StudentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_Students_Courses_Courses1_idx` ON `Students_Courses` (`Courses_CoursesID` ASC);

SHOW WARNINGS;
CREATE INDEX `fk_Students_Courses_Students1_idx` ON `Students_Courses` (`Students_StudentID` ASC);

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Titles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Titles` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Titles` (
  `TitleID` INT NOT NULL,
  `Type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`TitleID`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Professors_Titles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Professors_Titles` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Professors_Titles` (
  `Titles_TitleID` INT NOT NULL,
  `Professors_ProfessorID` INT NOT NULL,
  PRIMARY KEY (`Titles_TitleID`, `Professors_ProfessorID`),
  CONSTRAINT `fk_Professors_Titles_Titles`
    FOREIGN KEY (`Titles_TitleID`)
    REFERENCES `Titles` (`TitleID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Professors_Titles_Professors1`
    FOREIGN KEY (`Professors_ProfessorID`)
    REFERENCES `Professors` (`ProfessorID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_Professors_Titles_Titles_idx` ON `Professors_Titles` (`Titles_TitleID` ASC);

SHOW WARNINGS;
CREATE INDEX `fk_Professors_Titles_Professors1_idx` ON `Professors_Titles` (`Professors_ProfessorID` ASC);

SHOW WARNINGS;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
