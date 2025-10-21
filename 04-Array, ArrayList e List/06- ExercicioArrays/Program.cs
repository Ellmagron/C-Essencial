
//Criando array de nome
string[] nomes = new string[5];
double[] notas = new double[5];


Console.WriteLine("//ALUNOS//");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o nome do aluno {i}:");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}


Console.WriteLine("Informe a nota dos alunos");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o nome do aluno {i}:");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

Console.WriteLine("Lista alunos");
var somaNotas = 0.0;

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

foreach (double nota in notas)
{
    somaNotas += nota;
}

Console.WriteLine($"Soma das notas: {somaNotas}");
Console.WriteLine($"Média aritimetica das notas: {somaNotas/ notas.Count()}");

