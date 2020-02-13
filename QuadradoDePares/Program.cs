using System;

namespace QuadradoDePares
{
    class Program
    {
        //Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 
        //1 até N, inclusive N, se for o caso.
        static void Main(string[] args)
        {
            int num = 2;
           Console.WriteLine();
           Console.WriteLine("========================");
           Console.WriteLine("     | QUADRADO |");
           Console.WriteLine("========================");
           Console.WriteLine();

           Console.WriteLine("[ INFORME ]");
           Console.WriteLine("Número PAR: ");
           int numeroPar = int.Parse(Console.ReadLine());
           if(numeroPar > 5 && numeroPar < 2000)
           {
               for(int i = 1; i <= numeroPar;i=i+2 )
               {
                   Console.WriteLine(numeroPar*i);
               }
           }
           Console.WriteLine("Tente Novamente!");
        }
    }
}
