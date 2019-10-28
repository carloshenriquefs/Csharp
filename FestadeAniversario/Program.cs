using System;
using System.Collections.Generic;

namespace FestadeAniversario
{
    class Program
    {
        //27.Crie um programa para criar uma agenda de aniversários. A agenda deve permitir ao usuário:
        //Cadastar um nome e uma data de nascimento relacionada ao nome.
        //Apagar um nome existente.
        //Procurar por um nome na agenda, exibindo a data de aniversário relacionada caso o nome exista ou uma mensagem de erro, caso o contrário.
        //Listar todos os nomes e aniversários contidos na agenda.

        static void Main(string[] args)
        {

            Dictionary<string, string> Agendamento = new Dictionary<string, string>();

            Console.WriteLine("===========================");
            Console.WriteLine("        ANIVERSÁRIO");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.WriteLine("    LISTA DE AGENDAMENTO");

            Console.WriteLine("         [INFORME]");
            Console.WriteLine();

            Console.Write("Quantidade de Pessoas: ");
            int quantidadeP = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < quantidadeP; i++)
            {
                Console.Write("NOME:");
                string Nome = Console.ReadLine();
                Console.Write("DATA DE NASCIMENTO: ");
                string dataN = Console.ReadLine();
                Agendamento.Add(Nome, dataN);
            }

            Console.WriteLine();
            Console.WriteLine("LISTA DE NOMES: ");
            Console.WriteLine();
            foreach (var dado in Agendamento)
            {
                Console.WriteLine(dado);
            }

            Console.WriteLine();
            Console.Write("PROCURAR UM NOME? [S/N] = ");
            string opcao = (Console.ReadLine().ToUpper());
            if(opcao == "S")
            {
                Console.Write("QUAL NOME VOCÊ PROCURA? ");
                string NomeProcurado = Console.ReadLine();
                if(Agendamento.ContainsKey(NomeProcurado))
                {
                    Console.WriteLine("O nome "+NomeProcurado + " existe!");
                }
                else
                {
                    Console.WriteLine("O nome "+NomeProcurado + " não existe!");
                }
            }
            else
            {
                Console.WriteLine("Prossiga!");
            }

            Console.WriteLine();
            Console.Write("REMOVA UM NOME: ");
            string RemoverNome = Console.ReadLine();
            Agendamento.Remove(RemoverNome);

            Console.WriteLine();
            Console.WriteLine("NOME REMOVIDO DA LISTA: ");
            foreach (var dado1 in Agendamento)
            {
                Console.WriteLine(dado1);
            }




        }
    }
}