namespace _22_ExercicioPessoa;

public class Pessoa
{
    private string _nome; // <-- Isso é chamado um campo ou atributo privado

    // Construtor que recebe o nome como parâmetro
    public Pessoa(string nome)
    {
        _nome = nome ?? string.Empty;
    }

    public string? Nome { get; set; }

    // Sobrescreve ToString() para retornar a representação do objeto
    public override string ToString()
    {
        return "Olá meu nome é" + Nome;
    }
}
