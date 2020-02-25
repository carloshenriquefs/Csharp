using System;

namespace ParametroPadrao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ParametroP.Somar(10, 23));
            Console.WriteLine(ParametroP.Somar(50));
            Console.WriteLine(ParametroP.Somar());
            Console.WriteLine(ParametroP.Somar( b: 7));
        }
    }
}
