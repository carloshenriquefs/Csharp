using System;
using System.Collections.Generic;
using Polimorfismo;


namespace Polimorfismo
{
    class Program
    {
        // Uma empresa possui funcionarios próprios e terceirizados.
        //Para cada funcionario, deseja-se resgistrar nome, horas trabalhadas
        //e valor por hora. Funcionarios terceirizado possuem ainda uma despesa
        //adicional
        static void Main(string[] args)
        {
            List<Funcionarios> _funcionarios = new List<Funcionarios>();

            Console.Write("Número de Funcionários: ");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 1; i < numeroFuncionarios; i++)
            {
                Console.WriteLine("Funcionários #"+i+":");
                Console.Write("Tercerizado: (S/N)?");
                char SimNao = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome:");
                string NomeF = Console.ReadLine();
                Console.WriteLine("Horas: ");
                int Horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por horas: ");
                int horarPor = int.Parse(Console.ReadLine());
                if(SimNao == 'S')
                {
                    Console.Write("Cobrança Adicional: ");
                    double CobrancaAdicional = double.Parse(Console.ReadLine());
                    _funcionarios.Add(new EmpregadoTerceirizado(nomeF, horas, valorPorHoras, cobrancaAdicional));
                }
            }
        }
    }
}
