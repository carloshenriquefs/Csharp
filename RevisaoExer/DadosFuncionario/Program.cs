using System;

namespace DadosFuncionario
{
    //Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).
    //Em seguida, mostrar os dados do funcionario (nome e salário líquido). Em seguida, aumentar
    //o salário do funcionario com base em uma porcentagem dada (somente o salário bruto é afetado
    // pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe.

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("[ Funcionário ]");
            Console.WriteLine();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: R$ ");
            func.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: R$ ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: "+func);

            Console.Write("Digite a porcentagem para aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcentagem);

            Console.WriteLine("Dados Atualizados: "+func);
        }
    }
}
