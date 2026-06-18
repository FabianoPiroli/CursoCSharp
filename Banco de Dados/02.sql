CREATE SCHEMA `Curso_CSharp`;

USE `Curso_CSharp`;

CREATE TABLE `Curso_CSharp`.`alunos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `idade` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE);
  
  INSERT INTO `alunos` (nome, idade) VALUES ('Fabiano', 27);
  
SELECT * FROM `alunos`;