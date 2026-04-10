namespace _22_ExercicioPessoa;

public class Professor : Pessoa
{
    public Professor(string nome) : base(nome) // <-- Essa é a maneira de chamar o construtor da classe base (Pessoa) para inicializar o nome do professor
    {
        Nome = nome; // <-- Isso é chamado de propriedade pública, que pode ser acessada e modificada de fora da classe
    }

    public void Explicar()
    {
        Console.WriteLine($"{Nome} está explicando.");
    }
}
 