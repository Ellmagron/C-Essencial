Console.WriteLine("## Métodos parametros");


minhaClasse m1 = new minhaClasse();

m1.saudacao("João", DateTime.Now.ToShortTimeString());

class minhaClasse
{
    public void saudacao(string nome, string data)
    {
        Console.WriteLine($"Bem-vindo, {nome}");
        Console.WriteLine($"{data}");

    }
}

