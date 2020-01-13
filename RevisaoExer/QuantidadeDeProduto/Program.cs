using System;

namespace QuantidadeDeProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco=0;
            Console.WriteLine();
            Console.WriteLine("        PREÇO PRODUTO: ");
            Console.WriteLine();
            Console.WriteLine("[1] - CACHORRO QUENTE - R$ 4.00");
            Console.WriteLine("[2] -     X-SALADA    - R$ 4.50");
            Console.WriteLine("[3] -     X-BACON     - R$ 5.00");
            Console.WriteLine("[4] - TORRADA SIMPLES - R$ 2.00");
            Console.WriteLine("[5] -  REFRIGERANTE   - R$ 1.50");
            Console.WriteLine();
            Console.WriteLine("======================");
            Console.Write("Escolha um produto: ");
            int produto = int.Parse(Console.ReadLine());
          
            Console.WriteLine("======================");
            if(produto == 1)
            {
                Console.WriteLine("[1] - Cachorro Quente ");
                Console.Write("Qual a quantidade? ");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 4.00;
                Console.WriteLine("R$ {0}",preco);
                
            }
            else if(produto == 2)
            {
                Console.WriteLine("[2] - X-Salada ");
                Console.Write("Qual a quantidade? ");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 4.50;
                Console.WriteLine("R$ {0}",preco);
            }
            else if(produto == 3)
            {
                Console.WriteLine("[3] - X-Bancon ");
                Console.Write("Qual a quantidade? ");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 5.00;
                Console.WriteLine("R$ {0}",preco);
            }
            else if(produto == 4)
            {
                Console.WriteLine("[4] - Torrada Simples ");
                Console.Write("Qual a quantidade? ");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 2.00;
                Console.WriteLine("R$ {0}",preco);
            }
            else if(produto == 5)
            {
                Console.WriteLine("[5] - Refrigerante ");
                Console.Write("Qual a quantidade? ");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 1.50;
                Console.WriteLine("R$ {0}",preco);
            }
            else
            {
                Console.WriteLine("Opção Invalida!!");
            }
            
                
        }
    }
}
