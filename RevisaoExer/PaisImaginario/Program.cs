using System;

namespace PaisImaginario
{
    class Program
    {
        static void Main(string[] args)
        {
            double imposto = 0;

            Console.WriteLine("[ IMPOSTO DE RENDA ]");
            Console.WriteLine();
            Console.Write("Informe o seu salario: R$ ");
            double salario = double.Parse(Console.ReadLine());

            if(salario <= 2000.00)
            {
                Console.WriteLine("ISENTO!!!");
                Console.WriteLine("Imposto: R$ 0");
            }
            else if(salario <= 3000.00)
            {
                imposto = (salario - 2000.00) *0.08;
                Console.WriteLine("Imposto: R${0}",imposto);
            }
            else if(salario <= 4500.00)
            {
                imposto = (salario - 3000.00) * 0.18 + 1000 *0.08;
                Console.WriteLine("Imposto: R$ {0}",imposto);
            }
            else
            {
                imposto = (salario - 4500.00) *0.28 + 1500.00 * 0.18 + 1000 * 0.08;
                Console.WriteLine("Imposto: R${0}",imposto);
            }
   
        }
    }
}
