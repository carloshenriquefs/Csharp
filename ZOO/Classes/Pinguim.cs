using ZOO;
using System;
using ZOO.Interfaces;

namespace ZOO
{
    class Pinguim : Animal, IAquatico
    {
        public string Nadar()
        {
            throw new NotImplementedException();
        }

        public bool PinguimAnimal()
        {
            Console.WriteLine();
            Console.WriteLine("      - ÁQUARIO -  ");
            Console.WriteLine();
            Console.WriteLine("DESCRIÇÃO: Com água salgada e não possui muita superfície terrestre para os animais.");
            return true;
        }
    }
}