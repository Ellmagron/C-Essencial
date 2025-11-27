
Aluno aluno = new Aluno(); 
aluno.Nome = "João";
aluno.Curso = "Engenharia";
Console.WriteLine(aluno.Saudacao());

public class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => ($"Olá, meu nome é {Nome}");
}

// Se uma classe derivada tiver um método com a mesma assinatura de um método na classe base, o método da classe derivada oculta o método da classe base.
public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public string Saudacao() => ($"Olá, meu nome é {Nome} e meu curso é {Curso}."); // <= Isso está ocultado o método Saudacao da classe base Pessoa. Caso realmente deseje esse comportamento, utilize a palavra-chave 'new' antes do tipo de retorno do método.

    //public new string Saudacao() => ("");


}
