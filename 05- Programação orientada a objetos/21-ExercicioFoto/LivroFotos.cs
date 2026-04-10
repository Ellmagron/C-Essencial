namespace _21_ExercicioFoto;

public class LivroFotos
{
    private int _numPaginas; // <-- Isso é chamado um campo ou atributo privado

    public LivroFotos() // <-- Isso é chamado de construtor Padrão EXECUTADO AUTOMATICAMENTE QUANDO INSTANCIAMOS A CLASSE SEM PASSAR  NADA
    {
        _numPaginas = 16;
    }

        // Construtor adicional: permite especificar o número de páginas
    public LivroFotos(int numPaginas)
    {
        if (numPaginas < 1) // validação simples
        {
            numPaginas = 1;
        }

        _numPaginas = numPaginas;
    }

    public virtual int GetNumeroPaginas()
    {
        Console.WriteLine($"O número de páginas do livro de fotos é: {_numPaginas}");
        return  _numPaginas;        
    }
}
