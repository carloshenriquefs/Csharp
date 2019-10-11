using System;

namespace Byte_Bank
{
    class Cliente
    {
        private string _Nome;
        private string _Email;
        private string _Cpf;
        private string _Senha;
        
        public string nome
        {
            get{return _Nome;}
            set{_Nome = value;}
        }

        public string email
        {
            get{return _Email;}
            set{_Email = value;}
        }

        public string cpf
        {
            get{return _Cpf;}
            set{_Cpf = value;}
        }

        public string senha
        {
            get{return _Senha;}
        }

        //CONSTRUTOR
        public Cliente(string nome, string cpf, string email)
        {
            this._Nome = nome;
            this._Email = email;
            this._Cpf = cpf;
        }

        public bool TrocaSenha(string senha)
        {
            if(senha.Length > 6 && senha.Length < 16)
            {
                this._Senha = senha;
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