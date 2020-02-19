using System;

namespace ClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
           Pessoa pessoa = new Pessoa();
           pessoa.Nome = "Roberto";
           pessoa.Idade = 21;

           //Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos de idade!");

           pessoa.AprensetarConsole();
           pessoa.Zerar();
           pessoa.AprensetarConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 22;

            var apresentacaoDaPessoa = fulano.Apresentar();
            Console.WriteLine(apresentacaoDaPessoa.Length);
            Console.WriteLine(apresentacaoDaPessoa);
        }
    }
}
