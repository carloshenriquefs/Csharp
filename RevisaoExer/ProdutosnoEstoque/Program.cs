using System;

namespace ProdutosnoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque produto;

            produto = new Estoque();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: R$ ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            produto.QuantidadeEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: "+ produto);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ produto);
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());;
            produto.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: "+produto);
        }
    }
}
