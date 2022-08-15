using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public static double TaxaOperacao { get; private set; }

        private string _conta;
        public string Conta
        {
            get { return _conta; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Não é possível atribuir um valor nulo a conta");
                }
                else
                {
                    _conta = value;
                }
            }
        }

        private int _numeroAgencia;
        public int NumeroAgencia
        {
            get { return _numeroAgencia; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O numero da agência não pode ser menor ou igual a 0");
                }
                else
                {
                    _numeroAgencia = value;
                }
            }
        }

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
                    return;
                }
                _saldo = value;
            }
        }


        public ContaCorrente(int numeroAgencia, string conta)
        {
            Conta = conta;
            NumeroAgencia = numeroAgencia;

            TaxaOperacao = 30 / TotalDeContasCriadas;
            TotalDeContasCriadas ++;
            
        }

        public ContaCorrente(Cliente titular, string conta, int numeroAgencia, string nomeAgencia, double saldo)
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