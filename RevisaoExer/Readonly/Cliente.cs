using System;

namespace Readonly
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome,DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,Nascimento.Month,Nascimento.Year);
        }

    }
}