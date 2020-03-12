using System;
using System.Collections.Generic;

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
                string NomeP = Console.ReadLine();
                Console.Write("Preço: ");
                double PrecoProduto = double.Parse(Console.ReadLine());
                if(produtoTipo == "I")
                {
                    Console.Write("Comum Preco: ");
                    double produtoComum = double.Parse(Console.ReadLine());
                }
                else if(produtoTipo == "C")
                {

                }
                else if(produtoTipo == "U")
                {
                    Console.Write("Data de Produção: (DD/MM/YYYY): ");
                    DateTime DataProduto = DateTime.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                Console.Write("ETIQUETA - PRECO: ");
                foreach(Produtos produtos in produto)
                {

                }

            }
        }
    }
}
