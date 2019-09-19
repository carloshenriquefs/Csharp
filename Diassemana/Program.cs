using System;

namespace Diassemana
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Informe os dias da semana:");
            int diasSemana = int.Parse(Console.ReadLine());

            if(diasSemana == 1)
            {
               Console.WriteLine("DOMINGO");
            }
            else if(diasSemana == 2)
            {
                Console.WriteLine("Segunda");
            }
        }
    }
}
