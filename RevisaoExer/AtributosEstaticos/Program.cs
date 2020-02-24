using System;

namespace AtributosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto1 = new Produtos("Caneta", 3.2, 0.1);
            var produto2 = new Produtos(){
                Nome = "Borracha",
                Preco = 5.3,
                Desconto = 0.1
            };

            Console.WriteLine($"Produto1: {produto1.Nome} | Preco1: {produto1.Preco} | Desconto1: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Produto2: {produto2.Nome} | Preco2:{produto2.Preco} | Desconto2: {produto2.CalcularDesconto()}");
        }
    }
}
