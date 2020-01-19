using System;
using System.Collections.Generic;

namespace FuncionarioVersao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ FUNCIONARIOS ]");
            Console.WriteLine();
            List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Quantos funcionários: ");
            int qtdFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdFuncionarios;i++)
            {
                Console.WriteLine("Funcionário: #"+i);
                Console.Write("ID: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Salário: ");
                double Salario = double.Parse(Console.ReadLine());
                lista.Add(new Funcionario(Id, Nome, Salario));
            }

            Console.Write("Informe um Id para funcionário: ");
            int procuraId = int.Parse(Console.ReadLine());

            Funcionario funci = lista.Find(x => x.ID == procuraId);

            if(funci != null)
            {
                Console.WriteLine("Informe a porcentagem para o funcionário: ");
                int porcentagem = int.Parse(Console.ReadLine());
                funci.SalarioAumento(porcentagem);
            }
            else
            {
                Console.WriteLine("O ID não existe!!!");
            }

            Console.WriteLine();
            Console.WriteLine("     [ Funcionarios ]");
            Console.WriteLine();
            foreach(Funcionario nomes in lista)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}
