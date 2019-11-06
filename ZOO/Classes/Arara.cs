using ZOO;
using System;
using ZOO.Interfaces;

namespace ZOO
{
    class Arara : Animal, IVoador
    {
        public bool AraraAnimal()
        {
            Console.WriteLine();
            Console.WriteLine("    - GAIOLA -");
            Console.WriteLine("DESCRIÇÃO: Muitas árvores altas. ");
            return true;
        }

        public string Voar()
        {
            throw new NotImplementedException();
        }
    }
}