
using ExercicioHerancaBanco;

Console.WriteLine("\nConta Corrente : Numero : 111 Titular : Maria");
Conta conta = new Conta();
conta.Numero = 111;
conta.Titular = "Maria";

Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da Conta : {conta.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da Conta : {conta.Saldo.ToString("c")}");

Console.WriteLine("\nConta Poupança : Numero : 222 Titular : José");
ContaPoupanca contaPoupanca = new ContaPoupanca();
contaPoupanca.Numero = 222;
contaPoupanca.Titular = "José";
Console.WriteLine("Depositando R$ 1.000,00");
contaPoupanca.Depositar(1000);
Console.WriteLine($"Saldo da Conta : {contaPoupanca.Saldo.ToString("c")}");
contaPoupanca.Sacar(100);
Console.WriteLine($"Saldo da Conta : {contaPoupanca.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 2.000,00");
contaPoupanca.Sacar(2000);
Console.WriteLine($"Saldo da Conta : {contaPoupanca.Saldo.ToString("c")}");



Console.WriteLine("\nConta Investimento : Numero : 333 Titular : Paulo");
ContaInvestimento contaInvestimento = new ContaInvestimento();
contaInvestimento.Numero = 333;
contaInvestimento.Titular = "Paulo";
contaInvestimento.Depositar(1000);
Console.WriteLine("Depositando R$ 1.000,00");
Console.WriteLine($"Saldo da Conta : {contaInvestimento.Saldo.ToString("c")}");
contaInvestimento.Sacar(100);
Console.WriteLine($"Saldo da Conta : {contaInvestimento.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 2.000,00");
contaInvestimento.Sacar(2000);
Console.WriteLine($"Saldo da Conta : {contaInvestimento.Saldo.ToString("c")}");
Console.ReadLine();