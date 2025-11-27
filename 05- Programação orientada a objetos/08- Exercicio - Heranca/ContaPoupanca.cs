namespace _08__Exercicio___Heranca
{
    public class ContaPoupanca : Conta
    {
        public override double Juros { get; set; } = 0.005;

        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Console.WriteLine($" R${valor} foi depitado de sua conta");
                Saldo -= valor;
                return Saldo;
            }
            else
            {
                Console.WriteLine("Operação negada. Saldo indisponivel");
                return Saldo;
            }
        }
    }
}
