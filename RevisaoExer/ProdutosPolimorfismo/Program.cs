using System;
using System.Collections.Generic;
using ProdutosPolimorfismo.Entities;

namespace ProdutosPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produtos> produto = new List<Produtos>();

            Console.Write("Número de produtos: ");
            int numeroProdutos = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numeroProdutos; i++)
            {
                Console.Write("Produto #"+i+":");
                Console.Write("Comum, Usado ou Importado [C/U/I]?");
                string produtoTipo = Console.ReadLine();
                Console.Write("Nome: ");
                string nomeprodutos = Console.ReadLine();
                Console.Write("Preço: ");
                double PrecoProduto = double.Parse(Console.ReadLine());
                if(produtoTipo == "c")
                {
                        produto.Add(new Produtos(nomeprodutos,PrecoProduto));
                }
                if(produtoTipo == "u")
                {
                    Console.Write("Data de Produção: (DD/MM/YYYY): ");
                    DateTime DataProduto = DateTime.Parse(Console.ReadLine());
                    produto.Add(new ProdutosUsados(nomeprodutos,PrecoProduto,DataProduto));
                }
                else
                {
                    Console.Write("Comum Preco: ");
                    double produtoComum = double.Parse(Console.ReadLine());
                    produto.Add(new ProdutosImportados(nomeprodutos, PrecoProduto,produtoComum));
                }

                Console.WriteLine();
                Console.Write("ETIQUETA - PRECO: ");
                foreach(Produtos produtos in produto)
                {
                    Console.WriteLine(produtos.EtiquetaPreco());
                }

            }
        }
    }
}
