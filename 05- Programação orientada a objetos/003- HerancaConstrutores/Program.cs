/* 
    Construtores
    - Tanto uma classe derivada quanto sua classe base podem ter construtores.
    - A classe derivada não herda o construtor da classe base. Mas pode chamar o construtor da classe base usando a palavra-chave base.
    - Ao criar uma instância de uma classe derivada, o construtor da classe base é chamado primeiro, seguido pelo construtor da classe derivada.

 */

Aluno aluno1 = new Aluno();
Aluno aluno2 = new Aluno("Pedro");

//Classe base
class Pessoa 
{
  public  Pessoa()
    {
        Console.WriteLine("Construtor da classe pessoa");
    }

    //   - Para usar um construtor de uma classe base dentro de um contrutor da classe derivada, usamos a palavra-chave base seguida dos parâmetros apropriados.
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe pessoa com parâmetro:");
    }

}


//Classe derivada
class Aluno : Pessoa
{
    public Aluno() :base()
    {
        Console.WriteLine("Construtor da classe aluno");
    }

    //   - Para usar um construtor de uma classe base dentro de um contrutor da classe derivada, usamos a palavra-chave base seguida dos parâmetros apropriados.
    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("Construtor da classe aluno com parâmetro:");
    }
}