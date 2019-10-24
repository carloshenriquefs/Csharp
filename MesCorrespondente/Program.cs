using System;

namespace MesCorrespondente
{
    class Program
    {
        //15. Crie um programa que peça para o usuário um número inteiro entre 1 e 12 e escrever o mês correspondente. 
        //Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando que não existe mês com este número.

        static void Main(string[] args)
        {
            Console.WriteLine("DE 1 a 12:");
            Console.WriteLine("Informe um número: ");
            int numeroMes = int.Parse(Console.ReadLine());

            switch(numeroMes)
            {
                case 1:
                Console.WriteLine("01 - Janeiro");
                break;

                case 2:
                Console.WriteLine("02 - Fevereiro");
                break;

                case 3:
                Console.WriteLine("03 - Março");
                break;

                case 4:
                Console.WriteLine("04 - Abril");
                break;

                case 5:
                Console.WriteLine("05 - Maio");
                break;

                case 6:
                Console.WriteLine("06 - Junho");
                break;

                case 7:
                Console.WriteLine("07 - Julho");
                break;

                case 8:
                Console.WriteLine("08 - Agosto");
                break;

                case 9:
                Console.WriteLine("09 - Setembro ");
                break;

                case 10:
                Console.WriteLine("10 - Outubro");
                break;

                case 11:
                Console.WriteLine("011 - Novembro");
                break;

                case 12:
                Console.WriteLine("012 - Dezembro");
                break;

                default:
                Console.WriteLine("Não existe mês com este número");
                break;
            }
        }
    }
}
