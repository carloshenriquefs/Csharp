using System;

namespace RetanguloAlturaLargura
{
    class Program
    {
        //Fazer um programa para ler os valores da largura e altura de um 
        //retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e
        //diagonal. Usar uma classe como mostrado.

        static void Main(string[] args)
        {
           Retangulo retangulo = new Retangulo();

           Console.WriteLine("[ RETÂNGULO ]");
           Console.WriteLine();
           Console.Write("Altura: ");
           retangulo.Altura = double.Parse(Console.ReadLine());
           Console.Write("Largura: ");
           retangulo.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("    [CALCULANDO]");
            Console.WriteLine();
            Console.WriteLine("AREA = "+retangulo.Area());
            Console.WriteLine("PERIMETRO ="+retangulo.Perimetro());
            Console.WriteLine("DIAGONAL = "+retangulo.Diagonal());

        }
    }
}
