
/*Henraça é um pilar da programação orientada objeto. Herança consiste em estender  uma classe ou fazer com que uma classe herde  propriedades ou métodos de outra, assim evitando repetição de código
    
   Uma classe que provem herança é chamada de classe base ou superclasse, e a classe que herda é chamada de classe derivada ou subclasse.
 */

Funcionario funcionarios = new();

funcionarios.Nome = "João Silva";
funcionarios.Email = "joao@gmail.com";
funcionarios.Empresa = "senai";
funcionarios.Salario = 2500.00f;
funcionarios.ExibirIdentificar();

Aluno alunos = new();

alunos.Nome = "Maria Souza";
alunos.Email = "maria@gmail.com";
alunos.Curso = "Análise e Desenvolvimento de Sistemas";
alunos.Nota = 9.5f;
alunos.ExibirIdentificar();


public class Pessoa
{
    public String? Nome { get; set; }
    public String? Email { get; set; }
    public void ExibirIdentificar()
    {
        Console.WriteLine($"Nome: {Nome}, Email: {Email}");
    }
}

public class Funcionario : Pessoa
{
    public String?  Empresa { get; set; }
    public float Salario { get; set; }
}

public class Aluno : Pessoa
    {
    public String? Curso { get; set; }
    public float Nota { get; set; }
}
