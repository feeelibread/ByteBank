using ByteBank;
using ByteBank.Titular;

try
{
    //Metodo();
    ContaCorrente conta = new ContaCorrente(0, 512);
    Console.ReadLine();
}
catch (NullReferenceException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
catch(ArgumentException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ParamName);

}


static void Metodo()
{
    TestaDivisao(0);
}

static void TestaDivisao(int divisor)
{

    int resultado = Dividir(10, divisor);
    Console.WriteLine("O resultado da divisão é: " + resultado);

}

static int Dividir(int numero, int divisor)
{
    try
    {
        return numero / divisor;
    }
    catch
    {
        Console.WriteLine($"Ocorreu um erro! Os numeros usados na operação de dividir foram: Numero = {numero} e divisor = {divisor}");
        throw;
    }
    
}