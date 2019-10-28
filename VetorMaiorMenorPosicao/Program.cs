using System;
using System.Collections.Generic;

namespace VetorMaiorMenorPosicao
{
    class Program
    {
        //23. Crie uma aplicaçao que crie um vetor de inteiros com 10 posições, 
        //as inicialize com números aleatórios, exiba a lista na tela e diga qual 
        //é a posição do maior e do menor número existente no array.

        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("   RANDOM - MAIOR E MENOR");
            Console.WriteLine("=============================");

            int[] vetor = new int[10];

            Random numAleatorio = new Random();


            for (int i = 0; i < vetor.Length; i++)
            {
                int valorNum = numAleatorio.Next(1, 11);
                vetor[i] = valorNum;

            }

            Console.WriteLine("Lista de Números:");
            foreach (int numero in vetor)
            {
                Console.Write(numero+"-");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Menor Número: ");
            Array.Sort(vetor);
            Console.WriteLine(vetor[0]);
            Console.WriteLine("Maior Número: ");
            Array.Reverse(vetor);
            Console.WriteLine(vetor[0]);

        }

    }
}