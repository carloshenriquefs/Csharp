using System;

namespace Login___Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOGIN E SENHA");
            Console.WriteLine("Informe o seu LOGIN");
            string login = Console.ReadLine();

            Console.WriteLine("Informe a sua SENHA");
            string senha = Console.ReadLine();

            if (login == "admin" && senha == "admin")
            {
                Console.WriteLine("SEJA BEM VINDO - Administrador!");
            }
            else
            {
                Console.WriteLine("Você não é o Administrado!");
            }
            
           
           
        }
    }
}
