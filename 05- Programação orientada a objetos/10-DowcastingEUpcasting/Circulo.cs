namespace _10_DowcastingEUpcasting;

public class Circulo : Forma
{
    public Circulo(int x, int y) : base(x, y)
    {
    }
    public override void Desenhar()
    {
        Console.WriteLine($"Desenhando - círculo na posição : ({xpos}), ({ypos})");
    }

    public void PintarCirculo() 
    {
        Console.WriteLine("Pintar o ciruclo");
    }
}
