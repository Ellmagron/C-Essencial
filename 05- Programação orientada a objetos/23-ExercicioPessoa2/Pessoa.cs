namespace _23_ExercicioPessoa2;

public class Pessoa
{
    // Não necessariamente quando se cria um construtor é necessario de um campo privado

    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public string? Nome { get; set; }

    public override string ToString()
    {
        return $"Olá meu nome é {Nome}";
    }
}
