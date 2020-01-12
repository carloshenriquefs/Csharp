using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("[ NÚMEROS IMPARES ]");
            Console.WriteLine();
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 1; numero > i; i = i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
