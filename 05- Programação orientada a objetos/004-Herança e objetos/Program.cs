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