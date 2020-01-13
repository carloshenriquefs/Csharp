using System;

namespace NumEDivisores {
    class Program {
        //Ler um número inteiro N e calcular todos os seus divisores
        static void Main (string[] args) {
            Console.WriteLine("[NÚMEROS - DIVISIVEIS]");
            Console.WriteLine();
            Console.Write ("Informe um número: ");
            int num = int.Parse (Console.ReadLine ());

            Console.Write("Os números divisiveis de {0} são: ", num);
            for (int i = 1; i <= num; i++) {
                if (num % i == 0) {
                    Console.Write(i+"-");
                }
            }
        }
    }
}