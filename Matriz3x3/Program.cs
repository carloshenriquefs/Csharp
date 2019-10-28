using System;

namespace Matriz3x3
{
    class Program
    {
        //22. Criar um programa que dada uma matriz 3x3 de inteiros aleatórios, 
        //realize a soma de todos os números exibindo o total na tela.
        static void Main(string[] args)
        {
            int valorTotal = 0;
            int n = 3;

            Console.WriteLine("================");
            Console.WriteLine("     MATRIZ");
            Console.WriteLine("================");
            Console.WriteLine();
            int[,] vetornum = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int y = 0; y < n; y++)
                {
                    vetornum[i, y] = int.Parse(valor[y]);

                    for (int k = 0; k < 1; k++)
                    {
                        valorTotal = vetornum[i, y] + valorTotal;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine("SOMA DOS VALORES");
            Console.WriteLine("Total = "+valorTotal);
            Console.WriteLine("================");
        
        }
    }
}
