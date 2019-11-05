using System;
using System.Collections.Generic;
using System.Globalization;

namespace NFiguras
{
    class Program
    {
        //Fazer um programa para ler os dados de N figuras
        //(N fornecido pelo usuário), e depois mostrar as áreas
        //destas figuras na mesma ordem em que foram digitadas.

        static void Main(string[] args)
        {

            List<Area> lista = new List<Area>();

            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine("     N FIGURAS");
            Console.WriteLine("======================");
            Console.WriteLine();

            Console.Write("Quantas figuras: ");
            int qtdFiguras = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdFiguras;i++)
            {
                Console.WriteLine("FIGURA - "+i);
                Console.Write("RETÂNGULO ou CIRCULO (R/C)?");
                char opcao = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("COR (Preto / Azul / Vermelho): ");
                Color Cor = Enum.Parse<Color>(Console.ReadLine());
                if(opcao == 'R')
                {
                    Console.Write("Largura: ");
                    double Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new Retangulo(Altura,Largura,Cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new Circulo(raio,Cor));
                }
            }

            Console.WriteLine();
            Console.WriteLine("FIGURAS - ÁREAS");
            foreach(Area area in lista)
            {
                Console.WriteLine(area.AreaFigura().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
