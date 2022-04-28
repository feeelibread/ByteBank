Console.WriteLine("Bem vindo a seu banco ByteBank!");

string nome = "Felipe Piquinique";
string conta = "10123-X";
int numeroAgencia = 42;
string nomeAgencia = "Alliance Bank";

double saldo = 200.50;
Console.WriteLine($"Titular: {nome}");
Console.WriteLine($"Conta: {conta}");
Console.WriteLine($"Nome da agência: {nomeAgencia}");
Console.WriteLine($"Numero da agência: {numeroAgencia}");
Console.WriteLine($"Saldo da conta: {saldo.ToString("C2")}");
Console.ReadKey();