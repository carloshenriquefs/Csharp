using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("=======================");
            Console.WriteLine("      BYTE-BANK");
            Console.WriteLine("=======================");

            // string[] usuario = new string[1];
            // string[] cpf = new string[1];
            // string[] email = new string[1];
            // string[] senha = new string[1];

            // for (int i = 0; i < 3; i++)
            // {
            //     Console.WriteLine("Informe o seu nome:");
            //     usuario[i] = Console.ReadLine();
            //     Console.WriteLine("Informe o seu CPF:");
            //     cpf[i] = Console.ReadLine();
            //     Console.WriteLine("Informe o seu EMAIL:");
            //     email[i] = Console.ReadLine();
            //     Console.WriteLine("Informe a sua senha:");
            //     senha[i] = Console.ReadLine();
            // }


            // Cliente cliente = new Cliente();

            // cliente.Nome

            //correção professor:
            Console.WriteLine("CADASTRO DE CLIENTES:");
            Console.WriteLine();
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string Cpf = Console.ReadLine();
            Console.WriteLine("Email:");
            string Email = Console.ReadLine();

            Cliente cliente = new Cliente(nome,Cpf,Email);

            bool senhaOk = false;
            do{
                Console.WriteLine("Digite a senha?");
                string senha = Console.ReadLine();
                bool senhaOK = cliente.TrocaSenha(senha);
                if(!senhaOK)
                {
                    Console.WriteLine("Senha não atende aos requisitos!!");
                }
                else{
                    Console.WriteLine("Senha trocada com sucesso");
                }
            }while(!senhaOK);

        }

        
    }
}
