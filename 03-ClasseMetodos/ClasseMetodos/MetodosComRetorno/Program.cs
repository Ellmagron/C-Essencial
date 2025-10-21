
Cadastro cadastro = new();
var cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);


//Alterar renda
cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda alterados", cliente);

public class Cliente {
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public Double Renda { get; set; }

    public Cliente(string? nome, int idade, double renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente() { 
    }

}


public class Cadastro
{

    public Cliente Registrar() 
    {
        Cliente cliente = new Cliente("Pedro", 26, 3000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados(Cliente cliente) {
        Console.WriteLine($"{cliente.Nome}  {cliente.Idade} {cliente.Renda}");
    }

    public void ExibirDados(string mensagem, Cliente cliente)
    {
        Console.WriteLine($"\n{mensagem}");
        Console.WriteLine($"{cliente.Nome} {cliente.Renda.ToString("c")}");
    }

}