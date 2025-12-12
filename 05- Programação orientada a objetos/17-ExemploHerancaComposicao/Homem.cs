namespace _17_ExemploHerancaComposicao;

public class Homem : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar;

    public Homem(ComportamentoAndar andar)
    {
        _comportamentoAndar = andar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Homem));
        _comportamentoAndar.Andar();
    }
}
