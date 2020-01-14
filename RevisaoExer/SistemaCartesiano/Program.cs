using System;

namespace SistemaCartesiano {
    class Program {
        static void Main (string[] args) {
            Console.Write("Digite as coordenadas: ");
            string[] cartesiano = Console.ReadLine ().Split (' ');
            double eixoX = double.Parse (cartesiano[0]);
            double eixoY = double.Parse (cartesiano[1]);

            while (eixoX != 0 && eixoY != 0) {
                if (eixoX > 0 && eixoY > 0) {
                    Console.WriteLine ("Primeiro Quadrante!");
                } else if (eixoX > 0 && eixoY < 0) {
                    Console.WriteLine ("Quarto Quadrante!");
                } else if (eixoX < 0 && eixoY < 0) {
                    Console.WriteLine ("Terceiro Quadrante!");
                } else if (eixoX < 0 && eixoY > 0) {
                    Console.WriteLine ("Segundo Quadrante!");
                }
                Console.WriteLine();
                Console.Write("Digite Novamente: ");
            cartesiano = Console.ReadLine().Split(' ');
            eixoX = double.Parse(cartesiano[0]);
            eixoY = double.Parse(cartesiano[1]);
            }
        }
    }
}