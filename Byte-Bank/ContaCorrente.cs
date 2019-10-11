using System;

namespace Byte_Bank
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _Saldo;

        public double saldo
        {
            get { return _Saldo; }
        }

        public ContaCorrente(int agencia, int numero, Cliente Titular)
        {
            this.Titular = Titular;
            this.Agencia = agencia;
            this.Numero = numero;
            this._Saldo = 0.0;
        }

        public double Deposito(double valor)
        {
            bool AgoraVai = false;
            do
            {
                Console.WriteLine("Informe o valor do Saldo: R$");
                int saldo = int.Parse(Console.ReadLine());
                if (saldo > 0)
                {
                    AgoraVai = true;
                }
                else
                {
                    AgoraVai = false;
                }
            } while (AgoraVai != true);

            this._Saldo = _Saldo + valor;
            return this._Saldo;
        }

        public bool Saque(double valor)
        {
            bool Saque = false;
            do
            {
                Console.WriteLine("Informe o Saque: R$");
                double saque = double.Parse(Console.ReadLine());
                if (saque > 0)
                {
                    Saque = true;
                }
                else
                {
                    Saque = false;
                }
            } while (Saque != true);

            if (valor < this._Saldo)
            {
                this._Saldo = _Saldo - valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferencia(ContaCorrente destino, double valor)
        {
            if (Saque(valor))
            {
                destino.Deposito(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
