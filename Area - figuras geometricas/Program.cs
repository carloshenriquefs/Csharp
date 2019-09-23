using System;

namespace Area___figuras_geometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0;
            double pi = 3.14;
            string continuar = "S";

            do{
            Console.WriteLine("=================");
            Console.WriteLine("CALCULE AS ÁREAS");
            Console.WriteLine("=================");
            Console.WriteLine("[1] - Quadrado");
            Console.WriteLine("[2] - Circulo");
            Console.WriteLine("[3] - Triangulo");
            Console.WriteLine("[4] - Retângulo");
            Console.WriteLine("[5] - Losango");
            Console.WriteLine("[6] - Trapezio");
          
            Console.WriteLine("\nInforme a forma geométrica");
            string opcao = Console.ReadLine();
        

            switch (opcao)
            {
                case "1":
                   Console.WriteLine("QUADRADO:");
                    Console.WriteLine("Informe o primeiro lado:");
                    double lado = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o segundo lado:");
                    double lado1 = double.Parse(Console.ReadLine());
                    area = lado * lado1;
                    Console.WriteLine("Area = " + area);
                    break;

                case "2":
                    Console.WriteLine("CIRCULO:");
                    Console.WriteLine("Informe o primeiro raio:");
                    double raio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o segundo raio:");
                    double raio2 = double.Parse(Console.ReadLine());
                    area = pi * raio * raio;
                    Console.WriteLine("Area = " + area);
                    break;

                case "3":
                   Console.WriteLine("TRIÂNGULO:");
                    Console.WriteLine("Informe a base do triângulo: ");
                    double Base = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura:");
                    double altura = double.Parse(Console.ReadLine());
                    area = (Base * altura) / 2;
                    Console.WriteLine("Area = " + area);
                    break;

                case "4":
                    Console.WriteLine("RETÂNGULO:");
                    Console.WriteLine("Informe a base do retângulo: ");
                    double Base1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura do retângulo:");
                    double altura1 = double.Parse(Console.ReadLine());
                    area = altura1 * Base1;
                    Console.WriteLine("Area = " + area);
                    break;

                case "5":
                   Console.WriteLine("LOSANGO:");
                    Console.WriteLine("Informe a base MAIOR do trapezio:");
                    double BASE = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a base MENOR do trapézio:");
                    double base6 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura do trapézio:");
                    double altura5 = double.Parse(Console.ReadLine());
                    area = ((BASE + base6) * altura5) / 2;
                    Console.WriteLine("Area = " + area);
                    break;

                case "6":
                    Console.WriteLine("TRAPEZIO:");
                    Console.WriteLine("Informe a diagonal MAIOR do Losango:");
                    double DIAGONAL = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a diagonal MENOR do Losango:");
                    double diagonal = double.Parse(Console.ReadLine());
                    area = (DIAGONAL * diagonal) / 2;
                    Console.WriteLine("Area = " + area);
                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.WriteLine("Tente novamente");
                    break;
            }
                Console.WriteLine("Quer Continuar? [S/N]:");
                continuar = Console.ReadLine();
            }while(continuar == "S");
        }
    }
}
