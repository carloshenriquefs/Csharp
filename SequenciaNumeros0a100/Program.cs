using System;

namespace SequenciaNumeros0a100
{
    class Program
    {
        //6. Criar um programa que utilizando a estrutura 
        //FOR imprima uma sequencia de números de 0 a 100.
        static void Main(string[] args)
        {   
            Console.WriteLine();
            Console.WriteLine("Números - 0 a 100");
            Console.WriteLine();
            for(int i = 0; i < 101; i++)
            {   
                Console.Write(i+"-");
            }
        }
    }
}
