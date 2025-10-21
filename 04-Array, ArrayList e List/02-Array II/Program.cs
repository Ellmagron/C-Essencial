//Percorrendo vetores usando laços de repetação


string[] nomes = { "João", "Maria", "José", "Ana", "Pedro" };

int[] numeros = { 1, 2, 3, 4, 5 };


// Exibindo os valores dos arrays usando um laço de repetição
// Método length retorna o tamnho de uma array, você pode usar o length para percorrer o array


for(int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Indice {i}: {nomes[i]}");
}


for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Indice {i + 1}: {numeros[i]}");
}