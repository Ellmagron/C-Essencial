/*Exercicio 1 FRUTAS*/
//List<string> Frutas = new List<string>()
//{
//    "Maça","Banana", "Laranja", "Uva", "Morango", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
//};

////A - Exibindolista
//Formatando("Coleção de frutas");
//ListaDeFruta(Frutas);


////B - Puxando segundo e o último elemento
//Formatando("Ultimo e primeiro elemento da coleção");
//Console.WriteLine($"Quantidade de frutas: {Frutas.Count()} ");
//Console.WriteLine($"Segunda fruta da coleção {Frutas[1]}");
//Console.WriteLine($"Última  fruta da coleção {Frutas[Frutas.Count() - 1]}");

////C - Alterando terceiro e último elementod a lista
//Formatando("Lista atualizada");
//Frutas[2] = "Kiwi";
//Frutas[Frutas.Count() - 1] = "Caqui";
//ListaDeFruta(Frutas);

//// D- Ordenando elementos
//Formatando("Lista ordenada");
//Frutas.Sort();
//ListaDeFruta(Frutas);

//// E- Invertendo ordem da lista
//Formatando("Lista invertida");
//Frutas.Reverse();
//ListaDeFruta(Frutas);



////Defenindo método
//static void ListaDeFruta(List<string> Frutas)
//{
//    var indice = 0;
//    foreach (var item in Frutas)
//    {
//        indice++;
//        Console.WriteLine($"{indice}°: {item}");
//    }
//}

//static void Formatando(string mensagem)
//{
//    Console.WriteLine("");
//    Console.WriteLine(mensagem);

//}


/*Exercicio 2*/

//using System.Collections;
//using System.Threading.Channels;
//using static System.Runtime.InteropServices.JavaScript.JSType;
//Console.WriteLine("Digite o número do array");
//var i = int.Parse(Console.ReadLine());

//int[] numeros = new int[i];


//Console.WriteLine("");
//Console.WriteLine("Preencha o array");
//for(int y = 0; y < numeros.Length; y++)
//{
//    numeros[y] = int.Parse(Console.ReadLine());
//}

//var numeroEscolhido = 0;

//do
//{
//    Console.WriteLine("Digite o numero que deseja encontrar");
//    numeroEscolhido = int.Parse(Console.ReadLine());
//    Console.WriteLine("");

//    if (numeros.Contains(numeroEscolhido))
//        Console.WriteLine($"{numeroEscolhido} foi encontrado");
//    else
//        Console.WriteLine($"{numeroEscolhido} não foi encontrado");
//    Console.WriteLine("Digite novamente");


//} while (!numeros.Contains(numeroEscolhido));
//Console.WriteLine("Fim");



/*Exercicio 3*/

//float[,] matriz = new float[2, 2];

//float Coluna1 = 0;
//float Coluna2 = 0;

//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//            Console.WriteLine($"Digite o a nota da {i + 1}° pessoa:");
//            matriz[i, j] = float.Parse(Console.ReadLine());

//            if (j == 0)
//                Coluna1 += (int)matriz[i, j];
//            else
//                Coluna2 += (int)matriz[i, j];
//    }
//}


//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        Console.Write(matriz[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine($"A soma da coluna 1 é: {Coluna1 / matriz.GetLength(0):F2}");
//Console.WriteLine($"A soma da coluna 2 é: {Coluna2 / matriz.GetLength(1):F2}");

/*Exercicio 4*/

using _15_ExercicioFinal;
using System.Collections;
using System.ComponentModel;

ArrayList list = new ArrayList();

for (int i = 0; i < 3; i++)
{

    Console.WriteLine($"Digite o nome da {i + 1}° pessoa:");
    string nome  = Console.ReadLine();
    Console.WriteLine($"Digite a idade da {i + 1}° pessoa:");
    int idade = int.Parse(Console.ReadLine());

    list.Add(new Pessoa
    {
        Nome = nome,
        Idade = idade
    });
}

ExibirPessoas(list);
//Adcionando novas pessoas na lista
Console.WriteLine();
Console.WriteLine("Atualizando lista");
Pessoa guilherme = new Pessoa() {Nome = "Guilherme", Idade = 24 };
Pessoa Vitor = new Pessoa() { Nome = "Vitor", Idade = 25 };

list.Add(guilherme);
list.Add(Vitor);

ExibirPessoas(list);

//Removendo última pessoa da lista
Console.WriteLine();
list.Remove(list.Count - 1);
Console.WriteLine($"Removendo {list[list.Count - 1]}");
ExibirPessoas(list);


static void ExibirPessoas(ArrayList list)
{
    Console.WriteLine("Lista de pessoas");
    foreach (Pessoa pessoa in list)
    {
        Console.WriteLine(pessoa.ExibirDados());
    }
}