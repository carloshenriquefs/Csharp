using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;

            Console.WriteLine("===============");
            Console.WriteLine("[1] - SOMA");
            Console.WriteLine("[2] - SUBTRAÇÃO");
            Console.WriteLine("[3] - MULTIPLICAÇÃO");
            Console.WriteLine("[4] - DIVISÃO");
            Console.WriteLine("================");

            Console.WriteLine("Informe um valor: ");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação");
            int oper = int.Parse(Console.ReadLine());

            if(oper == 1)
            {
                Console.WriteLine("SOMA");
                resultado = valor + valor1;
            }
            else if(oper == 2)
            {
                Console.WriteLine("SUBTRAÇÃO");
                resultado = valor - valor1;
            }
            else if(oper == 3)
            {
                Console.WriteLine("MULTIPLICAÇÃO");
                resultado = valor * valor1;
            }
            else if(oper ==4)
            {
                Console.WriteLine("DIVISÃO");
                resultado = valor / valor1;
            }

            Console.WriteLine("Resultado = "+ resultado);
        }
    }
}
