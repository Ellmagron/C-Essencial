using ExercicioEnum;

Console.WriteLine($"{Cores.Branco} {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} {(int)Cores.Azul}");

Console.WriteLine("Selecione a cor do carro");
int cor = Convert.ToInt32(Console.ReadLine());



Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);
chevrolet.ExibirInfo(chevrolet.Modelo, chevrolet.Montadora, chevrolet.Marca,
chevrolet.Potencia, chevrolet.Cor);

public class Carro
{
    //campo
    public int Cor;
    //construtor
    public Carro(string? Modelo, string? Montadora, string? Marca,
    int Ano, int Potencia, int cor)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        Cor = cor;
    }
    //método
    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca,
    int Potencia, int Cor = 1, int Ano = 2022)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
        Console.WriteLine((Cores)Cor);
    }

    //propriedadesq
    public string? Modelo { get; set; }
    public string? Montadora { get; set; }
    public string? Marca { get; set; }
    public int Ano { get; set; }
    public int Potencia { get; set; }

}
