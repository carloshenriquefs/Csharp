using System;
using Banda_de_Músicas.Interfaces;


namespace Banda_de_Músicas.Models
{
    public class ContraBaixo : Instrumentos, IPercurssao, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes de Contra Baixo.");
            return true;
        }

        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo ritmo do Contra Baixo.");
            return true;
        }
    }
}