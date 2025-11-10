/*Fazendo uma instacia da classe randowm*/

Random random = new Random();

Console.WriteLine(random.Next());
Console.WriteLine(random.Next(50)); // Gera um número aleatório entre 0 e 49
Console.WriteLine(random.Next(50, 100)); // Gera um número aleatório entre 50 e 99
Console.WriteLine(random.NextDouble()); // Gera um número aleatório entre 0.0 e 1.0



byte[] randBytes = new byte[10]; // Defindo um vetor de bytes com 10 posições
Random randNum = new Random(2023); // Instanciando a classe Random com uma semente fixa
randNum.NextBytes(randBytes); // Preenchendo o vetor com números aleatórios

//Seeding garante que a sequencia de números aleatórios seja sempre a mesma

for (int i = 0; i < randBytes.Length; i++)
{
    Console.WriteLine(randBytes[i]);
}

Console.WriteLine("Sorteio da MegaSena\n");  

int[] numerosSorteados = new int[6];

for (int i = 0; i < 6; i++)
{
    int numeroAleatorios;
    do
    {
        numeroAleatorios = random.Next(1, 61); // Gera um número aleatório entre 1 e 60
    }while (numerosSorteados.Contains(numeroAleatorios)); // Garante que o número não seja repetido

    numerosSorteados[i] = numeroAleatorios;
}

Array.Sort(numerosSorteados); // Ordena os números sorteados

Console.WriteLine("Numeros Sorteados\n");

Console.WriteLine(string.Join(" ", numerosSorteados));
