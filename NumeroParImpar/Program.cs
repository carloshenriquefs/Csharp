using System;

namespace NumeroParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Criar um programa que solicite ao usuário um número 
            //e diga se o número é par ou impar.
            
            Console.WriteLine("NÚMERO - PAR | IMPAR");
            Console.WriteLine();
            Console.WriteLine("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("O número "+ numero + " é PAR!");
            }
            else if(numero % 1 == 0)
            {
                Console.WriteLine("O número " +numero+ " é IMPAR!");
            }
        }
    }
}
