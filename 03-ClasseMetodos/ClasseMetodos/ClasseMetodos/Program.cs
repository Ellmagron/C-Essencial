Console.WriteLine("## Classes e métodos ##");




Console.WriteLine("Criando uma pessoa...");
pessoa p1 = new pessoa();
Console.WriteLine("Atribuindo valores...");
p1.Nome = "João";
p1.Idade = 25;
p1.Sexo = "Masculino";

Console.WriteLine($"Nome: {p1.Nome} Idade: {p1.Idade} Sexo: {p1.Sexo}");

Console.WriteLine();
Console.WriteLine("Criando uma pessoa...");
pessoa p2 = new pessoa();
Console.WriteLine("Atribuindo valores...");
p1.Nome = "Maria";
p1.Idade = 30;
p1.Sexo = "Feminino";

Console.WriteLine($"Nome: {p1.Nome} Idade: {p1.Idade} Sexo: {p1.Sexo}");
class pessoa
{
    public string? Nome { get; set; }

    public int Idade { get; set; }

    public string? Sexo { get; set; }
}