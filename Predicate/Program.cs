using System;
using System.Collections.Generic;
using Predicate.Entities;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(ProductTest);
            foreach(Product p in list){
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p){
            return p.Preco >= 100.00;
        }
    }
}
