using System;

namespace IntervaloNumerosImpares
{
    class Program
    {
        //18. Criar uma aplicação que leia um número que será o limite superior 
        //de um intervalo e imprimir todos os números ímpares menores do que esse número.

        static void Main(string[] args)
        {
            Console.WriteLine("INTERVALOS DE NÚMEROS:");
            Console.WriteLine();
            Console.Write("Informe um número:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("==========================");
            for(int i = 1; i < num; i=i+2)
            {
                Console.Write(i+"-");
            }
            Console.WriteLine();
            Console.WriteLine("==========================");
        }
    }
}
