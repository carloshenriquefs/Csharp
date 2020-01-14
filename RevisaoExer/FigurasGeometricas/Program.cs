using System;
using System.Globalization;

namespace FigurasGeometricas
{
    class Program
    {
        //Fazer um programa que leia três valores com ponto flutuante de dupla
        //precisão: A,B e C. Em seguida, calcule e mostre:
        //a) a area do triangulo retangulo que tem A por base e C por altura
        //b) a área do circulo de raio C (pi=3.14159)
        //c) a área do trapezio que tem A e B por bases e C por altura
        //d) a área do quadrado que tem lado B
        //e) a área do retângulo que tem lados A e B

        static void Main(string[] args)
        {
            double Pi = 3.14159;

            Console.WriteLine();
            Console.WriteLine(" [ FIGURA GEOMETRICA ]");
            Console.WriteLine();
            Console.WriteLine("[1] - TRIÂNGULO RETÂNGULO ");
            Console.WriteLine("[2] - CIRCULO ");
            Console.WriteLine("[3] - TRAPEZIO ");
            Console.WriteLine("[4] - QUADRADO");
            Console.WriteLine("[5] - RETÂNGULO ");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("        [ INFORME ]");
            Console.Write("Valores para a Figura Geometrica: ");
            string [] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0],CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1],CultureInfo.InstalledUICulture);
            double C = double.Parse(valores[2],CultureInfo.InvariantCulture);
            Console.WriteLine();
            if(opcao == 1)
            {
                Console.WriteLine("TRIÂNGULO RETÂNGULO");
                double Triangulo = A * C/ 2.00;
                Console.WriteLine("Triângulo = {0}",Triangulo);
            }
            else if(opcao == 2)
            {
                Console.WriteLine("CIRCULO ");
                double Circulo = Pi * C * C;
                Console.WriteLine("Circulo = {0}",Circulo);
            }
            else if(opcao == 3)
            {
                Console.WriteLine("TRAPEZIO");
                double Trapezio = (A + B) / 2 *C;
                Console.WriteLine("Trapézio = {0}",Trapezio);
            }
            else if(opcao == 4)
            {
                Console.WriteLine("QUADRADO");
                double Quadrado = B * B;
                Console.WriteLine("Quadrado = {0}", Quadrado);
            }
            else if(opcao == 5)
            {
                Console.WriteLine("RETÂNGULO");
                double Retangulo = A * B;
                Console.WriteLine("Retângulo = {0}", Retangulo);
            }
            else{
                Console.WriteLine("Opção Invalida!!");
            }
        }
    }
}
