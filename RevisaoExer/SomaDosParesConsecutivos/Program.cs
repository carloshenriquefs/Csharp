using System;

namespace SomaDosParesConsecutivos {
    class Program { //O programa deve ler um valor inteiro X indefinidas vezes. (O programa irá parar quando 
        //o valor de X for igual a 0). Para cada X lido, imprima a soma dos 5 pares consecutivos a 
        //partir de X, inclusive o X , se for par. Se o valor de entrada for 4, por exemplo, a saída 
        //deve ser 40, que é o resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada 
        //for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.
        static void Main (string[] args) {
            int num, y = 0;
            Console.WriteLine ("| INFORME |");
            Console.WriteLine ();
            Console.Write ("Número: ");
            do {
                num = int.Parse (Console.ReadLine ());
                if (num == 0) {
                    break;
                } else if (num % 2 == 0) {
                    for (int i = num; i <= num + 8; i = i + 2) {
                        y = y + i;
                    }
                } else {
                    for (int i = num + 1; i <= num + 80; i += 2) {
                        y = y + 1;
                    }
                }
                Console.WriteLine (y);

            } while (num > 0);
        }
    }
}