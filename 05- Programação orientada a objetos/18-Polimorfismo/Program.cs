using _18_Polimorfismo;

/*Isso é chamado de polimorfismo dinâmico*/
var figuras = new List<Figura>
{
    new Circulo(),
    new Triangulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}


Calcular calc = new Calcular();

Console.WriteLine(calc.Somar(30, 40));
Console.WriteLine(calc.Somar(40, 40));


/*
 * Polimorfismo que usa sobrecarga de métodos
 */

class Calcular
{

    public int Somar(int a, int b) 
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }
}