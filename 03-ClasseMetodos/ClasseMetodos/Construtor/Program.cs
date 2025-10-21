

using System.Threading.Channels;

Console.WriteLine("Construtor");

Aluno aluno = new Aluno("Pedro", 26, "Masculino", "Sim");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);


public class Aluno
{
    public Aluno(string nome) => Nome = nome;
    

    // Um Construtor padrão é criado quando um objeto é instancia um classe com os valores padrão de seus respectivos tipos de dados.
    public Aluno(string nome, int idade, string sexo, string aprovado) :this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }
    public string? Aprovado { get; set; }
}