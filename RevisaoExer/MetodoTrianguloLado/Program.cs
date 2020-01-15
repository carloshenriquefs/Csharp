using System;

namespace MetodoTrianguloLado
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo X,Y;
            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("TRIÂNGULO - METODO");
            Console.WriteLine();
            Console.WriteLine("LADO X - TRIÂNGULO: ");
            X.A = double.Parse(Console.ReadLine());
            X.B  = double.Parse(Console.ReadLine());
            X.C = double.Parse(Console.ReadLine());

            Console.WriteLine("LADO Y - TRIÂNGULO: ");
            double Ya = double.Parse(Console.ReadLine());
            double Yb = double.Parse(Console.ReadLine());
            double Yc = double.Parse(Console.ReadLine());

           double AreaX = X.Area();

           double AreaY = Y.Area();

            Console.WriteLine("Area de X = {0}",AreaX);
            Console.WriteLine("Area de Y = {0}",AreaY);
        }
    }
}
