using System;

namespace SalarioFuncionarioClasse
{
    class Program
    {
        //Fazer um programa para ler nome e salário de dois funcionários. 
        //Depois, mostrar o salário médio dos funcionários

        static void Main(string[] args)
        {
            Funcionario f1,f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: R$ ");
            f1.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: R$ ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("A média dos Salários é: R${0}",media);

        }
    }
}
