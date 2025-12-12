using _12_ClassesAbstrataI;

// Forma forma = new Forma(); Erro: Não é possível instanciar uma classe abstrata

Quadrado quadrado = new Quadrado();
Console.WriteLine(quadrado.Descricao());

Console.WriteLine("\nInforme a cor da figura");
quadrado.Cor = Console.ReadLine();

Console.WriteLine("Informe o valor do lado do quadrado");
quadrado.Lado = Convert.ToInt32(Console.ReadLine());

quadrado.CalcularArea();
quadrado.CalcularPerimetro();

Console.WriteLine($"\n Área do quadrado : {quadrado.Area}");
Console.WriteLine($"\n Perímetro do quadrado: {quadrado.Perimetro}m");

Console.WriteLine($"\nO quadrado tem a cor : {quadrado.Cor}");
