using System;

namespace exerc001
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, menor = 0;

            Console.WriteLine("NÚMEROS - MAIORES E MENORES");
            Console.WriteLine("Informe o 1º número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2° número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 3º número:");
            int num3 = int.Parse(Console.ReadLine());

            maior = num1;
            
            if((num2 > num1) && (num2 > num3))
            {
                maior = num2;
            }

            if((num3 > num1) && (num3 > num2))
            {
                maior = num3;
            }
        }
    }
}
