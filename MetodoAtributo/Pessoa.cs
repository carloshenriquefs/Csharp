using System;

namespace MetodoAtributo
{
    public class Pessoa
    {
       public string Nome { get; set; } 
       public int Idade { get; set; }

       public string Apresentar()
       {
           return string.Format($"Me chamo {Nome} e tenho {Idade}anos");
       }

       public void ApresentarNoConsole()
       {
           Console.WriteLine(Apresentar());
       }
    }
}