using System;
using System.IO;
using System.Collections.Generic;
using ProdutoCSV_exerc.Entities;
using System.Linq;
using System.Globalization;

namespace ProdutoCSV_exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file patch:");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using(StreamReader sr = File.OpenText(path)){
                while(!sr.EndOfStream){
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }
            var media = list.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = "+media.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Preco < media).OrderByDescending(p => p.Nome).Select(p => p.Nome);
            foreach(string name in names){
                Console.WriteLine(name);
            }
        }
    }
}
