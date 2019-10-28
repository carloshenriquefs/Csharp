using System;

namespace VetoresDeterminadoUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do vetor:");
            int tamanho = int.Parse(Console.ReadLine());

            for(int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Informe um valor:");
                int valor = int.Parse(Console.ReadLine());
                 Console.WriteLine("Informe outro valor:");
                int valor1 = int.Parse(Console.ReadLine());

                int[] vetor1 = new int[tamanho];
                vetor1[i] = valor;
                int[] vetor2 = new int[tamanho];
                vetor2[i] = valor1;
            }

            int[] uniao = new int[4];
            Console.WriteLine("UNIÃO");
            for(int i = 0; i < uniao.Length; i++)
            {
                uniao[i] = Convert.ToInt32(vetor1[i].ToString() + vetor2[i].ToString());
                Console.WriteLine(uniao[i]);
            }
        }
    }
}
