namespace _14_ExercicioInterface;

interface ISalvar
{
    void Salvar(); // <- Método obrigatório para implementação nas classes que implementam a interface.
    public void CompactarArquivo() // <- - Método com implementação padrão antes do C# 8.0 não era permitido em interfaces. //Não é obrigatório implementar esse método nas classes que implementam a interface.
    {
        Console.WriteLine("Compactar arquivo");
    }
}
