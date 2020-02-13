using System;

namespace Media3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Media = 0;
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("     | MEDIA 3 |");
            Console.WriteLine("=======================");
            Console.WriteLine();

            Console.Write("Informe a 1º nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a 2º nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a 3º nota: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Informe a 4º nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            Media = (nota1*2 + nota2*3 + nota3*4 + nota4*1) ;

            Console.Write("Media = " +Media/10);
        }
    }
}
