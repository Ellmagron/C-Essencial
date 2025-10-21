
ContaCorrente c1 = new ContaCorrente();

c1.Conta = 12345;
c1.Nome = "João da Silva";
//c1.Juros = 0.05f;

ContaCorrente c2 = new ContaCorrente();
c2.Conta = 67890;
c2.Nome = "Maria Oliveira";
//c2.Juros = 0.03f;

ContaCorrente.Juros = 0.05f;


Console.WriteLine($"{c1.Nome} {c1.Conta} {c1.JurosAnual()}");
Console.WriteLine($"{c2.Nome} {c2.Conta} {c2.JurosAnual()}");

public class ContaCorrente
{
    public string? Nome;
    public int Conta;
    public static float Juros;
    /*
     Membros estáticos são membros que pertencem à classe em si, e não a uma instância específica da classe.
    Eles são compartilhados por todas as instâncias da classe e podem ser acessados diretamente através do nome da classe, sem a necessidade de criar um objeto da classe.
     */

    public float JurosAnual() {
        return Juros * 12;
    }
}