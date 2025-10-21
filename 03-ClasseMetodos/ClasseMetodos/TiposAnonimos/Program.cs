Console.WriteLine("Tipo anonimo");


var Aluno = new
{
    Nome = "João",
    Idade = 30,
    Profissao = "Desenvolvedor",
    Endereco = new
    {
        Rua = "Rua A",
        Numero = 100,
        Cidade = "São Paulo"
    }
};

// Tipos anônimos são usados para criar objetos sem a necessidade de definir uma classe explicitamente.
// Eles são úteis quando você precisa de um objeto temporário para armazenar dados sem a necessidade de criar uma classe separada.
// server apenas para leitura, não pode ser modificado após a criação.
// são frequentemente usados em consultas LINQ para projetar resultados de consultas em objetos temporários.
// Eles não têm nome e são definidos no momento da criação, o que os torna úteis para cenários onde você não precisa reutilizar a estrutura de dados em outro lugar.

//Aluno.Nome = "Maria"; // Isso causará um erro de compilação, pois os tipos anônimos são imutáveis.
// é possivel criar um tipo anonimo dentro de outro tipo anonimo


Console.WriteLine($"{Aluno.Nome} {Aluno.Idade} {Aluno.Profissao}");

Console.WriteLine($"Obtendo nome do tipo anonimo {Aluno.GetType().Name.ToString()} dentro do compilador");

Console.WriteLine($"Tipo anonimo aninhado: {Aluno.Endereco.Cidade}");