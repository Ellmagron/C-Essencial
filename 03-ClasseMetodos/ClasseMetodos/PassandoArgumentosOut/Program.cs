Console.WriteLine("## Argumentos por referência - Out");

//Maneira padrão

//Console.WriteLine("Informe o raio do círculo");
//double raio = Convert.ToDouble(Console.ReadLine());

//Circulo circulo = new Circulo();

//double perimetro = circulo.CalcularPerimetro(raio);
//double area = circulo.CalcularArea(raio);

//Console.WriteLine($"Perímetro do círculo: {perimetro}");
//Console.WriteLine($"Área do círculo: {area}");


//public class Circulo
//{
//    public double CalcularArea(double raio)
//    {
//        return Math.PI * Math.Pow(raio, 2);
//    }

//    public double CalcularPerimetro(double raio)
//    {
//        double perimetro = 2 * Math.PI * raio;
//        return perimetro;
//    }
//}

// Usando o parâmetro out

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();

double perimetro = circulo.CalcularPerimetro(raio, out double area);

Console.WriteLine($"Perímetro do círculo: {perimetro}");
Console.WriteLine($"Área do círculo: {area}");


public class Circulo
{
    public double CalcularPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;

    }
}