using System.Security.Cryptography;

Console.WriteLine("#### Métodos");


Aluno A1 = new();
Console.WriteLine("Nome: ");
A1.Nome = Console.ReadLine();
Console.WriteLine("Idade: ");
A1.Idade = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Sexo: ");
A1.Sexo = Console.ReadLine();
Console.WriteLine("Aprovado: ");
A1.Aprovado = Console.ReadLine();

Curso resu = new();
resu.Resultado(A1);

public class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }
    public string? Aprovado { get; set; }
}

public class Curso
{
    public void Resultado(Aluno A1)
    {
        Console.WriteLine($"O aluno {A1.Nome} com {A1.Idade} anos");

        if(A1.Aprovado == "s")
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}