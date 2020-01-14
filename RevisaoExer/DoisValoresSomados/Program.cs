using System;

namespace DoisValoresSomados
{
    class Program
    {
        //Faça um program para ler dois valores inteiros, e depois
        // mostrar na tela a soma desses números com uma mensagem 
        //explicativa.
        static void Main(string[] args)
        {
            int total = 0;
           Console.WriteLine();
           Console.WriteLine("  [ SOMA DOS VALORES ] ");
           Console.WriteLine();

            Console.Write("Informe quantos valores: ");
            int qtdValores = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= qtdValores; i++)
            {
                Console.Write("Informe o valor: ");
                int numero = int.Parse(Console.ReadLine());
                total = numero + total;
            }
            Console.WriteLine("Soma dos números: {0}", total);
            
        }
    }
}
