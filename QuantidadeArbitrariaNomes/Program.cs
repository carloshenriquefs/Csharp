using System;
using System.Collections.Generic;

namespace QuantidadeArbitrariaNomes
{
    class Program
    {
        //26. Criar uma aplicação console, que permita ao usuário digite 
        //uma quantidade arbitrária de nomes, armazenando esses nomes em 
        //uma coleção. Ao fim da digitação, a aplicação deverá dizer a 
        //quantidade de nomes adicionados pelo usuário

        static void Main(string[] args)
        {
            List<string> Nomes = new List<string>();

            Console.WriteLine("INFORME");
            Console.WriteLine("Inserir Nomes: [S/N]? ");
            string opcao = Console.ReadLine();
            do
            {
                Console.Write("NOME:");
                string nome = Console.ReadLine();
                Console.Write("Quer inserir mais nomes: [S/N]?");
                opcao = Console.ReadLine().ToUpper();
                Nomes.Add(nome);

            }while(opcao == "S");

            Console.WriteLine();
            Console.WriteLine("===================");
            Console.Write("Quantidade de nomes: ");
            Console.Write(Nomes.Count);
            Console.WriteLine();
            Console.WriteLine("===================");
            
            
        }
    }
}
