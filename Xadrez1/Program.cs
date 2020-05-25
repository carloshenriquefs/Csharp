using System;
using Tabuleiro;

namespace Xadrez1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tab= new Tabuleiros(8,8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
