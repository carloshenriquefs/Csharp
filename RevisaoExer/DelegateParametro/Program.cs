using System;

namespace DelegateParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            ParametroDelegate.Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(ParametroDelegate.Calculadora(subtracao, 3,2));
            Console.WriteLine(ParametroDelegate.Calculadora(ParametroDelegate.Soma, 3,2));
        }
    }
}
