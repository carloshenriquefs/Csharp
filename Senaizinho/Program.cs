using System;
using System.IO;

namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Aluno> list = new List<Aluno>();
            // List<Salas> list = new List<Salas>();

            Console.WriteLine("======================");
            Console.WriteLine("   - SENAIZINHO -");
            Console.WriteLine("======================");
            Console.WriteLine();
            Console.WriteLine("       MENU:");
            Console.WriteLine("1 - Cadastrar Aluno:");
            Console.WriteLine("2 - Cadastrar Sala:");
            Console.WriteLine("3 - Alocar Aluno:");
            Console.WriteLine("4 - Remover Aluno:");
            Console.WriteLine("5 - Verificar Salas:");
            Console.WriteLine("6 - Verificar Alunos:");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
            int opcao = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (opcao == 1)
                {
                    Console.WriteLine("Cadastrar Aluno");
                    
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Cadastrar Sala");
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Alocar Aluno");
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Remover Aluno");
                    
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Verificar Salas");
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("Verificar Alunos");
                }
                else
                {
                    Console.WriteLine("Sair");
                }
            }

        }
            public static void CadastrarAluno()
            {
                // int escola = 100;
                Console.WriteLine("NOME: ");
                string nome = Console.ReadLine();
                Console.WriteLine("IDADE: ");
                int idade = int.Parse(Console.ReadLine());

                // string[,] alunos = new string [10,10];
                // alunos[sala] = nome;
             
                
            }

            public void CadastrarSala()
            {
                Console.WriteLine("CAPACIDADE ESCOLA:");
                Console.WriteLine("CAPACIDADE MÁXIMA = 10 SALAS");
                Console.WriteLine("INFORME A QUANTIDADE DE SALAS DISPONÍVEIS:");
                int quantidadeEscola = int.Parse(Console.ReadLine());
                if(quantidadeEscola > 10)
                {
                    Console.WriteLine("ESCOLA CHEIA!");
                    Console.WriteLine("IMPOSSIVEL ADICIONAR SALAS");
                }
                else
                {
                    Console.WriteLine("ESCOLA COM CAPACIDADE DE SALAS");
                    Console.WriteLine("INSIRA O NÚMERO DA SALA:");
                    int numeroSala = int.Parse(Console.ReadLine());
                }
            }

            public void AlocarAluno()
            {
                Console.WriteLine("NOME DO ALUNO:");
                string nome = Console.ReadLine();
                Console.WriteLine("INDIQUE O NÚMERO DA SALA");
                int numeroSala = int.Parse(Console.ReadLine());

            }

            public void RemoverAluno()
            {
                Console.WriteLine("NOME DO ALUNO:");
                string nome = Console.ReadLine();

            }

            public void VerificarSalas()
            {
                Console.WriteLine("NÚMERO DA SALA:");
                int numSala = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de Alunos na sala:");
                int quantidadeAlunos = int.Parse(Console.ReadLine());

            }

            public void VerificarAlunos()
            {
                Console.WriteLine("ALUNOS MATRICULADOS:");
                Console.WriteLine("NOME DO ALUNO:");
                string nome = Console.ReadLine();
                Console.WriteLine("NÚMERO DA SALA - MATRICULA");
                int sala = int.Parse(Console.ReadLine());
            }
    }
}
