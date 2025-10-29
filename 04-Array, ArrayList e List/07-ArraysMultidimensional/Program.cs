//Criando e percorrendo um array bidimensional

int[,] n = { 
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 } 
};

Console.WriteLine("\nUsano método for\n");
// Método for é utilizado para arrays bidimensionais porque permite um controle mais preciso sobre os índices das linhas e colunas.


for (int i = 0; i < n.GetLength(0); i++) 
{
    for (int j = 0; j < n.GetLength(1); j++) 
    {
        Console.Write(n[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nUsano método foreach\n");
// Método forreach também pode ser usado para arrays bidimensionais, mas ele não perite um controle tão detalhado sobre os índices das linhas e colunas como o método for.

foreach (int numero in n) 
{
    Console.Write(numero + " ");
}