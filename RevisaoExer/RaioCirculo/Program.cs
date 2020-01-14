using System;
using System.Globalization;

namespace RaioCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi = 3.14159;

            Console.WriteLine("[ RAIO DO CIRCULO ]");
            Console.WriteLine();
            Console.Write("Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());

            double Area = Pi * (raio*raio);

            Console.WriteLine("Área = {0}",Area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
