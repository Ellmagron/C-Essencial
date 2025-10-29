using System.Collections;

    /*Existe duas maneiras de se adicionar elementos a um array list
     1- Utilizando o método Add() Método add sempre adiciona o elemento no final do array list, indepentende do tamanho ou elemento que está sendo adicionado
     2- Utilizando o método insert() Método insert permite adicionar um elemento em uma posição específica do array list, deslocando os elementos subsequentes para a direita.
    
    2- Utilizando inicializadores de objeto (object initializers) para criar um array list com elementos predefinidos.
   
     */

    var lista = new ArrayList() { "Maria", 5, true, " ", null };

   lista.Add("João"); // Adiciona "João" no final do array list
    lista.Insert(2, 3.14); // Adiciona 3.14 na posição 2 do array list
Console.ReadKey();


/*
    Adicionando uma coleção de elementos a um ArrayList
    - Seguinto o mesmo principo de adicionar um elemento indepentende em um array, temos 2 forma.

    1- Utilizando o método AddRange() Método AddRange permite adicionar uma coleção de elementos (como um array ou outra coleção) ao final do ArrayList.
    2- Utilizando o método InsertRange() Método InsertRange permite adicionar uma coleção de elementos em uma posição específica do ArrayList, deslocando os elementos subsequentes para a direita.

 */

var lista2 = new ArrayList() { "Maria", 5, true };

int[] array1 = { 1, 2, 3 };

lista2.AddRange(array1); // Adiciona os elementos do array1 ao final do lista2
lista2.InsertRange(2, array1); // Adiciona os elementos do array1 a partir do índice 1 do lista2