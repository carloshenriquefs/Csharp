using System;

namespace CrescenteDecrescente {
    class Program {

        //Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma mensagem que 
        //indique se estes valores foram digitados em ordem crescente ou decrescente.
        static void Main (string[] args) {
            Console.WriteLine ("===================================");
            Console.WriteLine ("   | CRESCENTE E DECRESCENTE |");
            Console.WriteLine ("===================================");
            Console.WriteLine();
            string Continuar = "N";
            string ContinuarOpcao = "";
            int tentativas = 0;

            do {
                for (int i = 0; i < 1; i++) {
                    int num1 = int.Parse (Console.ReadLine ());
                    int num2 = int.Parse (Console.ReadLine ());

                    if (num1 > num2) {
                        Console.WriteLine ("Decrescente!");
                    } else if (num1 < num2) {
                        Console.WriteLine ("Crescente!");
                    } else {
                        Console.WriteLine (" ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("====================");
                Console.Write ("| Quer Continuar? |");
                ContinuarOpcao = Console.ReadLine ();
                Console.WriteLine("=====================");
                tentativas++;
            } while (Continuar != ContinuarOpcao.ToUpper());
            Console.WriteLine();
            Console.WriteLine("Você usou "+tentativas+" vezes o programa!");

        }
    }
}