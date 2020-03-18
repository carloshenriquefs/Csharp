using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NProdutosPolimorfismo.Entities;
using NProdutosPolimorfismo.Entities.Enum;

namespace NProdutosPolimorfismo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Número de figuras: ");
            int numeroFiguras = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numeroFiguras; i++)
            {
                Console.WriteLine("Figuras #" + i + " : ");
                Console.Write("Retangulo ou Circulo (R/C)? ");
                char figura = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto/Azul/Vermelha): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(figura == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(largura, altura,color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

            }
                Console.WriteLine();
                Console.WriteLine("Figuras: ");
                foreach(Shape figuras in list)
                {
                    Console.WriteLine(figuras.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
        }

        
    }
}
