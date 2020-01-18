using System;

namespace PensionatoVersao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("[ PENSIONATO - VERSAO 2 ]");
            Console.WriteLine();

            Aluno [] vetor = new Aluno[10];

            Console.Write("Informe o número de estudantes: ");
            int numEstudantes = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numEstudantes; i++)
            {
                Console.WriteLine("Estudante: #"+i);
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Email: ");
                string Email = Console.ReadLine();
                Console.Write("Qual o quarto escolhido: ");
                int quartoEscolhido = int.Parse(Console.ReadLine());
                vetor[quartoEscolhido] = new Aluno(Nome,Email);
            }

            Console.WriteLine("Quartos Ocupados");
            for(int i = 0; i < 10;i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(i + " °  - Quarto: " + vetor[i] + "- |OCUPADO|");
                }
            }
        }
    }
}
