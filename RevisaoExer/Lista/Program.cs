using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            foreach(string nomes in list)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("Tamanho da lista: "+list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeira 'A': "+ s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima letra 'A': "+s2);

            int posi1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posicao 'A': "+posi1);

            int posi2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição 'A': "+ posi2);

            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("=============================");

            foreach(string nome in list2)
            {
                Console.WriteLine(nome);
            }
            
            list.RemoveRange(2,2);
            Console.WriteLine("============================");
            foreach(string nomes in list)
            {
                Console.WriteLine(nomes);
            }


            list.Remove("Alex");
            Console.WriteLine("============================");
            foreach(string nomes in list)
            {
                Console.WriteLine(nomes);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("===========================");
            foreach(string nomes in list)
            {
                Console.WriteLine(nomes);
            }

            list.RemoveAt(0);
            Console.WriteLine("===========================");
            foreach(string nomes in list)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}
