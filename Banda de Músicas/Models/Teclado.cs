using System;
using Banda_de_Músicas.Interfaces;

namespace Banda_de_Músicas.Models
{
    public class Teclado : Instrumentos, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando no ritmo do teclado.");
            return true;
        }

        public bool TocarSolo()
        {
            Console.WriteLine("Toncando no ritmo do teclado.");
            return true;
        }

        
    }
}