/*  Operador as 
 Onde e porque usar o operador as em C#?
 O operador as em C# é usado para realizar conversões seguras de tipos. Ele tenta
    converter um objeto para um tipo específico e, se a conversão falhar, retorna null em vez de lançar uma exceção. Isso é útil quando você não tem certeza se o objeto pode ser convertido para o tipo desejado e quer evitar o custo de tratamento de exceções.
    Exemplo pratico de uso do operador as onde ele é essencial:
 */
using _10_DowcastingEUpcasting;

Object carroObj = new Carro();


//Exemplo sem o uso do operador as

try
{
    var x = (string)carroObj; // Isso lançará uma InvalidCastException
}
catch (Exception ex)
{
    Console.WriteLine("\nConversão falhou com cast direto.\n");
    Console.WriteLine(ex.Message);
}

//Exemplo com o uso do operador as
var y = carroObj as string; // Isso retornará null em vez de lançar uma exceção
if (y != null)
{
    Console.WriteLine("Conversão bem-sucedida: " + y);
}
else
{
    Console.WriteLine("\nConversão falhou com o operador as, retornando null.\n");
}

Circulo circulo = new Circulo(20, 20);
Forma forma = circulo; // Upcasting implícito

Circulo c = forma as Circulo; // Downcasting seguro com o operador as


if (c != null)
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Dowcasting falhou, retornando null.");
}


/*Operador is
    É utilizado para verificar se um objeto é de um tipo específico antes de realizar uma conversão.
    Onde e porque usar o operador is em C#?
    O operador is em C# é usado para verificar se um objeto é de um tipo específico. Ele retorna true se o objeto puder ser convertido para o tipo especificado e false caso contrário. 
    Isso é útil para garantir que uma conversão seja segura antes de realizá-la, evitando exceções em tempo de execução.
    Exemplo pratico de uso do operador is onde ele é essencial:
 */

Circulo circulo1 = new Circulo(15, 15);
Forma forma1 = circulo1; // Upcasting implícito

if (forma is Circulo) // Verificação segura com o operador is
{
    Console.WriteLine("Converteu Forma para Circulo");
    var tipo = forma1 as Circulo;
    tipo?.PintarCirculo();
}
else
{
       Console.WriteLine("Não é possível converter Forma para Circulo");

}


//Exemplo usando dowcasting seguro com o operador as
class Carro { }