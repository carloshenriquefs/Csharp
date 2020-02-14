using System;

namespace SenhaDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string senhaUsuario = "1234";
            string senha = " ";
            int tentativas = 0;

            do{
                Console.Clear();
                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();
                tentativas = tentativas + 1;
            }while(senha != senhaUsuario);
            Console.WriteLine("Você Conseguiu!!!");
            Console.WriteLine(tentativas + " - Tentativas feitas!!!");
        }
    }
}
