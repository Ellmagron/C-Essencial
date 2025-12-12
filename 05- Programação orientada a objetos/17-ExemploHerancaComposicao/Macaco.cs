namespace _17_ExemploHerancaComposicao;

public class Macaco : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar;

    public Macaco(ComportamentoAndar andar)
    {
        _comportamentoAndar = andar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Macaco));
        _comportamentoAndar.Andar();
    }
}
 