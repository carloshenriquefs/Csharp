using System;
using System.Collections.Generic;
using NFiguras_Polimorfismo.Entities;

namespace NFiguras_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            System.Console.WriteLine("Número de figuras: ");
            int numeroFiguras = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i <= numeroFiguras; i++)
            {
                Console.WriteLine("Figura #"+i+":");
                Console.Write("Retângulo ou Circulo (R/C)? ");
                string Figura = Console.ReadLine();
                Console.Write("Cor (Preto/Azul/Vermelho): ");
                string Cor = Console.ReadLine();
                if(Cor == "Preto")
                {
                Console.Write("Largura: ");
                double largura = double.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine());
                list.Add(new Shape(largura, altura));
                }
                else if(Cor == "Vermelho")
                {

                }

            }
        }
    }
}
