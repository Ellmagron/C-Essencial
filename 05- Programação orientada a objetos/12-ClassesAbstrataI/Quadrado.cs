namespace _12_ClassesAbstrataI;

/*
    Não é possível instanciar uma classe abstrata diretamente.
    Portanto, é necessário criar uma classe derivada que implemente os métodos abstratos definidos na classe base.
 */
public class Quadrado : Forma
{
    public double  Lado { get; set; }

    public override void CalcularArea() // Classe derivada deve implementar os métodos abstratos
    {
        Area = Lado * Lado;
    }

    public override void CalcularPerimetro()
    {
        Perimetro = 4 * Lado;
    }
}
