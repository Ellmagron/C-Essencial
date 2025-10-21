Console.WriteLine("#Aula this");

//Teste t1 = new Teste();
//t1.Num1 = 10;
//t1.Num2 = 20;
//t1.Exibir();

//Teste t2 = new Teste();
//t2.Num1 = 30;
//t2.Num2 = 40;
//t2.Exibir();


//class Teste
//{
//    public int Num1 { get; set; }
//    public int Num2 { get; set; }

//    public void PassarParametro(Teste t)
//    {
//        Console.WriteLine($"This = {this}");
//        Console.WriteLine($"O número 1 é: {t.Num1}");
//        Console.WriteLine($"O número 2 é: {t.Num2}");
//    }

//    public void Exibir()
//    {
//        PassarParametro(this);
//    }
//}

Teste teste1 = new Teste(10);

class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"Construtor com 2 parâmetro: {num1}, {num2}");

    }

    public Teste(int num1) : this(100, 200)
    {
        Console.WriteLine($"Construtor com 1 parâmetro: {num1}");
    }
}