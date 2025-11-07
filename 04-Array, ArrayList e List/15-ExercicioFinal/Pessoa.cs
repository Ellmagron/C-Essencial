using System.Collections;

namespace _15_ExercicioFinal;

public class Pessoa
{
    public string Nome { get; set; }
    public long Idade { get; set; }
    public string ExibirDados()
    {
        return $"Nome: {Nome} - Idade: {Idade}";
    }
}