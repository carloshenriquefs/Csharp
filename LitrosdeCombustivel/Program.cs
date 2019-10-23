using System;

namespace LitrosdeCombustivel
{
    class Program
    {
        //Criar um programa que efetue o cálculo da quantidade de litros de combustível 
        //gastos em uma viagem, sabendo-se que o carro faz 12 km com um litro. Deverão ser 
        //fornecidos o tempo gasto na viagem e a velocidade média. Utilizar as seguintes fórmulas:

        static void Main(string[] args)
        {
            Console.WriteLine("================");
            Console.WriteLine("  COMBUSTÍVEL");
            Console.WriteLine("================");
            Console.WriteLine("  - INFORME - ");
            Console.WriteLine("=======================");
            Console.Write("   TEMPO GASTO: ");
            double tempo = double.Parse(Console.ReadLine());
            Console.Write("   VELOCIDADE MÉDIA: ");
            double velocidade = double.Parse(Console.ReadLine());
            Console.WriteLine("=======================");
            Console.WriteLine();
            double Distancia = tempo * velocidade;
            double Litros = Distancia /12;

            Console.WriteLine("VELOCIDADE MÉDIA: "+velocidade);
            Console.WriteLine("DISTÂNCIA = "+Distancia+"Km");
            Console.WriteLine("LITROS USADOS = "+ Litros+"L");
            Console.WriteLine("COMBUSTIVEL GASTO: R$ "+ Litros*12);
        }
    }
}
