using System;

namespace QuatroValoresABCD
{
    //Fazer um programa para ler quatro valores inteiros A,B,C e D.
    //A seguir, calcule e mostre a diferença do produto de A e B pelo
    //produto de C e D segundo a fórmula: Diferença = (A*B-C*D)

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIFERENÇA A B C D");
            Console.WriteLine();
            Console.Write("Valor de A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Valor de B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Valor de C: ");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Valor de D: ");
            int D = int.Parse(Console.ReadLine());

            double Diferenca = (A * B - C * D);

            Console.WriteLine("Diferença = {0}",Diferenca);
        } 
    }
}
