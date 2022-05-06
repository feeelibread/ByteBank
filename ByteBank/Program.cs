using ByteBank;

Console.WriteLine("Bem vindo a seu banco ByteBank!");

ContaCorrente conta1 = new ContaCorrente();


conta1.titular = "Felipe";
conta1.conta = "15926-X";
conta1.nomeAgencia = "Strattovarius";
conta1.numeroAgencia = 64;
conta1.saldo = 159.52;

Console.WriteLine("Conta 1");
Console.WriteLine($"Titular: {conta1.titular}");
Console.WriteLine($"Conta: {conta1.conta}");
Console.WriteLine($"Nome da agência: {conta1.nomeAgencia}");
Console.WriteLine($"Numero da agência: {conta1.numeroAgencia}");
Console.WriteLine($"Saldo da conta: {conta1.saldo:C2}");

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Vinicius Cristo vão";
conta2.conta = "68464-X";
conta2.nomeAgencia = "Gilmar Bancus";
conta2.numeroAgencia = 69;
conta2.saldo = 6900.00;

Console.WriteLine("\nConta 2");
Console.WriteLine($"Titular: {conta2.titular}");
Console.WriteLine($"Conta: {conta2.conta}");
Console.WriteLine($"Nome da agência: {conta2.nomeAgencia}");
Console.WriteLine($"Numero da agência: {conta2.numeroAgencia}");
Console.WriteLine($"Saldo da conta: {conta2.saldo:C2}");

ContaCorrente conta3 = new ContaCorrente();
Console.WriteLine("\nConta 3 - Valor padrão dos campos (sem atribuição)");
Console.WriteLine($"Titular: {conta3.titular}");
Console.WriteLine($"Conta: {conta3.conta}");
Console.WriteLine($"Nome da agência: {conta3.nomeAgencia}");
Console.WriteLine($"Numero da agência: {conta3.numeroAgencia}");
Console.WriteLine($"Saldo da conta: {conta3.saldo:C2}");
Console.WriteLine($"Validação: {conta3.validacao}");

Console.ReadKey();