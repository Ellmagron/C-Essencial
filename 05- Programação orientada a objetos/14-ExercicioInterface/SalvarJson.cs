namespace _14_ExercicioInterface;

public class SalvarJson : ArquivoBase, ISalvar // <- Classe concreta deve ser definida antes do nome da interface.
{
    public void Salvar()
    {
        Console.WriteLine("Salvar arquivo Json");
    }
    public override void Nome()
    {
        Console.WriteLine("Nome do arquivo Json");
    }
}
