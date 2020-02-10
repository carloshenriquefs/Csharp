using System;

namespace ImparesSequencia {
    class Program {
        //Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares 
        //consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.

        static void Main (string[] args) {
            Console.WriteLine ("Informe um número: ");
            int numero = int.Parse (Console.ReadLine ());

            for (int i = numero; i < numero; i++) {
                if (numero % 2 == 0) {
                    Console.WriteLine (i);
                }
            }
            for (int y = 1; y <= 6; y = numero + 2) {
                if (numero % 2 == 1) {
                    Console.WriteLine (numero);
                }
            }
        }
    }
}