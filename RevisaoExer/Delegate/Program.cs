using System;

namespace Delegate
{
    class Program
    {
        delegate double Operacao(double x, double y);
        static void Main(string[] args)
        {
            Operacao soma = (x, y) => x + y;
            Operacao subtrair = (x, y) => x - y;
            Operacao multiplicar = (x, y) => x * y;
            Operacao divisao = (x, y) => x / y;

            // Console.WriteLine("Soma = {0}",soma(4,4));
            // Console.WriteLine("Subtração = {0}",subtrair(8,4));
            // Console.WriteLine("Multiplicação = {0} ",multiplicar(2,4));
            // Console.WriteLine("Divisao = {0}",divisao(8,2));

            Console.WriteLine("=========================");
            Console.WriteLine("    |  DELEGATE  |");
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.Write("Informe um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Informe outro número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Soma = {0}",soma(num1,num2));
            Console.WriteLine("Subtração = {0}",subtrair(num1,num2));
            Console.WriteLine("Multiplicação = {0}",multiplicar(num1,num2));
            Console.WriteLine("Divisão = {0}",divisao(num1,num2));
        }
    }
}
