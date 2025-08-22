// Percorrendo um array usando o foreach


int[] numeros = { 1, 2, 3, 4, 5 };


string[] nomes = { "João", "Maria", "José", "Ana", "Pedro" };


// Percorrendo um array usando o foreach
foreach (int numero in numeros)
{
    Console.WriteLine($"Número: {numero}");
}

foreach (string nome in nomes)
{
    Console.WriteLine($"Nome: {nome}"); 
}

