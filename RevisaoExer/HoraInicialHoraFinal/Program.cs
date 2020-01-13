using System;

namespace HoraInicialHoraFinal
{
    class Program
    {
        //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração 
        //do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro,
        //tendo uma duração minima de 1 hora e máxima de 24 horas.

        static void Main(string[] args)
        {

            double duracao = 0;
            Console.WriteLine("[ INFORME ]");
            Console.WriteLine("Informe a hora inicial: ");
            double horaInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a hora final: ");
            double horaFinal = double.Parse(Console.ReadLine());

            if(horaFinal > horaInicial)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
                Console.WriteLine("Duração do jogo: {0} ",duracao+" horas");



        }
    }
}
