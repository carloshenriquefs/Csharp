using System;
using System.Globalization;

namespace LadosTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ LADOS TRIÂNGULO ]");
            Console.WriteLine();
            Console.WriteLine("Informe o lado X do Triângulo: ");
            double Xa = double.Parse(Console.ReadLine());
            double Xb = double.Parse(Console.ReadLine());
            double Xc = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o lado Y do Triângulo: ");
            double Ya = double.Parse(Console.ReadLine());
            double Yb = double.Parse(Console.ReadLine());
            double Yc = double.Parse(Console.ReadLine());

            double pX = (Xa + Xb + Xc) / 2;
            double AreaX = Math.Sqrt(pX *(pX - Xa)*(pX - Xb)*(pX - Xc));

            double pY = (Ya + Yb + Yc) / 2;
            double AreaY = Math.Sqrt(pY*(pY - Ya)*(pY - Yb)*(pY - Yc));

            Console.WriteLine("Area de Y = {0}",AreaY.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Área de X = {0}",AreaX.ToString("F4",CultureInfo.InvariantCulture));

            if(AreaX > AreaY)
            {
                Console.WriteLine("Area X é MAIOR!");
            }
            else
            {
                Console.WriteLine("Area Y é MAIOR!");
            }
        }
    }
}
