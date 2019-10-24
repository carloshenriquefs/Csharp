using System;

namespace Numeros120a300
{
    class Program
    {
        //17. Criar um programa que imprima os números de 120 a 300.       
         static void Main(string[] args)
        {
            Console.WriteLine("NÚMEROS - 120 A 300");
            for(int i = 120; i < 301; i++)
            {
                Console.Write(i+"-");
            }
        }
    }
}
