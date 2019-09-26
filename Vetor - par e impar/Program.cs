using System;

namespace Vetor___par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] num = new int[6];
            int[] num1 = new int[6];

            int num0 = 0;
            int npar = 0;
            int nimpar = 0;
            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine($"Informe o "+i+"°número:");
                num0 = int.Parse(Console.ReadLine());
               
                if(num0 % 2==0)
                {
                    num[i] = num0;
                    npar = npar + 1;
                } 
                else if(num0 % 2 == 1)
                {
                    num[i] = num0;
                    nimpar = nimpar + 1;       
                }
            }
            Console.WriteLine("Total de numeros PARES: "+npar);
            Console.WriteLine("Total de número ÍMPARES:"+nimpar);
           
            
            
        }
    }
}
