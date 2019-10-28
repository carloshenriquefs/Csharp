using System;

namespace CaixaEletronicoNotas {
    class Program {
        static void Main (string[] args) {
            
            Console.WriteLine("Caixa Eletronico");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite o valor do saque: ");
            int valor = Convert.ToInt16(Console.ReadLine()); //recebendo o valor digitado pelo usuário.
            int n100 = valor / 100; //contagem das notas de 100R$
            int resto = valor - (n100 * 100); //valor menos as notas de 100.
            int n50 = resto / 50;//contagem das notas de 50R$
            resto = resto - (n50 * 50);
            int n20 = resto / 20;//contagem das notas de 20R$
            resto = resto - (n20 * 20);
            int n10 = resto / 10;//contagem das notas de 10R$
            resto = resto - (n10 * 10);
            int n5 = resto / 5;//contagem das notas de 5R$
            resto = resto - (n5 * 5);
            int n1 = resto / 1;//contagem das notas de 1R$
            resto = resto - (n1 * 1);
            Console.WriteLine();
            Console.WriteLine("Quantidade de notas:");
            Console.WriteLine();
            Console.WriteLine("Notas de 100R$:  " +n100);
            Console.WriteLine();
            Console.WriteLine("Notas de 50R$:  " +n50);
            Console.WriteLine();
            Console.WriteLine("Notas de 20R$:  " +n20);
            Console.WriteLine();
            Console.WriteLine("Notas de 10R$:  " +n10);
            Console.WriteLine();
            Console.WriteLine("Notas de 5R$:  " +n5);
            Console.WriteLine();
            Console.WriteLine("Notas de 1R$:  " +n1);
            Console.ReadKey();
        }
    }
}