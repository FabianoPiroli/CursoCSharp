CREATE SCHEMA `Curso_CSharp`;

CREATE TABLE `Curso_CSharp`.`alunos` (
  `id` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `idade` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE);
