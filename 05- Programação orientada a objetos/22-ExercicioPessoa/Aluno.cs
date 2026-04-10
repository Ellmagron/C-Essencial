namespace _22_ExercicioPessoa;

public class Aluno : Pessoa
{

    public Aluno(string nome) : base(nome) // <-- Essa é a forma da classe filha(derivada) chamar o construtor da classe Pai(base) (Pessoa) para inicializar o nome do aluno
    {
        Nome = nome; // <-- Isso é chamado de propriedade pública, que pode ser acessada e modificada de fora da classe
    }
    public void Estudar()
    {
                Console.WriteLine($"{Nome} está estudando.");
    }
}
