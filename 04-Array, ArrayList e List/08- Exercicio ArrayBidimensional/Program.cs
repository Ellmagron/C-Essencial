
string[, ] alunbos = new string[2, 5];

Console.WriteLine("{Maria, Paulo, Marta, Pedro, Carlos}");
Console.WriteLine("{Silvia, Pedro, Alicia, Manoel, Paula}");

for(int i = 0; i < alunbos.GetLength(0); i++)
{
    for(int j = 0; j < alunbos.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o nome do aluno da  posição {i},{j}:");
        alunbos[i, j] = Console.ReadLine();
    }
}

for (int i = 0; i < alunbos.GetLength(0); i++)
{
    for (int j = 0; j < alunbos.GetLength(1); j++)
    {
        Console.Write($"{i}, {j} = {alunbos[i,j]}\t ");
    }
    Console.WriteLine();
}