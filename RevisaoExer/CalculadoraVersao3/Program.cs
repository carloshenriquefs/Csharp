using System;
using System.Globalization;
namespace CalculadoraVersao3
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência = "+circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = "+volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Pi = "+Pi.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
