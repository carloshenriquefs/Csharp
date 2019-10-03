using System;

namespace exerc048
{
    class Program
    {
        //Crie um projeto um aplicação console chamada Byte-Bank que implemente a classe
        //CLIENTES | public string(cpf, nome, email, senha)
        //Crie um construtor que inicialize o objeto com nome,cpf,email
        //Crie um metodo da classe - Cliente - chamado troca a senha, que deve:
        //  Ter como parametro uma string contendo a senha do usuário
        //  Verifique se a senha tem mais que 6 caracteres e menos que 16
        //  E retorne um booleano verdadeiro se a senha  foi alterada com sucesso ou falso caso a ela
        //não  atenda a regra e não possa ser mudada
        //Altere o método Main para e crie uma tela de cadastro que peça para o usuario os dados necessarios para criar o objeto
        //Além disso, após o cadastro faça com que a aplicação solicite uma senha até que o usuário digite uma senha valida
        //A aplicação deve apresentar uma mensagem para o usuario toda vez que ele errar a senha

        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("   BYTE-BANK");
            Console.WriteLine("==================");

            Console.WriteLine("CADASTRO DE CLIENTES:");
            Console.WriteLine();
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            Cliente cliente= new Cliente(nome, cpf, email);
            
                bool trocouSenha = false;
                do
                {
                    Console.WriteLine("Digite a senha:");
                    string senha = Console.ReadLine();
                    trocouSenha = cliente.TrocaSenha(senha);
                    if(!trocouSenha)
                    {
                        Console.WriteLine("Senha não atende aos requisitos");
                    }
                    else
                    {
                        Console.WriteLine("Senha trocada com Sucesso");
                    }
                }while(!trocouSenha);
        }
    }
}
