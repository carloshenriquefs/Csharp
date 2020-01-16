using System;
using System.Globalization;
namespace VolumeCircunferencia
{
    //Fazer um programa para ler um valor número qualquer, e daí mostrar
    //quanto seria o valor de uma circunferencia e do volume de uma esfera
    //para um raio daquele valor. Informar também o valor de Pi com duas cadas
    //decimais
    class Program
    {
        static double Pi = 3.14159;
        static void Main(string[] args)
        {
            Console.WriteLine("CIRCUNFERÊNCIA - RAIO");
            Console.WriteLine();
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double cincunferencia = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Cincunferência = "+cincunferencia.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = "+volume.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi ="+Pi.ToString("F4",CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4 / 3 * Pi * r * r * r;
        }
    }
}
