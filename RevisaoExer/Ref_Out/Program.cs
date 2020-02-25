using System;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            ParametrosReferencia.AlterarRef(ref a);
            Console.WriteLine(a);

            //int b = 2;
            ParametrosReferencia.AlterarOut (out int b, out int c);
            Console.WriteLine($"{b} {c}");
        }
    }
}
