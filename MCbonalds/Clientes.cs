using System;

namespace MCbonalds
{
    class Clientes
    {
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        DateTime DataNascimento {get;set;}
        
        //Construtor
        public Clientes(string nome, string telefone, string email)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }
    }
}