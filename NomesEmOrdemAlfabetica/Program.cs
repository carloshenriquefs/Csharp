using System;
using System.Collections.Generic;

namespace NomesEmOrdemAlfabetica
{
    class Program
    {
        //11. Criar uma aplicação que entre com dois nomes e 
        //imprimi-los em ordem alfabética

        static void Main(string[] args)
        {
            string[] vetor = new string[2];

            Console.WriteLine("=======================");
            Console.WriteLine("    ORDEM ALFABÉTICA");
            Console.WriteLine("=======================");
            Console.WriteLine();

            Console.WriteLine("INFORME");
            Console.WriteLine("[NOMES]");
            for(int i = 0; i < 2; i++)
            {
                string nome = Console.ReadLine();
                vetor[i] = nome;
            }
        
            Array.Sort(vetor);
            Console.WriteLine();
            Console.WriteLine("ORDEM ALFABÉTICA");
            Console.WriteLine();
            foreach(var itens in vetor)
            {
                Console.WriteLine(itens);
            }

               
            

         


           





        }
    }
}
