namespace _13_Interfaces;


/*
    é possivel implementar múltiplas interfaces em uma única classe.
Assim como uma classe abstrata, quando se herda interfaces é necessário implementar todos os seus métodos abstratos.
 */
public class Demo : IControle, IGrafico
{
    public string Nome { get; set; }

    public void Desenhar() // Implementação do método Desenhar
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar() // Implementação do método Pintar
    {
        Console.WriteLine("Pintando");
    }
}
