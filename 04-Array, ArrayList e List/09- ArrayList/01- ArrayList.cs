/*
    Array list
 -Definilçao: Array list é uma coleção não generica e dinâmica que pode crescer e diminuir de tamanho conforme necessário. Diferente dos arrays tradicionais, que têm um tamanho fixo, os array lists podem aumentar seu tamanho a medida que é adiconado novos dados. Array list pode armazenar elementos de tipos diferentes de dados.
 
- Declaração, instanciação e inclusao de elementos:
    Para criar um arrayList podemos usar a plavara chave new e a seguir usar o método Add para adicionar elementos. ou podemos usar os inicializadores de objetod(object initializers) para criar um array list com elementos predefinidos./

 
using System.Collections;

// Declaração e instanciação de um ArrayList
ArrayList Lista;
Lista = new ArrayList();

ArrayList lista = new ArrayList();
var lista = new ArrayList();
ArrayLista lista = new();

ArrayList lista = new ArrayList(5);
var lista = new ArrayListy(5);
ArrayLista lista = new(5);

propriedade Count: Retorna o número de elementos presentes no array list.
propriedade Capacity: Retorna ou define o número total de elementos que o array list pode conter antes de precisar redimensionar.



 */

using System.Collections;

ArrayList lista;
    lista = new ArrayList();


ArrayList lista1 = new ArrayList();
var lista2 = new ArrayList();
ArrayList lista3 = new();

ArrayList lista4 = new ArrayList(5);
var lista5 = new ArrayList(5);
ArrayList lista6 = new(5);

ArrayList lista7 = new();

    // Adicionando elementos ao ArrayList
    lista.Add("Maria");
    lista.Add(25);
    lista.Add(175.5);
    lista.Add(true);
    lista.Add('A');
    lista.Add(null);


//Inicializadores de objeto
var lista8 = new ArrayList()
{
    "Paulo",
    25,
    180.2,
    false,
    'B',
    null
};

Console.ReadKey();

/*
    ArrayList capacity é contado de 4 em 4 elementos 
 */
