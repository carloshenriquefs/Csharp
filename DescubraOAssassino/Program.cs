using System;

namespace DescubraOAssassino {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("===============================");
            Console.WriteLine ("   | DESCUBRA O ASSASSINO |");
            Console.WriteLine ("===============================");
            Console.WriteLine ();

            Console.WriteLine ("      [SUSPEITOS]");
            Console.WriteLine ();
            Console.WriteLine ("[1] - CHARLES B. ABBAGE ");
            Console.WriteLine ("[2] - DONALD DUCK KNUTH");
            Console.WriteLine ("[3] - ADA L. OVELACE");
            Console.WriteLine ("[4] - ALAN T. URING");
            Console.WriteLine ("[5] - IVAR J. ACOBSON");
            Console.WriteLine ("[6] - RAS MUS LER DORF");
            Console.WriteLine ();
            Console.WriteLine ("      [ LOCAIS ]");
            Console.WriteLine ();
            Console.WriteLine ("[1] - REDMOND");
            Console.WriteLine ("[2] - PALO ALTO");
            Console.WriteLine ("[3] - SAN FRANCISCO");
            Console.WriteLine ("[4] - TOKIO ");
            Console.WriteLine ("[5] - RESTAURANTE NO FIM DO UNIVERSO ");
            Console.WriteLine ("[6] - SÃO PAULO ");
            Console.WriteLine ("[7] - CUPERTINO");
            Console.WriteLine ("[8] - HELSINKI");
            Console.WriteLine ("[9] - MAIDA VALE");
            Console.WriteLine ("[10] - TORONTO");
            Console.WriteLine ();
            Console.WriteLine ("      [ ARMAS ]");
            Console.WriteLine ();
            Console.WriteLine ("[1] - PEIXEIRA");
            Console.WriteLine ("[2] - DYNATAC 8000X");
            Console.WriteLine ("[3] - TREZOITÃO");
            Console.WriteLine ("[4] - TREBUCHET");
            Console.WriteLine ("[5] - MAÇA");
            Console.WriteLine ("[6] - GLADIO");

            Console.WriteLine ();
            Console.WriteLine ("[ INFORME ]");
            Console.WriteLine ();

            Console.WriteLine ("Suspeitos: ");
            int suspeito = int.Parse (Console.ReadLine ());
            do {
                if (suspeito != 2) {
                    Console.WriteLine ("Suspeito Errado!");
                    Console.WriteLine("Informe outra vez: ");
                    int suspeito1 = int.Parse(Console.ReadLine());
                   
                    if(suspeito == 2) {
                        Console.WriteLine ("Acertou!!!");
                        Console.WriteLine ("Locais: ");
                        int locais = int.Parse (Console.ReadLine ());

                        if (locais != 3) {
                            Console.WriteLine ("Local Errado!");

                            if (locais == 3) {
                                Console.WriteLine ("Armas: ");
                                int armas = int.Parse (Console.ReadLine ());

                                if (armas == 4) {

                                }
                            }

                        }
                    }



                }
            } while (suspeito >= 0);

        }
    }
}