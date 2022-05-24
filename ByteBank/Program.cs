using ByteBank.Titular;

Console.WriteLine("Bem vindo a seu banco ByteBank!");

Cliente cliente = new Cliente();
cliente.nome = "Felipe Ferreira";
cliente.cpf = "12324884669";
cliente.profissao = "Desenvolvedor C# Junior";

Console.WriteLine(cliente.nome);

Console.ReadKey();