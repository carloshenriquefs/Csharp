using System;

namespace RaizQuadradaeNumNegativo {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("[ RAIZ QUADRADA ]");
            Console.WriteLine ("Informe um número: ");
            int num = int.Parse (Console.ReadLine ());

            while (num > 0) {
                double raiz = Math.Sqrt (num);
                Console.WriteLine ("Raiz Quadrada = " + raiz);
                Console.WriteLine ("Informe outro número: ");
                num = int.Parse (Console.ReadLine ());
                raiz = Math.Sqrt (num);

            }
            Console.WriteLine ("[NUMBER NEGATIVO] - Número Invalido!");
        }
    }
}