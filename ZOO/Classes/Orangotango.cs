using ZOO;
using System;
using ZOO.Interfaces;

namespace ZOO
{
    class Orangotango : Animal, IArboricula
    {
        public string HabitatArvores()
        {
            throw new NotImplementedException();
        }

        public bool OrangotangoAnimal()
        {
            Console.WriteLine();
            Console.WriteLine("  - CASA EM ÁRVORES -");
            Console.WriteLine();
            Console.WriteLine("DESCRIÇÃO: Florestas");
            return true;
        }
        
    }
}