using System;
using System.Collections.Generic;

namespace VetorRandom
{
    class Program
    {
        //20. Criar um programa que inicialize uma vetor de 10 inteiros 
        //com números aleatórios gerados com o método random e imprima 
        //duas listas, uma com os números pares outra com numeros impares.

        static void Main(string[] args)
        {
            Random numeroAleatorio = new Random();
            int[] numeros = new int[10];
            List<int> Pares = new List<int>();
            List<int> Impares = new List<int>();

            for(int i = 0; i < numeros.Length;i++)
            {
                int valor = numeroAleatorio.Next(1, 11);
                
            }

            
    

        }
    }
}
