using System;

namespace Byte_Bank
{
    class Cliente
    {
        public string Nome;
        public string Email;
        public string Cpf;
        public string Senha;
        

        //CONSTRUTOR
        public Cliente(string nome, string cpf, string email)
        {
            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
        }

        public bool TrocaSenha(string senha)
        {
            if(senha.Length > 6 && senha.Length < 16)
            {
                this.Senha = senha;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CPF(string cpf)
        {
            if(cpf.Length > 0 && cpf.Length < 11)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}