using System;
using System.Collections.Generic;
using System.Linq;
using LambdaVersaoSQL.Entities;

namespace LambdaVersaoSQL
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

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Preco < 900.00);
            var r1 = 
                from p in products
                where p.Category.Tier == 1 && p.Preco < 900.00
                select p;
            Print("TIER 1 AND PRECO < 900", r1);

            //var r2 = products.Where(p => p.Category.Nome == "Tools").Select(p => p.Nome);
            var r2 =
                from p in products
                where p.Category.Nome == "Tools"
                select p.Nome;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //var r3 = products.Where(p => p.Nome[0]== 'C').Select(p => new{p.Nome, p.Preco, CategoriaNome = p.Category.Nome});
            var r3 = 
            from p in products
            where p.Nome[0] == 'C'
            select new {
                p.Nome,
                p.Preco,
                CategoriaNome = p.Category.Nome
            };
            Print("NOMES COMECANDO COM 'C' E OBJETOS ANONIMOS", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Preco).ThenBy(p => p.Nome);
            var r4 = 
            from p in products
            where p.Category.Tier == 1
            orderby p.Nome
            orderby p.Preco
            select p;
            Print("TIER 1 ORDER BY PRECO THEN BY NAME",r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP TAKE 4", r5);


            //var r16 = products.GroupBy(p => p.Category);
            var r16 = 
                from p in products
                group p by p.Category;
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
