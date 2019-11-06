using ZOO;
using System;
using ZOO.Interfaces;

namespace ZOO
{
    class Tucano : Animal, IVoador
    {
        public bool TucanoAnimal()
        {
            Console.WriteLine();
            Console.WriteLine("     - GAIOLA -");
            Console.WriteLine("DESCRIÇÃO: Muitas árvores altas.");
            return true;
        }

        public string Voar()
        {
            throw new NotImplementedException();
        }
    }
}