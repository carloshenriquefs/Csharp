using ZOO;
using System;
using ZOO.Interfaces;

namespace ZOO
{
    class Leao : Animal, ITerrestre
    {
        public string Andar()
        {
            throw new NotImplementedException();
        }

        public bool LeaoAnimal()
        {
            Console.WriteLine();
            Console.WriteLine("   - CAVERNA DE PEDRA -");
            Console.WriteLine();
            Console.WriteLine("DESCRIÇÃO: Cercada por capim alto,\nterra,algumas árvores e rochas num terreno irregular.");
            return true;
        }
    }
}