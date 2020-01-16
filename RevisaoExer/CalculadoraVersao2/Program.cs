using System;
using System.Globalization;
namespace CalculadoraVersao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferencia = "+circ.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = "+circ.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("PI = "+calc.PI.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
