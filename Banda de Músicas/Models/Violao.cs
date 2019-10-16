using System;
using Banda_de_Músicas.Interfaces;

namespace Banda_de_Músicas.Models
{
    public class Violao : Instrumentos, IHarmonia, IPercurssao, IMelodia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo ritmo do Violão.");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes do Violão.");
            return true;
        }

        public bool TocarSolo()
        {
            Console.WriteLine("Tocando solo do Violão");
            return true;
        }
    }
}