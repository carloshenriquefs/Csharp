using System;

namespace TempoJogoMinutos
{
    class Program
    {
        //Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. 
        //A seguir calcule a duração do jogo. Obs: O jogo tem duração mínima de um (1) 
        //minuto e duração máxima de 24 horas.
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("     | TEMPO DE JOGO COM MINUTOS |");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.Write("Hora Inicial: ");
            double HoraInicial = double.Parse(Console.ReadLine());
            Console.Write("Hora Final: ");
            double HoraFinal = double.Parse(Console.ReadLine());
            double TempoJH = HoraFinal - HoraInicial;
            if(TempoJH < 0)
            {
                TempoJH = 24 + (HoraFinal - HoraInicial);
                 Console.WriteLine("O JOGO DUROU "+TempoJH+" HORA(S) E "+TempoJH+ " MINUTOS (S)");
            }

            Console.Write("Minuto Inicial: ");
            double MinutoInicial = double.Parse(Console.ReadLine());
            Console.Write("Minuto Final: ");
            double MinutoFinal = double.Parse(Console.ReadLine());
            double TempoJM = MinutoFinal - MinutoInicial;
            if(TempoJM < 0)
            {
                TempoJM = 60 + (MinutoFinal - MinutoInicial);
                Console.WriteLine("O JOGO DUROU "+TempoJM+" HORA(S) E "+TempoJM+ " MINUTOS(S)");
            }

            if(HoraFinal == HoraInicial && MinutoFinal == MinutoInicial)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU "+ TempoJH + " HORA(S) E "+TempoJM +" MINUTO(S)");
            }



        }
    }
}
