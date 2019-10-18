using System;

namespace DateTime
{
    class Program
    {

        //DateTime: Representa um INSTANTE
        //É um tipo valor(struct)

        //Um objeto DateTime internamente armazena:
            //O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de janeiro
            //do ano 1 da era comum

        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2018, 11, 25");

            Console.WriteLine(d1);
        }
    }
}
