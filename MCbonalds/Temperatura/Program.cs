using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("=================");
            Console.WriteLine("   TEMPERATURA: ");
            Console.WriteLine("=================");
            Console.WriteLine("Informe uma temperatura em Cº");
            double celsius = double.Parse(Console.ReadLine());

            double F = (9*celsius)/5+32;

            Console.WriteLine("   Conversão ");
            Console.WriteLine("FAHRENHEIT = "+F+ "ºF");
        }
    }
}
