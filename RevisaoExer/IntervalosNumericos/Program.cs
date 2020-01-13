using System;
using System.Globalization;

namespace IntervalosNumericos
{
    class Program
    {
        //Você deve fazer um programa que leia um valor qualquer
        //e apresente uma mensagem dizendo em qual dos seguintes
        //intervalos ([0,25], (25,50],(75,100]) este valor se encontra
        //Obviamente se o valor não estiver em nenhum destes intervalos
        //deverá ser impressa a mensagem "Fora de intervalo".
        static void Main(string[] args)
        {
            Console.WriteLine("[INFORME]");
            Console.WriteLine();
            Console.Write("Valor: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(numero <= 25.0)
            {
                Console.WriteLine("Intervalo (0,25]");
            }
            else if(numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if(numero <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100])");
            }
            else if(numero < 0.0 || numero > 100)
            {
                Console.WriteLine("Número Invalido!!!");
            }
        }
    }
}
