using System;

namespace QtdNumerosPositivos
{
    class Program
    {
        //Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos 
        //(desconsidere os valores nulos). A seguir, mostre a quantidade de valores positivos digitados.

        static void Main(string[] args)
        {
            double total =0;
            int num = 0;
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("   | NUMEROS POSITIVOS |");
            Console.WriteLine("=============================");
            Console.WriteLine();
            
            for(int i = 1; i <= 5; i++)
            {
                Console.Write("Informe o "+ i+"º número: ");
                num = int.Parse(Console.ReadLine());

                if(num > 0)
                {
                     total = total + 1;
                }
            }
            Console.WriteLine("Total de número positivos: "+total);
        }
    }
}
