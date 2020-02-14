using System;

namespace MaiorEPosicao
{
    class Program
    {
        //Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.
        static void Main(string[] args)
        {
            Console.WriteLine();
           Console.WriteLine("=============================");
           Console.WriteLine("     | MAIOR | POSICAO |");
           Console.WriteLine("=============================");
           Console.WriteLine();
           
           
           int[] num = new int[10];

           for(int i = 1; i < 10; i++)
           {
               num[i] = int.Parse(Console.ReadLine());
               
           }

           Array.Sort(num);
           Console.Write("O maior valor é: "+num[9]);

           
           
        }
    }
}
