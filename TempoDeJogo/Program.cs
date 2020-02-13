using System;

namespace TempoDeJogo
{
    class Program
    {
        //Leia a hora inicial e a hora final de um jogo. A seguir 
        //calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e 
        //terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.


        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("    | TEMPO DE JOGO |");
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("      | INFORME |");
            Console.WriteLine();
            Console.Write("Hora Inicial: ");
            int HoraInicial = int.Parse(Console.ReadLine());
            Console.Write("Hora Final: ");
            int HoraFinal = int.Parse(Console.ReadLine());

            double Tempo = 24 - HoraInicial + HoraFinal;

            Console.WriteLine("Tempo = "+Tempo);
            Console.WriteLine("O JOGO DUROU "+Tempo+" HORA(S)");
        }
    }
}
