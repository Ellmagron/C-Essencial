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
