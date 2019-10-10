using System;

namespace Senaizinho
{
    class Aluno
    {
        public string Nome;
        public DateTime DataNascimento;
        public string Curso;
        public int NumeroSala;

        public Aluno(string nome, DateTime dataNascimento, string curso, int numeroSala)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Curso = curso;
            this.NumeroSala = numeroSala;
        }
    }
}