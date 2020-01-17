using System;

namespace ProdutoNomePreco
{
    class Program
    {
        //Fazer um programa para ler um número inteiro N e os dados
        //(nome e preco) de N produtos. Armazene os N produtos em um 
        //vetor . Em seguida, mostrar o preco médio dos produtos.
        static void Main(string[] args)
        {
            Console.WriteLine("[ PRODUTOS ]");
            Console.WriteLine();
            Console.Write("Informe a quantidade de produtos: ");
            int qtdProdutos = int.Parse(Console.ReadLine());

            Produto [] produtos = new Produto[qtdProdutos];

            for(int i = 0; i < qtdProdutos ; i++)
            {
                string nomeProduto = Console.ReadLine();
                double precoProduto = double.Parse(Console.ReadLine());
                produtos[i] = new Produto {Nome = nomeProduto , Preco = precoProduto};
            }

            double soma = 0;
            for (int i = 0; i < qtdProdutos; i++)
            {
                soma += produtos[i].Preco;
            }

            double media = soma / qtdProdutos;

            Console.WriteLine("Média = {0}",media);
        }
    }
}
