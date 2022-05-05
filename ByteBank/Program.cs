using ByteBank;

Console.WriteLine("Bem vindo a seu banco ByteBank!");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Felipe";
conta1.conta = "15926-X";
conta1.nomeAgencia = "Strattovarius";
conta1.numeroAgencia = 64;
conta1.saldo = 159.52;



Console.WriteLine($"Titular: {conta1.titular}");
Console.WriteLine($"Conta: {conta1.conta}");
Console.WriteLine($"Nome da agência: {conta1.nomeAgencia}");
Console.WriteLine($"Numero da agência: {conta1.numeroAgencia}");
Console.WriteLine($"Saldo da conta: {conta1.saldo:C2}");
Console.ReadKey();