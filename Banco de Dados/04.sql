USE `Curso_CSharp`;

INSERT INTO `alunos` (nome, idade) VALUES ('Fabiano', 27);
  
SELECT * FROM `alunos`;

SET SQL_SAFE_UPDATES = 0;

UPDATE `alunos` SET nome = 'Joao' WHERE nome = 'Fabiano';

INSERT INTO `alunos` (nome, idade) VALUES ('Joao', 16);
INSERT INTO `alunos` (nome, idade) VALUES ('Joao', 20);
INSERT INTO `alunos` (nome, idade) VALUES ('Marcos', 18);

UPDATE `alunos` SET nome = 'Fabiano' WHERE id = 1;

DELETE FROM `alunos` WHERE id = 5;