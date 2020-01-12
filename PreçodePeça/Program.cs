using System;
using System.Globalization;

namespace PreçodePeça
{
    class Program
    {
        //Fazer um programa para ler o código de uma peça 1, o número
        //de peças 1, o valor unitário de cada peça 1, o código de uma 
        //peça 2, o número de peças 2 e o valor unitário de cada peça 2.
        //Calcule e mostre o valor a ser pago.
        static void Main(string[] args)
        {
            string [] peca = Console.ReadLine().Split(' ');
            Console.WriteLine("Informe os valores da primeira peça: ");
            int codigo1 = int.Parse(peca[0]);
            int numPecas1 = int.Parse(peca[1]);
            double valorPecas1 = double.Parse(peca[2], CultureInfo.InvariantCulture);

            peca = Console.ReadLine().Split(' ');
            Console.WriteLine("Informe os valores da segunda peça: ");
            int codigo2 = int.Parse(peca[0]);
            int numPecas2 = int.Parse(peca[2]);
            double valorPecas2 = double.Parse(peca[2], CultureInfo.InvariantCulture);

            double totalPreco = numPecas1 * valorPecas1 + numPecas2 * valorPecas2;

            Console.WriteLine("Valor a ser pago: R${0}"+totalPreco);
        }
    }
}
