using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TABAUDA ===");
            Console.WriteLine("Informe um número:");

            int num = int.Parse(Console.ReadLine());

            for(int num1 = 1; num1 < 11; num1++)
            {
                Console.WriteLine($"{num} x {num1} = {num*num1}");
            }
        }
    }
}
