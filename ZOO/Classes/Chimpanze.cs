using ZOO;
using System;
using ZOO.Interfaces;

namespace ZOO
{
    class Chimpanze : Animal, IArboricula
    {
        public bool ChimpanzeAnimal()
        {
            Console.WriteLine();
            Console.WriteLine("  - CASA EM ÁRVORES ");
            Console.WriteLine();
            Console.WriteLine("DESCRIÇÃO: Florestas");
            return true;
        }

        public string HabitatArvores()
        {
            throw new NotImplementedException();
        }
    }
}