using ByteBank;

Console.WriteLine("Bem vindo a seu banco ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Vinicius Cristo vão";
conta1.conta = "68464-X";
conta1.nomeAgencia = "Gilmar Bancus";
conta1.numeroAgencia = 69;
conta1.saldo = 6900.00;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Felipus Pichininus";
conta2.conta = "68464-X";
conta2.nomeAgencia = "Hankus Bancus";
conta2.numeroAgencia = 89;
conta2.saldo = 2800.00;

Console.WriteLine($"Conta pré-transferencia: conta1 saldo {conta1.saldo:C2}, e conta2 saldo {conta2.saldo}");
conta1.Transferir(200, conta2);
Console.WriteLine($"Conta pós-transferencia: conta1 saldo {conta1.saldo:C2}, e conta2 saldo {conta2.saldo}");

Console.ReadKey();