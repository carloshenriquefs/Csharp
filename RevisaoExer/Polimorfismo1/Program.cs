using System;
using System.Collections.Generic;
using Polimorfismo1.Entities;

namespace Polimorfismo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> func = new List<Employee>();

            Console.Write("Entre com o número de funcionários: ");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numeroFuncionarios; i++)
            {
                Console.WriteLine("Funcionários #"+i+":");
                Console.Write("Tercerizado (y/n)?");
                char SimN = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string NomeF = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por horas: ");
                int valorPorHoras = int.Parse(Console.ReadLine());
                if(SimN == 'S')
                {
                    Console.Write("Taxa Adicional: ");
                    double taxaAdicional = double.Parse(Console.ReadLine());
                    func.Add(new OutsourceEmployee(NomeF,horas,valorPorHoras,taxaAdicional));
                }
                else
                {
                    func.Add(new Employee(NomeF,horas,valorPorHoras));
                }

            }
                Console.WriteLine();
                Console.WriteLine("Pagamentos: ");
                foreach(Employee nome in func)
                {
                    Console.WriteLine(nome.Nome + "- $ "+ nome.Pagamento().ToString());
                }
        }
    }
}
