using System;
using System.Collections.Generic;

namespace OrdemAlfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Informe um nome: ");
            // string Nome = Console.ReadLine();
            // Console.WriteLine("Informe outro nome: ");
            // Nome = Console.ReadLine();
            List<string> Nomes = new List<string>();
            Nomes.Add("Carlos");
            Nomes.Add("Allan");

            Nomes.Sort();

            foreach(string nome in Nomes)
            {
                Console.WriteLine(Nomes);
            }
        }

    }
}
