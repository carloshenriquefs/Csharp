using System;

namespace FestadeAniversario
{
    class Agenda
    {
      public string Nome { get; set; }
      public string DataNascimento { get; set; }

      public Agenda()
      {

      }

      public Agenda(string nome, string datanascimento)
      {
        this.Nome = nome;
        this.DataNascimento = datanascimento;
      }

      public string CadastrarNome()
      {
        return "";
      }

      public string CadastrarAniversario()
      {
        return "";
      }

    }
}