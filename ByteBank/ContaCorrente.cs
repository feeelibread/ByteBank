using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public string Conta { get; set; }
        public int NumeroAgencia { get; set; }
        public string NomeAgencia { get; set; }
        private double _saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine($"O saque não foi efetuado pois o valor de {valor:C2} é maior que o seu saldo atual de {saldo:C2}");
                return false;
            }

            if (valor < 0)
            {
                return false;
            }

            saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente conta)
        {
            if (saldo < valor)
            {
                return false;
            }

            if (valor < 0)
            {
                return false;
            }

            saldo -= valor;
            conta.saldo += valor;
            return true;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if(_saldo < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

    }
}