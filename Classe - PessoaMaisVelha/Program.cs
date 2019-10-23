using System;

namespace Classe___PessoaMaisVelha
{
    class Program
    {
        //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome
        //da pessso mais velha.
        static void Main(string[] args)
        {
            Pessoa pessoaA = new Pessoa();
            Pessoa pessoaB = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoaA.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaB.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoaB.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaB.Idade = int.Parse(Console.ReadLine());

            if(pessoaA.Idade > pessoaB.Idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}", pessoaA.Nome);
            }
            else if(pessoaB.Idade > pessoaA.Idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}", pessoaB.Nome);
            }

        }
    }
}
