using System;

namespace NumParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[NÚMERO] - IMPAR E PAR!");
            Console.WriteLine();
            Console.WriteLine("[ INFORME ]");
            Console.Write("Um número: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("PAR!");
            }
            else if(numero % 2 == 1)
            {
                Console.WriteLine("IMPAR!");
            }
        }
    }
}
