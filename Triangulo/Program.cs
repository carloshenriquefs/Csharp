using System;

namespace Triangulo
{
    class Program
    {
        //13. Criar uma aplicação que peça para o usuário três números e verificar se 
        //eles podem ou não ser lados de um triângulo. Imprimir a classificação segundo 
        //os lados ou uma mesagem dizendo que os lados não fazem parte de um triângulo.
        static void Main(string[] args)
        {
            Console.WriteLine("TRIÂNGULO");
            Console.WriteLine();
            Console.WriteLine("Informe o lado A:");
            double ladoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado B:");
            double ladoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado C:");
            double ladoC =double.Parse(Console.ReadLine());

            if((ladoA + ladoB > ladoC) &&(ladoB + ladoC > ladoA) && (ladoA + ladoC > ladoB))
            {
                Console.WriteLine("Os lados formam um Triângulo!");
            }
            else
            {
                Console.WriteLine("Os lados não formam um Triângulo!");
            }
        }
    }
}
