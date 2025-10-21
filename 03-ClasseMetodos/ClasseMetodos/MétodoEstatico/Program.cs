

Calculadora Resolucao = new Calculadora();

Calculadora.somar(5, 10);

// Método static  são métodos que pertencem à classe e não a uma instância específica de um objeto.
// Eles podem ser chamados diretamente na classe, sem a necessidade de criar um objeto da classe.

public class Calculadora()
{
    public static int somar(int a, int b)
    {
        return a + b;
    }
}
