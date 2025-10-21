Console.WriteLine("## Métodos ");

minhaClasse m1 = new minhaClasse();
m1.saudacao();

minhaClasse data = new();
data.exibirDataAtual();

class minhaClasse
{
    public void saudacao()
    {
        Console.WriteLine("Bem-vindo");
        Console.WriteLine("08/08/2025");
    }

    public void exibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortTimeString());
    }

    
}