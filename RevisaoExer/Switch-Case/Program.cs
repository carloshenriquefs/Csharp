using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um dia da semana com número: ");
            int numeroDay =  int.Parse(Console.ReadLine());
            string Day = "";


            switch (numeroDay)
            {
                case 1:
                Day = "Segunda-Feira";
                break;

                case 2:
                Day = "Terça-Feira";
                break;

                case 3:
                Day = "Quarta-Feira";
                break;

                case 4:
                Day = "Quinta-Feira";
                break;

                case 5:
                Day = "Sexta-Feira";
                break;

                case 6:
                Day = "Sábado";
                break;

                case 7:
                Day = "Domingo";
                break;

                default:
                Day = "Valor Invalido";
                break;

            }

            Console.Write("Dia - "+ Day);
        }
    }
}
