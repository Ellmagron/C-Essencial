


int x = 20;

Console.WriteLine("Valor do argumento x antes de passar por valor " + x);

Calculo calculo = new Calculo();
calculo.Dobrar(ref x);

Console.WriteLine("Valor do argumento x depois de passar por referencia" +  x);
public class Calculo
{

   public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("Valor do parâmetro y no metodo Dobrar 40");
    }
}