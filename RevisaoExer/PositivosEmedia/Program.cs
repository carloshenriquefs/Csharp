using System;

namespace PositivosEmedia {
    class Program {
        //Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram 
        //positivos. Na próxima linha, deve-se mostrar a média de todos os valores 
        //positivos digitados, com um dígito após o ponto decimal.
        static void Main (string[] args) {
            double total = 0;
            double num1 = 0;
            double soma = 0;
            Console.WriteLine ("========================");
            Console.WriteLine ("   POSITIVO E MEDIA");
            Console.WriteLine ("========================");
            Console.WriteLine ();

            int[] vetor = new int[6];

                Console.WriteLine ("Informe 6 valores: ");
            for (int i = 1; i <= vetor.Length; i++) {
                num1 = int.Parse (Console.ReadLine ());

                if (num1 > 0) {
                    total = total +1;
                    soma += num1;
                }
            }

            Console.WriteLine ("São " + total + " números positivos!");
            Console.WriteLine("Media = "+soma/total);
        }
    }
}