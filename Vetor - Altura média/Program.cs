using System;
using System.Globalization;

namespace Vetor___Altura_média
{
    class Program
    {
        //Fazer um programa para ler um número inteiro N  e a altura de N pessoas
        //Armazene as N alturas em um vetor.Em seguida, mostras a altura média dessas pessoas

        static void Main(string[] args)
        {
            double soma = 0;
            double media = 0;

            Console.WriteLine("ALTURA MÉDIA DE PESSOAS");
            Console.WriteLine("Informe a quantidade de pessoas:");
            int quantidadeP = int.Parse(Console.ReadLine());

            double[] vetor = new double[quantidadeP];
            for(int i = 0; i < quantidadeP ;i++)
            {
                Console.WriteLine("Informe a altura:");
                vetor[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            for(int i = 0; i < quantidadeP; i++ )
            {
                soma += vetor[i];
            }

            media = soma / quantidadeP;

            Console.Write("ALTURA MÉDIA:"+media);


        }
    }
}
