/* Coleção List<T>
 * 
 * Definição: É uma coleção de objetos fortemente tipada que pode crescer e diminuir dinamicamente.
 * 
 * Assim como o array e array list, a List<T> armazena uma sequência de elementos que podem ser acessadas atraves do seu indice, mas com algumas diferenças importantes:
 * 
 * 1 - Tipagem forte: A List<T> é uma coleção de objetos genérica, o que significa que você pode especificar o tipo de dados que a lista irá armazenar. Isso proporciona segurança de tipo em tempo de compilação.
 * 
 * 2- Redimensionamento dinâmico: Ao contrário dos arrays, que têm um tamanho fixo, as List<T> podem crescer e diminuir conforme necessário. Você pode adicionar ou remover elementos facilmente.
 * 
 * 3- Métodos e propriedades úteis: A List<T> oferece uma variedade de métodos e propriedades para manipular os dados, como Add, Remove, Count, Sort, entre outros.
 * 
 * 4- Não executa boxing/unboxing: Diferente do ArrayList, que armazena elementos como objetos, a List<T> armazena elementos do tipo especificado, evitando o overhead de boxing e unboxing para tipos de valor.
 * 
 * 
 * O sinal <t> é chamado de parâmetro de tipo genérico. Ele permite que você defina uma lista para armazenar qualquer tipo de dados, como int, string, ou até mesmo tipos personalizados.'
 
 */

//Declarando uma coleção do tipo List<T>

// 1 - forma explícita
List<string> lista;
lista = new List<string>();

// 2 - forma 
List<int> lista1 = new List<int>();

// 3 - forma simplificada
var lista2 = new List<float>();

// 4 forma mais abreviada
List<double> lista3 = new();

//Adiconando elementos na coleção
List<string> nomes = new();

nomes.Add("Maria");
nomes.Add("João");
nomes.Add("Ana");

//Usando inicionalizador de coleção

var lista4 = new List<string>()
{ 
    "Pedro", "Paula", "Carla", "Carlos"
};


//Métodos uteis para coleções List<T>

var listaNome = new List<string>() 
{ 
    "Pedro", "Paula", "Carla", "Carlos"
};

string[] array1 = { "Marcos", "Mariana", "Marcelo" };

listaNome.Add("Mariana"); //Adiciona um elemento no final da lista

listaNome.Insert(2, "Marcos"); //Adiciona um elemento na posição especificada

listaNome.AddRange(array1); //Adiciona uma coleção de elementos no final da lista

//Removendo elementos da coleção

listaNome.Remove("Carlos"); //Remove a primeira ocorrência do elemento especificado

listaNome.RemoveAt(0); //Remove o elemento na posição especificada

listaNome.RemoveRange(1, 2); //Remove uma faixa de elementos a partir da posição especificada


Console.WriteLine(listaNome.Count()); //Retorna o número de elementos na lista

// Assim como em arrays, é possivel acessar os elementos da lista através do índice

var primeiroNome = listaNome[0]; //Acessa o primeiro elemento da lista

//Alterando o elemento em um indice
listaNome[0] = "Fernanda"; //Altera o primeiro elemento da lista(marcos para Fernanda)


//Iterando sobre os elementos da lista usando método for

for(int i = 0; i < listaNome.Count; i++)
{
    Console.WriteLine($"Elemento na posição {i}: {listaNome[i]}");
}

//Iterando sobre os elementos da lista usando foreach
foreach(var nome in listaNome)
{
    Console.WriteLine($"Nome: {nome}");
}

//Verificando a existência de um elemento na lista
bool existePaula = listaNome.Contains("Paula");

//Métod contains é case sentitive.

Console.WriteLine($"Existe Paula na lista? {existePaula}");

ExibirLista(listaNome);

//Ordenando elementos da coleção
listaNome.Sort(); //Ordena os elementos em ordem crescente (alfabética para strings)
ExibirLista(listaNome);

//Removendo todos os elementos da coleção
listaNome.Clear(); //Remove todos os elementos da lista, mas permance o tamanho da coleção.
ExibirLista(listaNome);
Console.WriteLine(listaNome.Count);
Console.WriteLine("Fim");

