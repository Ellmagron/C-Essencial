using _23_ExercicioPessoa2;

int total = 3;
Pessoa[] Pessoa = new Pessoa[total];

for (int i = 0; i < total; i++)
{
    Console.WriteLine("Infomr o nome " + i);
    Pessoa[i] = new Pessoa(Console.ReadLine());
}

for (int i = 0; i < total; i++)
{
    Console.WriteLine(Pessoa[i].ToString());
}