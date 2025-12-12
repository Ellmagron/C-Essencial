namespace _17_ExemploHerancaComposicao;

public class Sardinha : Animal
{
    private readonly ComportamentoNadar _comportamentoNadar;
    public Sardinha(ComportamentoNadar comportamentoNadar)
    {
        _comportamentoNadar = comportamentoNadar;
    } 
    public void Locomocao()
    {
        Console.WriteLine(nameof(Sardinha));
        _comportamentoNadar.Nadar();
    }
}
