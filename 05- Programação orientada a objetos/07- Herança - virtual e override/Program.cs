/*
    Herança - virtual e override
    Para permir que uma classe derivada utilize u membro (método, propriedade, indexador ou evento) de uma classe base e forneça uma nova implementação desse membro, além do operador new, C# oferece as palavras-chave virtual e override.

    Virtua: É uma palavra-chave usada na declaração de um mebro na classe base para indicar que esse membro pode ser sobrescrito em uma classe derivada.

    Override: É uma palavra chave usada na declração de um membro em uma classe derivada para indicar que esse membro substitui uma implementação herdada da classe base.

    Diferença entre new e virtua / override:
    - new: Oculta o membro herdado da classe base. A implementação original ainda está acessível através de uma referência do tipo da classe base.
    - virtual / override: Substitui o membro herdado da classe base. A implementação original não está mais acessível através de uma referência do tipo da classe base.
 */

Gato gato = new Gato(); // Utiliza o virtual e override para sobsescrever o método ExibiNome da classe base Animal.
gato.Nome = "Mingau";
gato.ExibiNome();

Cachorro cachorro = new Cachorro(); // Não sobrescreve o método ExibiNome da classe base Animal, então utiliza a implementação original.
cachorro.Nome = "Rex";
cachorro.ExibiNome();

public class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibiNome() => Console.WriteLine($"O meu nome é {Nome}"); //Usamdo o virtual para permitir que esse método seja sobrescrito em classes derivadas.
}

public class Gato : Animal
{
    public override void ExibiNome() => Console.WriteLine($"Eu sou um Gato meu nome é{ Nome}"); //Usando o override para sobrescrever o método ExibiNome da classe base Animal.
} 

public class Cachorro : Animal
{
}

