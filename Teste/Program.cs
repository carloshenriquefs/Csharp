using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma(2,3);
            int s2 = Calculadora.Soma(2,4,7);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
