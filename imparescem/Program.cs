using System;

namespace imparescem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============");
            Console.WriteLine("NÚMEROS IMPARES");
            Console.WriteLine("================");
            for(int num= 1; num < 101; num = num + 2)
            {
                Console.Write("-"+num);
            }
        }
    }
}
