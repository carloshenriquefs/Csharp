using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RETÂNGULO: ");
            Console.Write("BASE: ");
            double Base = double.Parse(Console.ReadLine());
            Console.Write("ALTURA:");
            double altura = double.Parse(Console.ReadLine());

            double Perimetro = 2*Base + 2*altura;
            double Area = Base*altura;
            double Diagonal = Math.Sqrt(Perimetro);

            Console.WriteLine("PERIMETRO: "+Perimetro);
            Console.WriteLine("ÁREA:"+Area);
            Console.WriteLine("DIAGONAL: "+Diagonal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
