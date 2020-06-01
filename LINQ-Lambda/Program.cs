using System;
using System.Linq;
using System.Collections.Generic;
using LINQ_Lambda.Entities;

namespace LINQ_Lambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection){
            Console.WriteLine(message);
            foreach(T obj in collection){
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category(){Id = 1, Nome = "Tools", Tier = 2};
            Category c2 = new Category(){Id = 2, Nome = "Computers", Tier = 1};
            Category c3 = new Category(){Id = 3, Nome = "Electronics", Tier = 1};

            List<Product> products = new List<Product>(){
                new Product() {Id = 1, Nome = "Computer", Preco = 1100.00, Category = c2},
                new Product() {Id = 2, Nome = "Hammer", Preco = 90.00, Category = c1},
                new Product() {Id = 3, Nome = "TV", Preco = 1700.00, Category = c3},
                new Product() {Id = 4, Nome = "Notebook", Preco = 1300.00, Category = c2},
                new Product() {Id = 5, Nome = "Saw", Preco = 80.00, Category = c1},
                new Product() {Id = 6, Nome = "Tablet", Preco = 700.00, Category = c2},
                new Product() {Id = 7, Nome = "Camera", Preco = 700.00, Category = c3},
                new Product() {Id = 8, Nome = "Printer", Preco = 350.00, Category = c3},
                new Product() {Id = 9, Nome = "MacBook", Preco = 1800.00, Category = c2},
                new Product() {Id = 10, Nome = "Sound Bar", Preco = 700.00, Category = c3},
                new Product() {Id = 11, Nome = "Level", Preco = 70.00, Category = c1}
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Preco < 900.00);
            Print("TIER 1 AND PRECO < 900", r1);

            var r2 = products.Where(p => p.Category.Nome == "Tools").Select(p => p.Nome);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Nome[0]== 'C').Select(p => new{p.Nome, p.Preco, CategoriaNome = p.Category.Nome});
            Print("NOMES COMECANDO COM 'C' E OBJETOS ANONIMOS", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Preco).ThenBy(p => p.Nome);
            Print("TIER 1 ORDER BY PRECO THEN BY NAME",r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP TAKE 4", r5);

            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            // var r7 = products.Where(p => p.Preco > 3000.00).First();
            // Console.WriteLine("First test2: "+r7);
            // Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: "+ r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2:" + r9);
            Console.WriteLine();

            var r10 = products.Max(p => p.Preco);
            Console.WriteLine("Max price: "+r10);
            var r11 = products.Min(p => p.Preco);
            Console.WriteLine("Min preco:"+r11);
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Preco);
            Console.WriteLine("Categoria 1 Soma preco: "+ r12);
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Preco);
            Console.WriteLine("Categoria 1 Media de precos:" + r13);
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Categoria 5 Media de precos:" + r14);
            var r15 = products.Where(p =>p.Category.Id == 5).Select(p => p.Preco).Aggregate(0.0,(x,y) => x + y);
            Console.WriteLine("Categoria 1 aggregate sum: "+r15);

            var r16 = products.GroupBy(p => p.Category);
            foreach(IGrouping<Category, Product> group in r16){
                Console.WriteLine("Categoria :" + group.Key.Nome + ":");
                foreach(Product p in group){
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
