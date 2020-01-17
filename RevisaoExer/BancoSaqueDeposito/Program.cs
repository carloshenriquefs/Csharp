using System;

namespace BancoSaqueDeposito
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banc = new Banco();

           Console.WriteLine("[ BANCO ]");
           Console.WriteLine();
           Console.Write("Entre o número da conta: ");
           int numeroConta = int.Parse(Console.ReadLine());
           Console.Write("Entre o titular da conta: ");
           string nomeTitular = Console.ReadLine();
           Console.WriteLine("Haverá depósito inicial (s/n)? ");
           char Escolha = char.Parse(Console.ReadLine());
           if(Escolha == 's' || Escolha == 'S')
           {
                Console.Write("Entre o valor de depósito inicial: ");
                double Saldo = double.Parse(Console.ReadLine());
                banc = new Banco(numeroConta, nomeTitular,Saldo);
           }
           else{
               banc = new Banco(numeroConta,nomeTitular);
           }

           Console.WriteLine("Dados da conta: "+banc);

            Console.Write("Entre um valor para depósito: R$");
            double deposito = double.Parse(Console.ReadLine());
            banc.Deposito(deposito);
            Console.WriteLine("Dados da Conta atualizados: "+banc);

            Console.Write("Entre um valor para saque: R$ ");
            double saque = double.Parse(Console.ReadLine());
            banc.Saque(saque);
            Console.WriteLine("Dados da Conta Atualizado: "+ banc);

        }
    }
}
