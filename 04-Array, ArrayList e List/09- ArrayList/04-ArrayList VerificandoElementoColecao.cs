using System.Collections;


/*Métodos uteis quando se está trabalhando com array list*/
public class _09__ArrayList2
{
    private static void Main(string[] args)
    {
        var lista = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

        Console.WriteLine("ArrayList Original \n");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        // Verificando se um elemento existe no ArrayList
        bool existeAna = lista.Contains("Ana"); // Retorna true se "Ana" estiver na lista, caso contrário, false

        Console.WriteLine(existeAna);

        //Ordenando os elementos do ArrayList obs: elementos devems ser do mesmo tipo.
        Console.WriteLine("\nArrayList Ordenado \n");
        lista.Sort(); // Ordena os elementos em ordem crescente (alfabética para strings)
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        // Invertendo a ordem dos elementos no ArrayList
        Console.WriteLine("\nArrayList Invertido \n");
        lista.Reverse(); // Inverte a ordem dos elementos
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Número de elementos de um array \n" + lista.Count);

        //Limpando um array list

        lista.Clear(); // Remove todos os elementos do ArrayList


        /*
            Detalhes: ArrayList apesar de ter sido projeto para trabalahr com coleções de elementos heterogêneas(elementos de difentes tipos), ele não oferece um bom desempenho, porque tudo armazenado em um arrayList é convertido para um objeto(que é o que chamamos de boxing- tipo valor para um objeto e Unboxing quando é de um objeto para tipo valor).

            Para trabalhar com coleções heterogêneas de forma mais eficiente, é recomendado utilizar a classe List<object> do namespace System.Collections.Generic, que oferece melhor desempenho e flexibilidade. E para coleções homogêneas (elementos do mesmo tipo), é recomendado utilizar List<T>, onde T é o tipo específico dos elementos na coleção.




         
        */

    }
}

