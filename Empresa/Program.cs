using System;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioN = 0;
            
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("Curso - [DEVS]");
            Console.WriteLine("Curso - [REDES]");

           Console.WriteLine("Qual curso você faz?");
           string curso = Console.ReadLine();

            if((curso == "DEVS") || (curso == "devs"))
            {
                Console.WriteLine("Informe o seu salário: R$");
                double salario = double.Parse(Console.ReadLine());

                if(salario < 500)
                {
                    Console.WriteLine("O seu salário antigo é: R$"+ salario);
                    salarioN = salario + salario*(0.3);
                    Console.WriteLine("O seu salario atual é: R$"+ salarioN);
                }
            }
            else if((curso == "REDES") || (curso == "redes"))
            {
                Console.WriteLine("Você não tem direito ao AUMENTO!");
            }




        }
    }
}
