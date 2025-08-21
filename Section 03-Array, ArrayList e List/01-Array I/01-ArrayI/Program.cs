

//Delcração do array seu tipo seguindo de seu nome

int[] numeros;

//Alacação de mémoria
numeros = new int[5];

//Atribuição de valores
numeros= new int[] { 1, 2, 3, 4, 5 };

//Segundo forma de definir um vetor
string[] nomes = new string[5] { "João", "Maria", "José", "Ana", "Pedro" };

//Terceira forma de definir um vetor sem precisar definir um tamanho

string[] frutas = { "Maçã", "Banana", "Laranja", "Uva", "Pera" };

//Quarta forma de definir um vetor sem precisar definir um tamanho e sem usar o new

string[] cores = new[] { "Vermelho", "Verde", "Azul", "Amarelo", "Roxo" };

//Para obter valores do vetor, basta usar o índice do elemento desejado

Console.WriteLine(numeros[0]); // Saída: 1
Console.WriteLine(nomes[1]); // Saída: Maria
Console.WriteLine(frutas[2]); // Saída: Laranja
Console.WriteLine(cores[3]); // Saída: Amarelo

//Para alterar um valor do vetor, basta atribuir um novo valor ao índice desejado
numeros[0] = 10;
nomes[1] = "Mariana";
frutas[2] = "Limão";
cores[3] = "Laranja";

