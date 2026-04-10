using System;
namespace _20_ExercicioVeiculo;

public class Carro : IVeiculo
{
    private int _gasolina;

    public Carro(int gasolinaInicial)
    {
        if (gasolinaInicial < 0)
            throw new ArgumentOutOfRangeException(nameof(gasolinaInicial), "Quantidade inicial de gasolina não pode ser negativa.");

        _gasolina = gasolinaInicial;
    }

    public int GasolinaAtual => _gasolina;

    public void Dirigir()
    {
        if (_gasolina <= 0)
        {
            Console.WriteLine("Não há gasolina suficiente para dirigir.");
            return;
        }

        _gasolina--;
        Console.WriteLine($"Dirigindo... gasolina restante: {_gasolina}.");
    }

    public bool Abastecer(int valor)
    {
        if (valor <= 0)
            return false;

        _gasolina += valor;
        return true;
    }
}
