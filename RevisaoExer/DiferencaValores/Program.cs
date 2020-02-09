using System;

namespace DiferencaValores
{
    class Program
    {
        static void Main(string[] args)
        {
           double A,B,C,D,Diferenca;

           Console.WriteLine("Informe o 1º número: ");
           A = double.Parse(Console.ReadLine());
           
           Console.WriteLine("Informe o 2º número: ");
           B = double.Parse(Console.ReadLine());
           
           Console.WriteLine("Informe o 3º número: ");
           C = double.Parse(Console.ReadLine());

           Console.WriteLine("Informe o 4º número: ");
           D = double.Parse(Console.ReadLine());  

           Diferenca = (A*B - C*D);  

           Console.WriteLine("Diferença = "+Diferenca);   
        }

    }
}
