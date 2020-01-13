using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("[ FATORIAL ]");
           Console.WriteLine();
          
           int fat = 1;

           for(int i = 1; i <= 10;i++)
           {
               fat *= i;
               Console.WriteLine(i +"!"+ " = " + fat);
           }
        }
    }
}
