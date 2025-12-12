namespace _13_Interfaces;

interface IControle
{
    //public IControle();  Interfaces não podem ter construtores

    void Desenhar(); // Método abstrato
    string Nome { get; set; }
    public void Exbir() // Método com implementação padrão
    {
        Console.WriteLine("Teste...");
    }
}
