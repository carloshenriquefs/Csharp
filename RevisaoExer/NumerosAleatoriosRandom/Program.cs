using System;
using System.Collections.Generic;

namespace NumerosAleatoriosRandom {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ();
            Console.WriteLine ("      [ RANDOM ]");
            Console.WriteLine ("    [ PAR  |  IMPAR ]");
            Console.WriteLine ();

            Random NumeroAleatorio = new Random ();

            int[] vetor = new int[10];

            List<int> NumPares = new List<int> ();
            List<int> NumImpares = new List<int> ();

            for (int i = 0; i < vetor.Length; i++) {
                int numero = NumeroAleatorio.Next (1, 21);
                vetor[i] = numero;
                Console.WriteLine ("Número informado: " + numero);

            }

            Console.WriteLine ();
            Console.WriteLine("\t| PARES or IMPARES |");
            Console.WriteLine ();
            foreach (int num in vetor) {
                if (num % 2 == 0) {
                    NumPares.Add (num);
                    Console.WriteLine ("\tO número {0} é PAR!", num);
                } else {
                    NumImpares.Add (num);
                    Console.WriteLine ("\tO número {0} é IMPAR!", num);
                }

            }

        }
    }
}