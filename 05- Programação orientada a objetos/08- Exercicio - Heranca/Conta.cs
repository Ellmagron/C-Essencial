namespace _08__Exercicio___Heranca
{
    public class Conta
    {
        public int Numero { get; set; }
        public string? Nome{ get; set; }
        public decimal Saldo { get; set; } = 0.00m;
        public virtual double Juros { get; set; } = 0.00;

        private decimal CalculaRemuneracao(double juros)
        {
            return Saldo * (decimal)Juros;
        }

        public virtual decimal Sacar(decimal valor) 
        {
            Console.WriteLine($" R${valor} foi depitado de sua conta");
            Saldo -= valor;
            return Saldo;
        }

        public decimal Depositar(decimal valor)
        {
            Console.WriteLine($"R${valor} foi depositado em sua conta");
            Saldo += valor;
            Saldo = Saldo + CalculaRemuneracao(Juros);
            return Saldo;
        }

        public void exibirSaldo()
        {
            Console.WriteLine($"O saldo da sua conta é de R${Saldo.ToString("C")}");
        }
    }

}
