namespace _10_DowcastingEUpcasting;

public class Forma
{
    protected int xpos, ypos;
    
    public Forma(int x, int y)
    {
        xpos = x;
        ypos = y;
    }

    public virtual void Desenhar()
    {
        Console.WriteLine($"Desenhando forma : ({xpos}), ({ypos})");
    }
}
