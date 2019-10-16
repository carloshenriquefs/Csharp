using System;
using Banda_de_Músicas.Interfaces;

namespace Banda_de_Músicas.Models
{
    public class Guitarra : Instrumentos, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acorders de Guitarra.");
            return true;
        }

        public bool TocarSolo()
        {
            Console.WriteLine("Tocando solo de Guitarra.");
            return true;
        }
    }
}