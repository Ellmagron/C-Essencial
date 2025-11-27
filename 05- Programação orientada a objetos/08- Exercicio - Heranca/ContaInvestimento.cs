namespace _08__Exercicio___Heranca
{
    public class ContaInvestimento : Conta
    {
        public override double Juros { get; set; } = 0.009;
        public double Imposto{ get; set; } = 0.001;
        
        private decimal CalculaImposto(double Imposto)
        {
            return Saldo * (decimal)Imposto;
        }

        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Console.WriteLine($" R${valor} foi depitado de sua conta");
                Saldo = Saldo - valor - CalculaImposto(Imposto);
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