static void ExibirLista(List<string> listaNome)
{
    foreach (var nome in listaNome)
    {
        Console.WriteLine($"Nome: {nome}");
    }
}

/*
    O comportamento de List<t> comparado ao ArrayList: Conceitos
 
    ArrayList
    - Tipo de valor: Armazena diretamente os dados atribuidos na memória Stack
    Exemplo: int, float, long, dateTime, double, bool, struct
    -Tipo por referência: Armazena um ponteiro (referência) para o local na memória Heap onde os dados estão armazenados.
    Exemplo: string, Array, ArrayList, List<T>, class, classes definidas pelo usuário, Interface, delegate, dynamic

   
    - Boxing: Processo de converter um tipo de valor em um tipo por referência (objeto). Isso envolve a criação de uma cópia do valor na memória Heap.
    int num = 23
    Object obj = num; // boxing

    - Unboxing: Processo de converter um tipo por referência (objeto) de volta para um tipo de valor. Isso envolve a extração do valor da memória Heap para a memória Stack.
    int num = 23
    Object obj = num; // boxing
    int outroNum = (int)obj; // unboxing

    List<T>
    - Não executa boxing/unboxing: Diferente do ArrayList, que armazena elementos como objetos, a List<T> armazena elementos do tipo especificado, evitando o overhead de boxing e unboxing para tipos de valor.
 */

ArrayList lista = new ArrayList();
lista.Add(10);
lista.Add(20);

var elemento1 = lista[0];

int numero = (int)lista(1); // Isso gera um erro de compilação, pois o elemento é do tipo object e precisa ser convertido para int

List<int> lista1 = new List<int>();
lista1.Add(10);

var elemento2 = lista1[0]; // Isso funciona corretamente, pois o elemento list<t> é do tipo int, então não é necessário fazer conversão.


/*
    Métodos find para o List<T>
    - Find: Retorna o primeiro elemento que corresponde a uma condição especificada.
    - FindLast: Retorna o último elemento que corresponde a uma condição especificada.
    - FindIndex: Retorna o índice do primeiro elemento que corresponde a uma condição especificada.
    - FindLastIndex: Retorna o índice do último elemento que corresponde a uma condição especificada.
- FindAll: Retorna todos os elementos que correspondem a uma condição especificada.

 O que é predicado? 
    Um predicado é uma função que recebe um argumento e retorna um valor booleano (true ou false). Ele é usado para definir condições ou critérios para filtrar ou selecionar elementos em uma coleção.
 */

List<string> frutas = new List<string>()
{
    "Maçã", "Banana", "Laranja", "Abacaxi", "Manga", "Melancia"
};

// Usando o método Find para encontrar a primeira fruta que começa com a letra 'M'
var resultado = frutas.Find(Procurar);

    console.WriteLine($"Primeira fruta que começa com 'M': {resultado}");

// Definindo o predicado como uma função lambda (Essa é uma forma antiga de fazer)
static bool Procurar(string item)
{
    return item.Contains("M");
}

// Usando expressão lambda diretamente no método Find (Forma mais moderna e recomendada)
var resultado2 = frutas.Find(item => item.Contains("M "));

//Usando Findlast para encontrar a última fruta que começa com a letra 'M'

var resultado3 = frutas.FindLast(item => item.Contains("M"));

//Usando FindIndex para encontrar o índice da primeira fruta que começa com a letra 'M'
var indice1 = frutas.FindIndex(item => item.Contains("M"));
Console.WriteLine($"Index = {indice1}  Fruta=${frutas[indice1]}");

//Usando FindLastIndex para encontrar o índice da última fruta que começa com a letra 'M'
var indice2 = frutas.FindLastIndex(item => item.Contains("M"));
Console.WriteLine($"Index = {indice2}  Fruta=${frutas[indice2]}");

//Usando FindAll para encontrar todas as frutas que começam com a letra 'M'
var resultados = frutas.FindAll(item => item.Contains("M"));
Console.WriteLine("Frutas que começam com 'M':");
foreach(var fruta in resultados)
{
    Console.WriteLine(fruta);
} 