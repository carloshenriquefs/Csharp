using System;

namespace Byte_Bank_2
{
    class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente(int agencia, int numeroconta, string nometitular)
        {
            this.Titular = nometitular;
            this.Agencia = agencia;
            this.Numero = numeroconta;
            this.Saldo = 0.0;
        }

    
    }
}
