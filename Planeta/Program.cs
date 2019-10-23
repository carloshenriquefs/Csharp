using System;

namespace Planeta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NÚMERO DO PLANETA:");
            int numeroPlaneta = int.Parse(Console.ReadLine());
            // Console.WriteLine("PESO NA TERRA: ");
            // double peso = double.Parse(Console.ReadLine());

            if(numeroPlaneta == 1)
            {
                Console.WriteLine("PLANETA - Mercúrio | GRAVIDADE - 0.37");
                double Planeta = 0.37 * 10;
                Console.WriteLine("Gravidade: "+Planeta);
            }
            else if(numeroPlaneta == 2)
            {
                Console.WriteLine("PLANETA - Vênus | GRAVIDADE - 0.88");
                double Planeta = 0.88 * 10;
                Console.WriteLine("Gravidade: "+ Planeta);
            }
            else if(numeroPlaneta == 3)
            {
                Console.WriteLine("PLANETA - Marte | GRAVIDADE - 0.38");
                double Planeta = 0.38 * 10;
                Console.WriteLine("Gravidade: "+Planeta);
            }
            else if(numeroPlaneta == 4)
            {
                Console.WriteLine("PLANETA - Júpter | GRAVIDADE - 2.64");
                double Planeta = 2.64 * 10;
                Console.WriteLine("Gravidade: "+Planeta);
            }
            else if(numeroPlaneta == 5)
            {
                Console.WriteLine("PLANETA - Saturno | GRAVIDADE - 1.15");
                double Planeta = 1.15 + 10;
                Console.WriteLine("Gravidade: "+Planeta);
            }
            else if(numeroPlaneta == 6)
            {
                Console.WriteLine("PLANETA - Urano | GRAVIDADE - 1.17");
                double Planeta = 1.17 + 10;
                Console.WriteLine("Gravidade: "+Planeta);
            }
            else
            {
                Console.WriteLine("Opção Inválida!!");
            }

        }
    }
}
