using _08__Exercicio___Heranca;

Conta conta = new Conta();

conta.Numero = 1234;
conta.Nome = "Maria";
conta.exibirSaldo();
conta.Depositar(1000);
conta.exibirSaldo();
conta.Sacar(100);
conta.exibirSaldo();
conta.Sacar(2000);
conta.exibirSaldo();


Console.WriteLine();
Console.WriteLine("Conta poupança");
ContaPoupanca contaPoupanca = new ContaPoupanca();
contaPoupanca.Numero = 222;
contaPoupanca.Nome = "Jose";
contaPoupanca.exibirSaldo();
contaPoupanca.Depositar(1000);
contaPoupanca.exibirSaldo();
contaPoupanca.Sacar(100);
contaPoupanca.exibirSaldo();
contaPoupanca.Sacar(2000);
contaPoupanca.exibirSaldo();

Console.WriteLine();
Console.WriteLine("Conta poupança");
ContaInvestimento contaInvestimento = new ContaInvestimento();
contaInvestimento.Numero = 333;
contaInvestimento.Nome = "Maria";
contaInvestimento.exibirSaldo();
contaInvestimento.Depositar(1000);
contaInvestimento.exibirSaldo();
contaInvestimento.Sacar(100);
contaInvestimento.exibirSaldo();
contaInvestimento.Sacar(2000);
contaInvestimento.exibirSaldo();