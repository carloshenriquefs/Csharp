using System;

namespace ClasseTrianguloLado
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x,y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("TRIÂNGULO COM CLASSES");
            Console.WriteLine();
            Console.WriteLine("LADO X - TRIÂNGULO: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("LADO Y - TRIÂNGULO: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double pX = (x.A + x.B + x.C) / 2;
            double AreaX = Math.Sqrt(pX *(pX - x.A)*(pX - x.B)*(pX - x.C));

            double pY = (y.A + y.B + y.C) / 2;
            double AreaY = Math.Sqrt(pY*(pY - y.A)*(pY - y.B)*(pY - y.C));

            Console.WriteLine("Area de X = {0}",AreaX);
            Console.WriteLine("Area de Y = {0}",AreaY);

            if(AreaY > AreaX)
            {
                Console.WriteLine("AreaY é MAIOR!");
            }
            else
            {
                Console.WriteLine("AreaX é MAIOR!");
            }
        }
    }
}
