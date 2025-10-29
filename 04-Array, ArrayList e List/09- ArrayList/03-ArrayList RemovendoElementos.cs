/*
    Removendo elementos de um array list
    
    -Existe 3 maneiras de se remover elementos de um array list
    
    1   Remove(). Remove o primeiro elemento que corresponde ao valor especificado.
    2-  RemoveAt() . Remove o elemento no índice especificado.
    3-  RemoveRange(). Remove um intervalo de elementos começando em um índice especificado e removendo um número especificado de elementos 
*/

using System.Collections;

public  class _09__ArrayList
{
    private static void Main(string[] args)
    {
        var lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "zé", 3, 9, null };


        // Removendo a primeira ocorrêñcia de um elemento específico
        lista.Remove(null); // Remove a primeira ocorrência de null, não todas, apenas a primeira

        // Removendo um elemento em um índice específico
        lista.RemoveAt(2); // Remove o elemento no índice 2 (true)

        // Removendo um intervalo de elementos
        lista.RemoveRange(0, 2); // Remove 2 elementos começando do índice 0 ("Ana", 5)
      
    }
}