using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Bem vindo a seu banco ByteBank!");

ContaCorrente conta = new ContaCorrente(321, "123456-L");
conta.Titular = new Cliente();
conta.Titular.Nome = "Felipe";
conta.Titular.Cpf = "123456784-69";
conta.Titular.Profissao = "Programador";
conta.Saldo = 1250.50;

Console.WriteLine($"Titular: {conta.Titular.Nome}");
Console.WriteLine($"CPF: {conta.Titular.Cpf}");
Console.WriteLine($"Profissão: {conta.Titular.Profissao}");
Console.WriteLine($"Conta: {conta.Conta}");
Console.WriteLine($"Numero da agência: {conta.NumeroAgencia}");
Console.WriteLine($"Saldo: {conta.Saldo.ToString("C2")}");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas + "\n");

ContaCorrente conta2 = new ContaCorrente(591, "594759-L");
conta2.Titular = new Cliente();
conta2.Titular.Nome = "Felipe 2";
conta2.Titular.Cpf = "114468494-67";
conta2.Titular.Profissao = "Analista";
conta2.Saldo = 1594.30;

Console.WriteLine($"Titular: {conta2.Titular.Nome}");
Console.WriteLine($"CPF: {conta2.Titular.Cpf}");
Console.WriteLine($"Profissão: {conta2.Titular.Profissao}");
Console.WriteLine($"Conta: {conta2.Conta}");
Console.WriteLine($"Numero da agência: {conta2.NumeroAgencia}");
Console.WriteLine($"Saldo: {conta2.Saldo.ToString("C2")}");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



Console.ReadKey();