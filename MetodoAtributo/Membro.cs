using System;

namespace MetodoAtributo
{
    public class Membro
    {
        public static void Executar()
        {
            Pessoa pessoinha = new Pessoa();
            pessoinha.Nome = "João";
            pessoinha.Idade = 21;

            Console.WriteLine($"{pessoinha.Nome} tem {pessoinha.Idade}anos");

            pessoinha.ApresentarNoConsole();
        }
    }
}