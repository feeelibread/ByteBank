using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Bem vindo a seu banco ByteBank!");
ContaCorrente conta1 = new ContaCorrente(23, "14259-89");

Console.WriteLine(ContaCorrente.TaxaOperacao);
Console.ReadKey();