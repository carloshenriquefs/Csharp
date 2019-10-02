using System;

namespace Byte_Bank.Cliente
{
    class Cliente
    {
       public string Cpf {get; set;}
       public string Nome {get; set;}
       public string Email {get; set;}
       public string Senha {get; set;}

        //Construtor
        public Cliente(string Nome,string Cpf, string Email)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        // public static void TrocaSenha(string senhaU)
        // {
        //     string opcao = "S";
        //     while (opcao == "S")
        //     {
        //         Console.WriteLine("Você quer mudar a Senha: [s/n]?");
        //         string SenhaModificada = Console.ReadLine();

        //         if(SenhaModificada == "S" && SenhaModificada == "s")
        //         {
        //             Console.WriteLine("Altere a sua senha!");
        //             string SenhaNova = Console.ReadLine();
        //         }
        //         else{
        //             Console.WriteLine("Continue");
        //         }

        //         int TamanhoSenha;
        //         TamanhoSenha = senhaU.Length;
        //         if (TamanhoSenha > 6 && TamanhoSenha < 16)
        //         {
        //             Console.WriteLine("Quantidade de Caracteres CORRETA!!!");
        //         }
        //         else
        //         {
        //             Console.WriteLine("Caracteres acima do ideal!!!");
        //         }
        //     }
        //CORREÇÃO PROFESSOR
        public bool TrocaSenha(string senha)
        {
            if((senha.Length > 6) && (senha.Length < 16))
            {
                this.Senha = senha;
                return true;
            }
            else
            {
                return false;
            }
        }
        }

    }
