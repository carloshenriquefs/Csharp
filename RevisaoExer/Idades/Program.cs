using System;

namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            double Idade = 0;
            double media = 0;
            int qtdIdade = 0;
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine("        | IDADES |");
            Console.WriteLine("============================");
            Console.WriteLine();
            Console.WriteLine("       [ INFORME ]");
            Console.WriteLine();
            Console.WriteLine("A idade: ");
            do{
                Idade = double.Parse(Console.ReadLine());
                media = media + Idade;
                qtdIdade = qtdIdade + 1;
                if(Idade < 0)
                {
                    break;
                }
            }while(Idade > 0);

            Console.WriteLine("==============================");
            Console.WriteLine("Quantidade de Idades = "+(qtdIdade-1));
            Console.WriteLine("Media = "+media/(qtdIdade-1));
            Console.WriteLine("Soma das Idades = "+media);
            Console.WriteLine("==============================");
        }
    }
}
