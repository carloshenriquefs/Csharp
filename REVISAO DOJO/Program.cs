using System;

namespace REVISAO_DOJO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do triângulo:");
            int tamanhoTri = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de triângulos:");
            int quanti = int.Parse(Console.ReadLine());
            for(int i = 0; i < quanti; i++)
            {
                string estrelas = "";
                for (int j = 0; j < tamanhoTri; j++)
                {
                    estrelas += "*";
                    Console.WriteLine(estrelas);
                }
                Console.WriteLine();
            }
        }
    }
}
