using System;

namespace Vetor___correçao___Temperatura_mes_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temp = new double[12];
            double maior = 0;
            double menor = 0;

            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Digite a temperatura do mês {i + 1}:");
                temp[i] = double.Parse(Console.ReadLine());
            }

            maior = temp[0];
            menor = temp[0];
            foreach(double temperatura in temp)
            {
                if(temperatura > maior)
                {
                    maior = temperatura;
                }
                else if(temperatura < menor)
                {
                    menor = temperatura;
                }
            }

            Console.WriteLine("A maior temperatura é:"+maior);
            Console.WriteLine("A menor temperatura é:"+menor);
        }
    }
}
