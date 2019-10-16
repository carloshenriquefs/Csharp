using System;

namespace Quartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante [] vetor = new Estudante[10];

            Console.WriteLine("QUANTIDADE DE QUARTOS:");
            int quartos = int.Parse(Console.ReadLine());

            for(int i = 0; i < quartos; i++)
            {
                Console.WriteLine("NOME:");
                string nome = Console.ReadLine();
                Console.WriteLine("EMAIL:");
                string email = Console.ReadLine();
                Console.WriteLine("QUAL QUARTO FOI ESCOLHIDO: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.Write("QUARTO VAGO:");
            for(int i = 0; i < 10; i++)
            {
                if(vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }

            }
        }
    }
}
