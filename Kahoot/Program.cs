using System;

namespace Kahoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = {{10,15,48},{56,97,77},{2,100,33}};

            int soma = 0;
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i,j];
                }
            }

            // foreach(var item in matriz)
            // {
            //     Console.WriteLine(item);
            // }

            Console.WriteLine(soma);


        }
    }
}
