using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Bem vindo a seu banco ByteBank!");
ContaCorrente conta = new ContaCorrente();
conta.DefinirSaldo(100);

Console.WriteLine(conta.RetornarSaldo());


Console.ReadKey();