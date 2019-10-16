using System;
using Banda_de_Músicas.Interfaces;

namespace Banda_de_Músicas.Models
{
    public class Tambores : Instrumentos, IPercurssao
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo dos tambores");
            return true;
        }
    }
}