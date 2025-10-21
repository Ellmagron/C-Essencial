Console.WriteLine("## Marametro nomeados");

Email mensagem = new Email();

// Usando a ordem dos parâmetros
mensagem.Enviar("teste@gmail.com", "normal", "Assunto do email");

/*
    Usando parametros nomeados, não é preciso se inportar com a ordem dos argumentos
    Eles funcionam como se fossem um dicionário, onde o nome do parametro é a chave e o valor é o valor contido no valor.
 */
mensagem.Enviar(titulo: "normal", assunto: "vivemos aqui, FORA!", destino: "teste@gmail.com");

public class Email
{
    public void Enviar(string titulo, string assunto, string destino)
    {
        Console.WriteLine($"Para {destino}, titulo {titulo} assunto {assunto}");
    }
}