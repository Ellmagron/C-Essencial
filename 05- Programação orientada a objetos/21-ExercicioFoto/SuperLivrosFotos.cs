namespace _21_ExercicioFoto;

public class SuperLivrosFotos : LivroFotos
{
    private int _numPaginas; // <-- Isso é chamado um campo ou atributo privado
    public SuperLivrosFotos()
    {
        _numPaginas = 64;
    }
    public override int GetNumeroPaginas()
    {
        Console.WriteLine($"O número de páginas do super livro de fotos é: {_numPaginas}");
        return _numPaginas;
    }
}
