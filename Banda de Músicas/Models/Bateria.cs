using System;
using System.Collections;
using Banda_de_Músicas;

namespace Banda_de_Músicas.Models
{
    public class Bateria : Instrumentos, IPercussao
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Manter ritmo da Bateria");
            return true;
        }
    }
}