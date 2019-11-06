using ZOO;
using System;
using ZOO.Interfaces;

namespace ZOO
{
    class Golfinho : Animal, IBranquiado
    {
        public string Branqueas()
        {
            throw new NotImplementedException();
        }

        public bool GolfinhoAnimal()
        {
            Console.WriteLine();
            Console.WriteLine("    - PISCINA - ");
            Console.WriteLine();
            Console.WriteLine("DESCRIÇÃO: Água doce e\ncom bastante mato,\nárvores e terra ao redor.");
            return true;
        }
    }
}