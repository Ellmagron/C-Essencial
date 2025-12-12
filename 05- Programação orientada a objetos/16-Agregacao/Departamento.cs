namespace _16_Agregacao;
/*
 * Quando o relacionamento acontece entre departamento e professor?
 
 */


public class Departamento 
{
    public Departamento(string? nome)
    {
        Nome = nome;
        professores = new List<Professor>();
    }

    public string? Nome { get; set; }
    public List<Professor>? professores { get; set; }

    public void IncluirProfessor(Professor professor)
    {
        professores?.Add(professor);
    }


    public void ListaProfessores() 
    {
        Console.WriteLine($"\nDepartamento de : {Nome}");
        foreach (var prof in professores) 
        {
            Console.WriteLine($"Professor: {prof.Nome} - Disciplina: {prof.Disciplina}");
        }

    }
} 
