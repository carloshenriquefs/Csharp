using System;

namespace MenorEposicao
{
    class Program
    {
        //Faça um programa que leia um valor N. Este N será o tamanho de um vetor X[N]. A seguir, leia cada um dos valores de X, 
        //encontre o menor elemento deste vetor e a sua posição dentro do vetor, mostrando esta informação.
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("      | MENOR E POSIÇÃO |");
            Console.WriteLine("=================================");
            Console.WriteLine();

            Console.Write("Tamanho do Vetor: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] vetor = new int[num];

            for(int i = 0; i < num; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());

               
            }

            Array.Sort(vetor);

            Console.WriteLine();

            foreach(var numeros in vetor)
            {
                Console.Write(" "+numeros+" ");
            }

            Console.WriteLine();
            Console.Write("Menor Valor: "+ vetor[0]);
        }
    }
}
