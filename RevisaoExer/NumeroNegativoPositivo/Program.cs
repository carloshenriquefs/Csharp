using System;

namespace NumeroNegativoPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro, e depois
            //dizer se este número é negativo ou não.

            Console.WriteLine("    [ INFORME ]");
            Console.WriteLine();
            Console.Write("Um valor: ");
            int numero = int.Parse(Console.ReadLine());
            if(numero > 0)
            {
                Console.WriteLine("NÃO NEGATIVO!");
            }
            else if(numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else if(numero == 0)
            {
                Console.WriteLine("NÃO NEGATIVO!");
            }
        }
    }
}
