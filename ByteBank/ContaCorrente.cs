using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public static double TaxaOperacao { get; private set; }
        public int Conta { get; }
        public int NumeroAgencia { get; }

        private string _nomeAgencia;
        public string NomeAgencia
        {
            get
            {
                return _nomeAgencia;
            }
            set
            {
                if (value != null)
                {
                    _nomeAgencia = value;
                }
                else
                {
                    throw new Exception("O campo NomeAgencia não pode ser nulo/vazio");
                }
            }
        }

        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (_saldo < 0)
                {
                    throw new Exception("Saldo não pode possuir um valor menor que 0");
                }
                _saldo = value;
            }
        }


        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            Conta = numeroConta;
            NumeroAgencia = numeroAgencia;

            //TaxaOperacao = 30 / TotalDeContasCriadas;

            if (numeroConta <= 0)
            {
                throw new ArgumentException("O numero da conta não pode ser menor ou igual a 0", nameof(numeroConta));
            }
            if (numeroAgencia <= 0)
            {
                throw new ArgumentException("O numero da agência não pode ser menor ou igual a 0", nameof(numeroAgencia));
            }


            TotalDeContasCriadas ++;
            
        }

        public ContaCorrente(Cliente titular, int conta, int numeroAgencia, string nomeAgencia, double saldo)
        {
            Titular = titular;
            Conta = conta;
            NumeroAgencia = numeroAgencia;
            NomeAgencia = nomeAgencia;
            Saldo = saldo;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                Console.WriteLine($"O saque não foi efetuado pois o valor de {valor:C2} é maior que o seu saldo atual de {Saldo:C2}");
                return false;
            }

            if (valor < 0)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente conta)
        {
            if (_saldo < valor)
            {
                return false;
            }

            if (valor < 0)
            {
                return false;
            }

            _saldo -= valor;
            conta._saldo += valor;
            return true;
        }



    }
}