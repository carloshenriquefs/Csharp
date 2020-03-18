using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 / n2;
                Console.WriteLine(resultado);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error!" + e.Message);
            }
        }
    }
}
