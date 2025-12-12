/*
    Relacionamento de Agregação em C#
        - Assim como relacionamento de composição, o relacionamento de agregação também representa uma relação "tem um" ou "tem vários" entre classes.
        - A principal diferença entre composição e agregação é que, na agregação, a classe filha pode existir independentemente da classe pai.
        - Agregação cada objeto possui o seu próprio ciclo de vida.
        - Exemplo: Uma classe "Universidade" que tem uma lista de objetos "Estudante". Os estudantes podem existir independentemente da universidade.
        - A agregação seroa um relacionamento mais fraco em comparação com a composição.
 */

using _16_Agregacao;
Professor prof1 = new Professor("Carlos Silva", "Química");
Professor prof2 = new Professor("Ana Maria", "Inglês");
Professor prof3 = new Professor("Ana", "Literatura");
Professor prof4 = new Professor("Paulo", "Matemátia");

Departamento depto1 = new Departamento("Exatas");
depto1.IncluirProfessor(prof1);
depto1.IncluirProfessor(prof4);
depto1.ListaProfessores();


Departamento depto2 = new Departamento("Humanas");
depto2.IncluirProfessor(prof2);
depto2.IncluirProfessor(prof3);
depto2.ListaProfessores();





