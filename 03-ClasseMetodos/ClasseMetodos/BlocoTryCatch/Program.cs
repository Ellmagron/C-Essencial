Console.WriteLine("## Divisao Números inteiros");

Console.WriteLine("Digite o primeiro número");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
int y = Convert.ToInt32(Console.ReadLine());





/*
    Try catch
é um recurso para fazer o tratamento de erros
    O bloco try contém o código que pode gerar uma exceção, enquanto o bloco catch é usado para capturar e tratar essa exceção.
    O bloco finally é opcional e sempre será executado, independentemente de uma exceção ter sido lançada ou não.
    bloco try: é onde é o executado o código que pode gerar uma exceção ou é supostamente onde o código que deve funcionar sem erros.
// bloco catch: é onde é capturada a exceção e é possível tratar o erro, como exibir uma mensagem de erro ou registrar o erro em um log.
// bloco finally: é onde é executado o código que deve ser executado independentemente de uma exceção ter sido lançada ou não, como fechar conexões de banco de dados ou liberar recursos.
 */
try
{
    int z = x / y;
    Console.WriteLine($"{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("Não é possível realizar divisão por 0. tente outro número");
    Console.WriteLine($"Descrição do erro {ex.Message}");
    Console.WriteLine($"Local do erro {ex.StackTrace}");
}
finally
{
    Console.WriteLine("Processamento concluido");
}