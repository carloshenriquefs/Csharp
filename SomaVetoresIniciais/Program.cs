using System;

namespace SomaVetoresIniciais
{
    class Program
    {
        //24. Crie uma aplicação que dados dois vetores de inteiro com 10
        //posições, gere um terceiro vetor contendo a o resultado da soma
        //dos valores dos vetores inciais.

        static void Main(string[] args)
        {
            Random numAleatorio = new Random();

            Console.WriteLine("====================");
            Console.WriteLine("   VETORES SOMA");
            Console.WriteLine("====================");
            Console.WriteLine();
            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int[] vetorC = new int[10];

            
            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorA[i] = numAleatorio.Next(1, 100);
                vetorB[i] = numAleatorio.Next(1, 100);
                vetorC[i] = vetorA[i] + vetorB[i];
            }

            Console.WriteLine("CONJUNTO A:");
            
            foreach (int arrayA in vetorA)
            {
                Console.Write(" " + arrayA);
            }

            Console.WriteLine();
            Console.WriteLine("CONJUNTO B:");
           
            foreach (int arrayA in vetorB)
            {
                Console.Write(" " + arrayA);
            }
            Console.WriteLine();
            Console.WriteLine("CONJUNTO C:");
            foreach (int uniao in vetorC)
            {
                Console.Write(" "+uniao);
            }






        }
    }
}
