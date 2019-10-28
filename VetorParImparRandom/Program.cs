using System;
using System.Collections.Generic;

namespace VetorParImparRandom
{
    class Program
    {
        //20. Criar um programa que inicialize uma vetor de 10 inteiros com números 
        //aleatórios gerados com o método random e imprima duas listas, uma com os 
        //números pares outra com numeros impares.

        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("  RANDOM - PAR E IMPAR");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Random numAleatorio = new Random();
            int[] vetor = new int[10];

            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();

            for (int i = 0; i < vetor.Length; i++)
            {
                int num = numAleatorio.Next(1, 21);
                vetor[i] = num;
            }

            
            Console.WriteLine("    Lista de Números: ");
            Console.WriteLine("==========================");
            Console.WriteLine();
            foreach (int numero in vetor)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número "+numero + " é PAR!");
                    numerosPares.Add(numero);
                }
                else
                {
                    Console.WriteLine("O número "+numero + " é IMPAR!");
                    numerosImpares.Add(numero);
                }
            }
            Console.WriteLine();
            Console.WriteLine("==========================");



        }
    }
}
