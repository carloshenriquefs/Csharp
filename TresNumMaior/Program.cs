using System;

namespace TresNumMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: ");

            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            int Num3 = int.Parse(Console.ReadLine());

            int resultado = Maior( Num1, Num2, Num3);

            Console.WriteLine("O maior valor é: "+resultado);
        }

        static int Maior(int a,int b, int c)
        {
            int maior;
            if(a > b && a > c)
            {
                maior = a;
            }
            else if(b > a && b > c)
            {
                maior = b;
            }
            else{
                maior = c;
            }

            return maior;
        }
    }
}
