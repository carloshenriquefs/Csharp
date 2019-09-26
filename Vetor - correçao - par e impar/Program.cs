using System;

namespace Vetor___correçao___par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;
            int[] vetor = new int[6];

            for(int cont = 0; cont < 6; cont++)
            {
                Console.WriteLine("Digite um número:");
                vetor[cont] = int.Parse(Console.ReadLine());
            }

            //PARA CADA NUMERO DO VETOR FAÇA ALGO
            foreach(int numero in vetor)
            {
                if(numero % 2 == 0)
                {
                    par = par + 1;
                }
                else
                {
                    impar = impar + 1;
                }
            }

            //MESMA FUNÇÃO DO FOREACH
            // int num;
            // for(int cont =0; cont <= 5; cont++)
            // {
            //     num = vetor[cont];
            //     if(num % 2 == 0)
            //     {
            //         par++;
            //     }
            //     else
            //     {
            //         impar++;
            //     }
            // }

            System.Console.WriteLine("A quantidade de Pares é:"+par);
            System.Console.WriteLine("A quantidade de Impares é:"+impar);
            // Console.WriteLine($"Você tem {par} números pares e {impar} números impares");
            
            
        }
    }
}
