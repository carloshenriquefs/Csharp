using System;
using ZOO;
using ZOO.Interfaces;

namespace ZOO
{
    class TubaraoM : Animal, IAquatico
    {
        public string Nadar()
        {
            throw new NotImplementedException();
        }

        public bool TubaraoAnimal()
        {
            Console.WriteLine();
            Console.Write("       - AQUÁRIO -  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DESCRIÇÃO: Água salgada\ne sem superficie terrestre.");
            return true;
        }
    }
}