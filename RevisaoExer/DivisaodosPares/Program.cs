using System;

namespace DivisaodosPares {
    class Program {
        //Fazer um programa para ler um número N. Depois leia N
        //pares de números e mostre a divisão do primeiro pelo
        //segundo. Se o denominador for igual a zero, mostrar a 
        //mensagem "divisão impossivel"

        static void Main (string[] args) {
            Console.WriteLine ("      [INFORME]");
            Console.Write ("Quantidade de números: ");
            int numeros = int.Parse (Console.ReadLine ());

            for (int i = 1; i <= numeros; i++) {
                Console.Write ("Informe números [PARES]: ");
                string[] vetorNum = Console.ReadLine ().Split (' ');
                int numPares = int.Parse (vetorNum[0]);
                int numPares1 = int.Parse (vetorNum[1]);

                if (numPares1 == 0) {
                    Console.WriteLine ("Divisão Impossivel");
                } else {
                    double divisao = numPares / numPares1;
                    Console.WriteLine ("Resultado = {0}", divisao);
                }

            }
        }
    }
}