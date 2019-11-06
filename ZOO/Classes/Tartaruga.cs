using ZOO;
using System;
using ZOO.Interfaces;

namespace ZOO
{
    class Tartaruga : Animal, IAquatico
    {
        public string Nadar()
        {
            throw new NotImplementedException();
        }

        public bool TartarugaAnimal()
        {
            Console.WriteLine();
            Console.WriteLine("    - PISCINA - ");
            Console.WriteLine();
            Console.WriteLine("DESCRIÇÃO: Água doce e\ncom bastante mato,\nárvores e terra ao redor.");
            return true;
            
        }
    }
}