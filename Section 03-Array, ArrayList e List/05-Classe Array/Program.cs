

/*
    Classe array
    São métodos internos da linguagen para trablhar com array. 
    
    A classe array possui métodos para ordenar, buscar, copiar e comparar arrays.

    Array.vetor.Length - Retorna o tamanho do array.
    Array.vetor.GetLength(0) - Retorna o tamanho do array.
    Array.vetor.reve.

 */


string [] nomes = { "João", "Maria", "José", "Ana", "Pedro" };


Console.WriteLine("Exibindo array original");
ExibeArray(nomes);

Console.WriteLine("Invertendo array");
Array.Reverse(nomes);
ExibeArray(nomes);


Console.WriteLine("Ordenando array");
Array.Sort(nomes);
ExibeArray(nomes);


Console.WriteLine("Buscando item no array");
Console.WriteLine("Infome o nome");
string nomeBusca = Console.ReadLine();
var indice = Array.BinarySearch(nomes, nomeBusca);

if (indice >= 0)
{
    Console.WriteLine($"O nome {nomeBusca} encontrado no índice: {indice}");
}
else
{
    Console.WriteLine("Item não encontrado");
}


static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.WriteLine($"Nome: {nome}");
    }
}

