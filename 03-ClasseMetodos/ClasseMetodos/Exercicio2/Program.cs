
int valor = 10;

Console.WriteLine($"Valor original da variavel  {valor}");
Calculo resol = new Calculo();

Console.WriteLine("Resultado do metodo com passagem de por valor " + resol.Aumentar(valor));


Console.WriteLine("Resultado do metodo com passagem de por referencia" + resol.Aumentar(ref valor));

Console.WriteLine("Resultado da variavel original depois de passagem de argumento por referencia" + valor);

Console.WriteLine($"\n resultado da potencia do método do método AumentarVelocidade {resol.AumentarVelocidade(valor, out double velocidade)}");
Console.WriteLine($"Resutlso da velocidade, usando o out sem precisar denifinir a variavel  {velocidade}");

/*
  -Exercicio 
    Argmento nomeados e opcionais
 */

resol.ExibirInfo(Modelo: "Civic", Montadora: "Honda", Marca: "Honda", potencia: 150, ano: 2024);

resol.ExibirInfo(Modelo: "Civic", Montadora: "Honda", Marca: "Honda", potencia: 150);




public class Calculo
{
   public int Aumentar(int potencia)
    {
        return potencia += 3;
    }

    public int Aumentar(ref int potencia)
     {
         return potencia += 5;
     }

    //Exercicio usando out
    /*
        Assim como ref, out também é usado para passar argumentos por referência.
    A diferença é que, ao usar out, a variável passada não precisa ser inicializada antes de ser passada para o método.
    No entanto, o método chamado deve atribuir um valor à variável antes de o método retornar.
    Out é útil quando você deseja que um método retorne múltiplos valores.
    Já ref é usando quando deseja retornar um valor e modificar o valor original da variável passada.

     */

    public int AumentarVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }


    /*
        Argumentos opcionais ou argumenos default = padrão é quando você define um valor paradrão para um parametro na definição de um método   
        Isso significa que, se o usuário não fornecer um valor para esse parâmetro ao chamar o método, o valor padrão será usado.
        Detalhe importante: os argumentos opcionais devem ser definidos após os parâmetros obrigatórios na assinatura do método.
    */

    /*
    Usando parametros nomeados, não é preciso se inportar com a ordem dos argumentos
    Eles funcionam como se fossem um dicionário, onde o nome do parametro é a chave e o valor é o valor contido no valor.
 */
    public void ExibirInfo(string Modelo, string Montadora, string Marca, int potencia, int ano = 2025)
    {
           Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Montadora: {Montadora}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Potência: {potencia}");
        Console.WriteLine($"Ano: {ano}");
     }
}
