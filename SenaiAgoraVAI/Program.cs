using System;

namespace SenaiAgoraVAI
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos;
            int limiteSalas;
            int alunosCadastrados;
            int salasCadastradas;
            bool querSair;

            Console.WriteLine("================");
            Console.WriteLine("   SENAIZINHO  ");
            Console.WriteLine("================");
            Console.WriteLine();
            Console.WriteLine("      MENU");
            Console.WriteLine();
            Console.WriteLine("[1] - CADASTRAR ALUNO: ");
            Console.WriteLine("[2] - CADASTRAR SALA: ");
            Console.WriteLine("[3] - ALOCAR ALUNO:");
            Console.WriteLine("[4] - REMOVER ALUNO:");
            Console.WriteLine("[5] - VERIFICAR SALAS:");
            Console.WriteLine("[6] - VERIFICAR ALUNOS:");
            Console.WriteLine("[0] - SAIR");
            Console.WriteLine();
            Console.WriteLine("Insira uma opção:");
            int opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                Console.WriteLine("[1] - CADASTRAR ALUNO:");
            }
            else if(opcao == 2)
            {
                Console.WriteLine("[2] - CADASTRAR SALA:");
            }
            else if(opcao == 3)
            {
                Console.WriteLine("[3] - ALOCAR ALUNO:");
            }
            else if(opcao == 4)
            {
                Console.WriteLine("[4] - REMOVER ALUNO:");
            }
            else if(opcao == 5)
            {
                Console.WriteLine("[5] - VERIFICAR SALAS:");
            }
            else if(opcao == 6)
            {
                Console.WriteLine("[6] - VERIFICAR SALAS:");
            }
            else
            {
                Console.WriteLine("[0] - SAIR");
            }

        }
            public void CadastrarAluno()
            {
                Console.WriteLine("NOME:");
                string aluno = Console.ReadLine();
                Console.WriteLine("IDADE:");
                int idade = int.Parse(Console.ReadLine());

                string[] alunos = new string[]
            }

            public void CadastrarSala()
            {

            }

            public void AlocarAluno()
            {

            }

            public void RemoverAluno()
            {

            }

            public void VerificarSalas()
            {

            }
    }
}
