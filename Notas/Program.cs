using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;

            Console.WriteLine("Informe a primeira nota: ");
            double nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            double nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota:");
            double nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota:");
            double nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("A sua média é:"+ media);

            if (media >= 7)
            {
                Console.WriteLine("APROVADO!");
            }
            else if(media < 7)
            {
                Console.WriteLine("REPROVADO!");
            }

        }
    }
}
