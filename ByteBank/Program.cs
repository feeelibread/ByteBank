using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Bem vindo a seu banco ByteBank!");

//Cliente cliente = new Cliente();
//cliente.nome = "Felipe Ferreira";
//cliente.cpf = "12324884669";
//cliente.profissao = "Desenvolvedor C# Junior";

ContaCorrente conta = new ContaCorrente();
//conta.titular = new Cliente();
//conta.titular.nome = "felipe ferreira";
//conta.titular.cpf = "12324884669";
//conta.titular.profissao = "desenvolvedor c# junior";
conta.conta = "102030-Z";
conta.numeroAgencia = 67;
conta.nomeAgencia = "Dedonocool";
conta.saldo = 1635.50;

//Console.WriteLine(conta.titular.nome);

if (conta.titular == null)
{
    Console.WriteLine("A referencia está nula, instancie o objeto");
}

Console.ReadKey();