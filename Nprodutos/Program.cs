using System;
using System.Globalization;
using System.Collections.Generic;

namespace Nprodutos
{
    class Program
    {

        //Fazer um programa para ler os dados de N produtos
        //(N fornecido pelo usuário). Ao final, mostrar a etiqueta
        //de preço de cada produto na mesma ordem em que foram digitados.

        //Todo produto possui nome e preço. Produtos importados possuem uma 
        //taxa de alfândega, e produtos usados possuem data de fabricação.
        //Estes dados especificos devem ser acresccentados na etiqueta de
        //preço conforme exemplo. Para produtos importados, a taxa e alfândega
        //deve ser acrescentada ao preço final do produto.
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("      LER PRODUTOS: ");
            Console.WriteLine("========================");
            Console.WriteLine();

            Console.Write("Quantidade de produtos? ");
            int qtdProdutos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= qtdProdutos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("PRODUTO: "+i);
                Console.WriteLine();
                Console.WriteLine("     CARACTERÍSTICAS");
                Console.Write("| COMUM | IMPORTADO | USADO |:");
                string Resposta = Console.ReadLine().ToUpper();
            
                Console.Write("NOME: ");
                string Nome = Console.ReadLine();
                Console.Write("PREÇO: ");
                double Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(Resposta == "COMUM")
                {
                    lista.Add(new Produto(Nome, Preco));
                }
                else if(Resposta == "IMPORTADO")
                {
                    Console.Write("Anfândega: ");
                    double alfandega = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new ProdutosImporta(Nome, Preco,alfandega));
                }
                else
                {
                    Console.Write("Data (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutosUsados(Nome, Preco,data));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PREÇO DAS ETIQUETAS:");
            foreach(Produto prod in lista)
            {
                Console.WriteLine(prod.Etiqueta());
            }
        }
    }
}
