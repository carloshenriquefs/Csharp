using System;

namespace QuantidadePares
{
    class Program
    {
        //Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e 
        //mostre esta informação.
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("        | PARES |");
            Console.WriteLine("========================");
            Console.WriteLine();

            Console.WriteLine("        [INFORME]");
            Console.WriteLine();
            for(int i = 1; i <= 5; i++)
            {
                Console.Write( i+"º número: ");
                int numero = int.Parse(Console.ReadLine());

                if(numero % 2 == 0)
                {
                    total = total + 1;
                }
            }
            Console.WriteLine("Total de números pares = "+total);

        }
    }
}
