
using _12_Exercicio___List_T;

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

//Adicionando alunos na lista

Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75 };
Aluno Mario = new Aluno() { Nome = "Mario", Nota = 8.95};

alunos.Add(bia);
alunos.Add(Mario);

ExibirAlunos(alunos);

//Encontrnado um aluno e fazendo 
var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda")); 
alunos.Remove(aluno1);
ExibirAlunos(alunos);

//Ordernando aluno
/*
    Não é possivel ordernar uma list usando o método sort, porque ele é um lista complexa. então deve se utilizar o método orderBy
 */
var listaOrdernada = alunos.OrderBy(n => n.Nome).ToList();

//Exibindo alunos com nota maior ou igual a 8

var alunosNota8 = alunos.FindAll(aluno => aluno.Nota >= 8);
Console.WriteLine("Aluno com média maior ou igual a 8"); 
foreach(var item in alunosNota8)
{
    Console.WriteLine($"{item.Nome} {item.Nota}");
}


Console.ReadKey();


// Função pára Exibir alunos
static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\n Relação de alunos \n");
    Console.WriteLine("\n Nome \t Nota");


    var somaTotal = 0.0;
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome} {item.Nota}");
        somaTotal += item.Nota;
    }

    var mediaNotas = somaTotal / alunos.Count;
    Console.WriteLine($"\n Média das notas: {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\n Total de alunos: {alunos.Count}");
}


