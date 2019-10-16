using System;
using Banda_de_Músicas.Interfaces;

namespace Banda_de_Músicas.Models
{
    public class Baixo : Instrumentos, IPercussao, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes de Baixo.");
            return true;
        }

        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo ritmo do Baixo.");
            return true;
        }
    }
}