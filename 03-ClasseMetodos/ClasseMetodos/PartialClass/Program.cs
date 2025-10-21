using PartialClass;

Console.WriteLine("Partial class \n");

MinhaPartialClass props = new ();

Console.WriteLine("Idade para nascidos em: 07/08/2003\n");

var idade = props.CalculaIdade(new DateTime(2003, 8, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\nIdade para os nascidos em: 02/06/2005");

var data  = DateTime.Now;
var idade2 = new DateTime(2005, 6, 2);
var diferenca = props.DiferencaEntreDatas(data, idade2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays/ 365)} anos");
