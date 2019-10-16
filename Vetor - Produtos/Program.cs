using System;

namespace Vetor___Produtos
{
    class Program
    {

        //Fazer um programa para ler um número inteiro N e os dados 
        //(nome e preço) de N Produtos. Armazene os N produtos em um vetor.
        // Em seguida, mostrar o preço médio dos produtos
        static void Main(string[] args)
        {
            double soma = 0;
            double media = 0;

            Console.WriteLine("QUANTIDADE:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[quantidade];
            for(int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("PRODUTO:");
                string produto = Console.ReadLine();
                Console.WriteLine("PREÇO:");
                double preco = double.Parse(Console.ReadLine());
                vetor[i] = new Produto{Nome = produto, Preco = preco};
            }

            for(int i = 0; i < quantidade; i++)
            {
                soma += vetor[i].Preco;
            }

            media = soma / quantidade;

            Console.WriteLine("MÉDIA DE PREÇOS: "+media);
        }
    }
}
