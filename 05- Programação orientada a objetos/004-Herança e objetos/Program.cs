/*
   Todas as classes derivam da classe Object, e, a classe Object não deriva de nenhuma outra classe. 
   Ela é a classe Base(pai) de todas as outras classes em C#.

    A classe Object dá suporte a todas  as classes na hierarquia de classes do .NET e fornece serviços de baixo nível para as classes derivadas.

    Os métodos definidos na classe Object estão disponiveis em todos os objetos do sistema e as classes derivadas podem substituir esses métodos para fornecer implementações específicas.

    Serviço de baixo nível significa que a classe Object fornece funcionalidades básicas que todas as classes em C# herdam automaticamente, como:

    - Métodos para comparar objetos (Equals, GetHashCode)
    - Métodos para obter informações sobre o tipo do objeto (GetType)
    - Métodos para representar o objeto como uma string (ToString)
    - Métodos para manipulação de memória (Finalize)
    - Métodos para clonagem de objetos (MemberwiseClone)
    - Outros métodos úteis para manipulação de objetos

 */


//Exemplo de classe herdando da classe Object e seus serviços de baixo nível implicitamente
Nada nada = new Nada();
nada.Equals(null);
nada.GetType();


class Nada {
    
}

// Classe derivada não pode herdar multipals classes base
// Classes não herdam de struct

public struct MinhaStruct
{
}

public class Classe1 {
}


public class Classe2
{
}

public class ClasseDerivada : Classe1 //, Classe2  <- Isso não é permitido em C#
{
}

public class ClasseDerivada2 : MinhaStruct // <- Isso não é permitido em C#
{
}

// Heranças multipals é possível através apenas de interfaces


/*
 * O wque é um struct?
  - Structs são tipos de valor que permitem agrupar dados relacionados em uma única unidade.
    - Eles são usados para representar objetos simples e imutáveis, como pontos em um espaço 2D, cores, ou coordenadas geográficas.
    - Structs são alocados na stack, o que pode resultar em melhor desempenho para pequenos objetos.
    - Diferença entre struct e classe
    - Structs são tipos de valor, enquanto classes são tipos de referência.
    - Structs são alocados na stack, enquanto classes são alocados no heap.
    - Structs não suportam herança, enquanto classes suportam herança.
    - Structs são geralmente usados para representar objetos pequenos e imutáveis, enquanto classes são usadas para objetos maiores e mutáveis.
    - Onde devo utilizar structs?
    - Quando se deseja representar objetos simples e imutáveis.
Como se representa uma struct? 
   - Utilizando a palavra-chave struct seguida do nome da struct e suas propriedades e métodos.
Exemplo de struct:
using System;
struct Ponto2D
{
    public int X { get; set; }
    public int Y { get; set; }
    public Ponto2D(int x, int y)
    {
        X = x;
        Y = y;
    }
    public double DistanciaAoOrigem()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
 */