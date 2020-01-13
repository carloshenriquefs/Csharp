using System;
using System.Globalization;

namespace ConjuntoValoresMedia
{
    class Program
    {
        //Leia 1 o valor inteiro N, que representa o número de casos
        //de teste que vem a seguir. Cada caso de teste consiste de 3 valores
        // reais, cada um deles com uma casa decimal. Apresente a média ponderada
        //para cada um destes conjuntos de 3 valores, sendo que o primeiro valor
        //tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de valores: ");
            int valores = int.Parse(Console.ReadLine());

            for(int i = 1; valores >= i; i++)
            {
                string [] casos = Console.ReadLine().Split(' ');
                double num1 = double.Parse(casos[0], CultureInfo.InvariantCulture);
                double num2 = double.Parse(casos[1], CultureInfo.InvariantCulture);
                double num3 = double.Parse(casos[2], CultureInfo.InvariantCulture);

                double media = (num1 * 2 + num2 * 3 + num3 * 5) / 10;

                Console.WriteLine("Média = {0}",media);
            }            
        }
    }
}
