using _13__Indexadores;

Time time = new Time();

//Atribui valores = set;

time[1] = "Palmeiras";
time[3] = "Santos";
time[5] = "São Paulo";
time[7] = "Vasco";
time[-1] = "Flamengo";
time[1000] = "Bahia";

//Obtendo valores = get
string valor1 = time[1];
string valor3 = time[3];
string valor4 = time[5];
string valor5 = time[7];
string valor6 = time[-1];
string valor7 = time[1000];

//Exibir
Console.WriteLine(valor1);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);
Console.WriteLine(valor7);
