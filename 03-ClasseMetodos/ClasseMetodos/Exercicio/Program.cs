

//Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
//chevrolet.acelerar(chevrolet.Marca);

////chevrolet.Modelo = "Sedan";
////chevrolet.Montadora = "Chevrolet";
////chevrolet.Marca = "Onix";
////chevrolet.Ano = 2016;
////chevrolet.potencia = 110;
////chevrolet.acelerar(chevrolet.Marca);

////Carro ford = new Carro();
////ford.Modelo = "SUV";
////ford.Montadora = "Ford";
////ford.Marca = "EcoSport";
////ford.Ano = 2018;
////ford.potencia = 120;
////ford.acelerar(ford.Marca);

//Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
//ford.acelerar(ford.Marca);

//class Carro
//{
//   public Carro(string modelo, string montadora, string marca, int ano, int potencia)
//    {
//        this.Modelo = modelo;
//        this.Montadora = montadora;
//        this.Marca = marca;
//        this.Ano = ano;
//        this.potencia = potencia;
//        Console.WriteLine("Construtor padrão chamado. Carro criado com valores padrão.");
//    }

//    public string? Modelo { get; set; }
//    public string? Montadora { get; set; }
//    public string? Marca { get; set; }
//    public int Ano { get; set; }
//    public int potencia { get; set; }


//    public void acelerar(string marca)
//    {
//        Console.WriteLine($"Acelerando o carro {marca}");
//    }
//}





Carro2 carro = new Carro2("Fusca", "Volkswagen");
carro.potencia = 80;

Console.WriteLine(carro.velocidadeMaxima(carro.potencia));

class Carro2
{
    public Carro2(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
        Console.WriteLine("Construtor padrão chamado. Carro criado com valores padrão.");
    }

    public string? Modelo { get; set; }
    public string? Montadora { get; set; }
    public string? Marca { get; set; }
    public int Ano { get; set; }
    public int potencia { get; set; }

    public double velocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}