using System;

namespace Byte_Bank
{
    class ContaCorrente
    {
       public Cliente Titular {get;set;}
       public int Agencia {get;set;}
       public int Numero {get;set;}
       public double Saldo {get;set;}

       public ContaCorrente (int agencia, int numero, Cliente Titular)
       {
           this.Titular = Titular;
           this.Agencia = agencia;
           this.Numero = numero;
           this.Saldo = 0.0;
       }

       public double Deposito(double valor)
       {
           this.Saldo = Saldo + valor;
           return this.Saldo;
       }

       public bool Saque(double valor)
       {
           if(valor < this.Saldo)
           {
               this.Saldo = Saldo - valor;
               return true;
           }
           else
           {
               return false;
           }
       }

       public bool Transferencia(ContaCorrente destino, double valor)
       {
           if(Saque(valor))
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