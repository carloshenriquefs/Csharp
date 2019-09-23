using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t=== TABUADA ===");
            
             for(int num1 = 1; num1 < 11; num1++)
            {
                for(int num2 = 1; num2 < 11; num2++){
                    Console.Write($"\t{num2} x {num1} = {num2*num1}");
                    // Console.WriteLine($"{2} x {num1} = {2*num1}");
                }
                Console.WriteLine();
            }
            //Console.WriteLine($"{j,-2} *  {i,-2} = {j*i})
            
        }
    }
}
