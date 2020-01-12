using System;

namespace SomaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros: ");
            int numeros = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int somaTotal = 0;
            for (int num = 0; numeros > num; num++)
            {
                Console.Write("Valor #{0}:",num+1);
                int numSoma = int.Parse(Console.ReadLine());
                somaTotal += numSoma;
            }
             Console.WriteLine();
            Console.WriteLine("Soma Total: {0}", somaTotal);
        }
    }
}
