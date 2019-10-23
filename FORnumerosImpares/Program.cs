using System;

namespace FORnumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NÚMEROS - ÍMPARES");
            for(int i = 1; i < 11; i = i+2)
            {
                Console.Write(i+"-");
            }
        }
    }
}
