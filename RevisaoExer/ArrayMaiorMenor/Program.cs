using System;

namespace ArrayMaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("      [ RANDOM ]");
            Console.WriteLine();

            Random num = new Random();

            int [] vetor = new int[10];

            for(int i = 0; i < vetor.Length;i++)
            {
                int numeros = num.Next(1,21);
                vetor[i] = numeros;
            }

            Console.WriteLine("     [Números Gerados ]");
            Console.WriteLine();
            foreach(int NumRandon in vetor)
            {
                Console.Write(NumRandon + " - ");
            }
            Console.WriteLine();
            Console.WriteLine("Maior e Menor - Número: ");
            Console.WriteLine();
            Array.Sort(vetor);
            Console.WriteLine("Menor: "+vetor[0]);
            Console.WriteLine();
            Array.Reverse(vetor);
            Console.WriteLine("Maior: "+vetor[0]);

        }
    }
}
