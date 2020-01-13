using System;

namespace NumeroLinha
{
    class Program
    {
        //Fazer um programa para ler um número inteiro positivo N.
        //O programa deve então mostrar na tela N linhas, começando de
        // 1 até N. Para cada linha, mostrar o número da linha, depois o
        //quadrado e o cubo do valor, conforme exemplo.
        static void Main(string[] args)
        {
            Console.WriteLine("   [INFORME]");
            Console.WriteLine();
            Console.Write("Um número: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numero; i++)
            {
               int coluna1 = i;
               int coluna2 = i * i;
               int coluna3 = i * i * i;

               Console.WriteLine("{0} {1} {2}",coluna1, coluna2, coluna3);
            }
        }
    }
}
