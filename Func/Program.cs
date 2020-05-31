using System;
using System.Collections.Generic;
using Func.Entities;
using System.Linq;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV",900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = p => p.Nome.ToUpper();

            List<string> result = list.Select(func).ToList();
            foreach(string s in result){
                Console.WriteLine(s);
            }
        }
        // static string NameUpper(Product p){
        //     return p.Nome.ToUpper();
        // }
    }
}
