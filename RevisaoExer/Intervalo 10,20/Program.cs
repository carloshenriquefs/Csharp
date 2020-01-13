using System;

namespace Intervalo_10_20 {
    class Program {
        //Leia um valor inteiro N. Este valor será a quantidade
        //de valores inteiros X que serão lidos em seguida. Mostre
        // quantos destes valores X estão dentro do intervalo [10, 20]
        // e quantos estão fora do intervalo, mostrando essas informações
        //conforme exemplo (use a palavra "in" para dentro do intervalo, e
        // "out" para fora do intervalo)
        static void Main (string[] args) {

            Console.WriteLine("      INTERVALO - [10,20]");
            Console.WriteLine();
            Console.Write ("Informe a quantidade de valores: ");
            int valores = int.Parse (Console.ReadLine ());

            int dentro = 0;
            int fora = 0;
            for (int i = 1; valores >= i; i++) {
                Console.Write ("Informe um valor: ");
                int valor = int.Parse (Console.ReadLine ());
                if (valor >= 10 && valor <= 20) {
                    dentro = 1 + dentro;
                    Console.WriteLine ("O número {0} está dentro do intervalo!!!", valor);
                    Console.WriteLine();
                } else {
                    fora = 1 + fora;
                    Console.WriteLine ("O número {0} está fora do intervalo!!!", valor);
                }
            }
            Console.WriteLine();
            Console.WriteLine("     [NÚMEROS] - DENTRO E FORA");
            Console.WriteLine();
            Console.WriteLine ("Existem {0} números dentro do intervalo!!!", dentro);
            Console.WriteLine ("Existem {0} números fora do intervalo!!!", fora);
        }
    }
}