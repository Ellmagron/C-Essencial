using _22_ExercicioPessoa;
using System.Runtime.ExceptionServices;

Aluno aluno = new Aluno("João");

aluno.ToString();

//aluno.Estudar();

//Professor professor = new Professor("Dr. Smith");
//professor.Explicar();

/*
    Crie um programa que solicite ao usuário três nomes de pessoas e os armazene em
uma matriz de objetos do tipo Pessoa. Haverá duas pessoas do tipo Aluno e uma
pessoa do tipo Professor.
 */

int total = 3;
Pessoa[] pessoas = new Pessoa[total];

for(int i = 0; i < total; i++)
{
    if(i == 0)
    {
        Console.WriteLine("Informe o nome do Professor");
        pessoas[i] = new Professor(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Informe o nome do Aluno");
        pessoas[i] = new Aluno(Console.ReadLine());
    }
}

for(int i = 0; i < total; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Professor...");
        ((Professor)pessoas[i]).Explicar();
    }
    else
    {
        Console.WriteLine("Aluno...");
        ((Aluno)pessoas[i]).Estudar();
    }
}