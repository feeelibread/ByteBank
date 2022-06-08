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

Console.ReadKey();