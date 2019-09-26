using System;

namespace Vetor___Temperatura_mês_
{
    class Program
    {
        static void Main(string[] args)
        {
            double maiorNum = 0;
            double menorNum = 0;
            double[] temp = new double [12];

            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine("=====================");
                Console.WriteLine("MÊS :0"+(i +1)+"/2019");
                Console.Write("Informe o valor da temperatura:");
                temp[i] = double.Parse(Console.ReadLine());
                Console.Write("=====================");
                    
                if(temp[i] > maiorNum)
                {
                    maiorNum = temp[i];
                }
                else if(temp[i] < menorNum)
                {
                    menorNum = temp[i];
                }
            }
            Console.WriteLine("\nA maior temperatura é:"+maiorNum);
            Console.WriteLine("A menor temperatura é:"+menorNum);
        }
    }
}
