using System;

namespace Mes
{
    class Program
    {
        //Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este valor, 
        //deve ser apresentado como resposta o mês do ano por extenso, em inglês, com 
        //a primeira letra maiúscula.
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("       MÊS");
            Console.WriteLine("===================");
            Console.WriteLine();

            Console.Write("Informe um mês: ");
            int numMes = int.Parse(Console.ReadLine());

            switch(numMes)
            {
                case 1:
                Console.WriteLine("Janeiro");
                break;

                case 2:
                Console.WriteLine("Fevereiro");
                break;

                case 3:
                Console.WriteLine("Março!");
                break;

                case 4:
                Console.WriteLine("Abril!");
                break;

                case 5:
                Console.WriteLine("Junho!");
                break;

                case 6:
                Console.WriteLine("Julho!");
                break;

                case 7:
                Console.WriteLine("Julho!");
                break;

                case 8:
                Console.WriteLine("Agosto!");
                break;

                case 9:
                Console.WriteLine("Setembro!");
                break;

                case 10:
                Console.WriteLine("Outubro!");
                break;

                case 11:
                Console.WriteLine("Novembro!");
                break;

                case 12:
                Console.WriteLine("Dezembro!");
                break;
            }
        }
    }
}
