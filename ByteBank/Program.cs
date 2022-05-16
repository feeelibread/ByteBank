using ByteBank.Titular;

Console.WriteLine("Bem vindo a seu banco ByteBank!");

Titular titular = new Titular();
titular.nome = "Felipe Ferreira";
titular.cpf = "12324884669";
titular.profissao = "Desenvolvedor C# Junior";

Console.WriteLine(titular.nome);

Console.ReadKey();