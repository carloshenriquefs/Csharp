using System;

namespace TrianguloAsteriscoDesenhho
{
    class Program
    {
        static void Main(string[] args)
        {
            string simbolo = "*";
            double altura = 0;
            int quantidadeTri = 0;

            Console.WriteLine("==========================");
            Console.WriteLine("    TRIÂNGULO DESENHO");
            Console.WriteLine("==========================");
            Console.WriteLine();
            Console.WriteLine("[INFORME]");
            Console.WriteLine("ALTURA DO TRIÂNGULO:");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("QUANTIDADE DE TRIÂNGULOS:");
            quantidadeTri = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < quantidadeTri; i++)
            {
                string asterisco = "";

                for(int y = 0; y < altura; y++)
                {
                    Console.WriteLine(asterisco = simbolo + asterisco);
                }
                Console.WriteLine(" ");
            }

        }
    }
}
