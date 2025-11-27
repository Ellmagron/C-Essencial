/*Modificadores de acesso

public:

private:

Protect: Um membro com modificador protecdet é acessível dentro da sua classe e por instâncias das classes derivadas.
-Uma classe derivada tem acesso aos membros definidos com o modificador public, internal, protected e protected e protected internal de uma base.
Membros com o modificador com o modificador private emvora seham herdados não são acessíveis pela classe derivada(subclasse).

Os membros privados estão presentes na classe derivada  de forma a atuar e fazer o mesmo trabalho que fariam na classe base, mas não podem ser acessados diretamente pela classe derivada.

Static:

 */

ClasseDerivada cd = new ClasseDerivada();

cd.VerificaAcesso();


public class ClasseDerivada : classeBase 
{
    public void VerificaAcesso() 
    {
        Public_Mmembro();
        Protected_Mmembro();
        Private_Internal_Mmembro();
        Internal_Mmembro();
        //Private_Mmembro(); // Não é possível acessar membros privados da classe base

        Console.WriteLine("");
        Console.WriteLine("Acesso ao campo private: private_car usando uma propriedade");
        int soma = public_var + protected_var + internal_var + Private_var;
        Console.WriteLine($"Total soma: {soma}");
    }
}



public class classeBase 
{

    //Campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;

    //Defenindo uma porpriedade para acessar o campo private_var
    public int Private_var {
        get { return private_var; }
        set { private_var = value; }
    }


    public void Public_Mmembro() 
    {
        Console.WriteLine("ClasseBase - Método Public");
    }

    protected void Protected_Mmembro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }

    internal void Internal_Mmembro()
    {
        Console.WriteLine("ClasseBase - Método internal");
    }

    protected internal void Private_Internal_Mmembro()
    {
        Console.WriteLine("ClasseBase - Método protected internal");
    }

    internal void Private_Mmembro()
    {
        Console.WriteLine("ClasseBase - Método Private");
    }
}