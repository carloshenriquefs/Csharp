using System;

namespace VetoresUniao
{
    class Program
    {
        //25. Criar uma aplicação que inicie dois vetores com o tamanho determinado 
        //pelo usuário, com números aleatórios, gere um tereceiro vetor que deve 
        //ser a união dos dois primeiros e exiba os três vetores na console.
        static void Main(string[] args)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("    VETORES UNIÃO");
            Console.WriteLine("=====================");

            Console.WriteLine("INFORME ");
            Console.Write("O tamanho do vetor:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] vetorA = new int[numero];
            int[] vetorB = new int[numero];
            int[] uniaoAB = new int[numero];

            Console.WriteLine("    - VETOR A -");
            for(int i = 0; i < numero; i++)
            {
                Console.Write("Informe um valor: ");
                int num = int.Parse(Console.ReadLine());
                vetorA[i] = num;
                
            }
            Console.WriteLine();
            Console.WriteLine("    - VETOR B -");
            for(int i = 0; i < numero; i++)
            {
                Console.Write("Informe outro valor: ");
                int num = int.Parse(Console.ReadLine());
                vetorB[i] = num;
            }

            Console.WriteLine();
            Console.WriteLine("UNIÃO");
            for(int i = 0; i < uniaoAB.Length; i++)
            {
                uniaoAB[i] = Convert.ToInt32(vetorA[i].ToString() + vetorB[i].ToString());
                Console.WriteLine(uniaoAB[i]);
            }
        }
    }
}
