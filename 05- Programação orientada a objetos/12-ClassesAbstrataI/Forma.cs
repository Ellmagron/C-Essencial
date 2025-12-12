namespace _12_ClassesAbstrataI;

/*A classes abstratas
 Porque usar classes abstratas?
    - Fornecem um modelo base para outras classes derivadas.
    O que seria um modelo base?
    - Definem propriedades e métodos comuns que todas as classes derivadas devem implementar.
 Onde usar classes abstratas?
    - Quando você tem uma classe que não deve ser instanciada diretamente, mas serve como base para outras classes.
    Exemplo: Classe Forma geométrica que serve como base para classes como Quadrado, Círculo, Triângulo, etc.
 */
public abstract class Forma
{
    //Propriedades
    public string? Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    //Métodos abstratos <- Não possuem implementação aqui na classe base abstrata
    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    //Método comum
    public string Descricao() 
    {
        return "Eu sou uma forma geométrica.";
    }

}
