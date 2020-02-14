using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("==================");
            Console.WriteLine("     TABUADA");
            Console.WriteLine("==================");
            Console.WriteLine();
            int num1 = 1;
            int num = 0;

            Console.WriteLine("   | INFORME |");

            do{
            Console.WriteLine();
            Console.Write("Número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if(num > 2 && num < 1000)
            {
                for(int i = 0; i < 11; i++ )
                {
                    Console.WriteLine($"{num} x {i} = {num*i}");
                }
            }
            else
            {
                Console.WriteLine("Número Fora dos Padrões");
                Console.WriteLine("Tente novamente!");
            }

            }while(num != num1 );
        }
    }
}
