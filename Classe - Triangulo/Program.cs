using System;
using System.Globalization;

namespace Classe___Triangulo
{
    class Program
    {

        //Fazer um programa para ler as medidas dos lados de dois triângulos X e Y
        //Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois 
        //triângulos possui a maior área.
        
        static void Main(string[] args)
        {
            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            X.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double p  = (X.A + X.B + X.C) / 2;
            double AreaX = Math.Sqrt(p*(p - X.A)*(p - X.B)*(p - X.C));

            p = (Y.A + Y.B + Y.C)/2;
            double AreaY = Math.Sqrt(p*(p - Y.A)*(p - Y.B)*(p - Y.C));

            Console.WriteLine("AreaX ="+ AreaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("AreaY = "+ AreaY.ToString("F4",CultureInfo.InvariantCulture));

            if(AreaX > AreaY)
            {
                Console.WriteLine("AreaX é Maior!");
            }
            else
            {
                Console.WriteLine("AreaY é maior!");
            }



        }
    }
}
