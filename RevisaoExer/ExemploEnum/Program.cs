using System;

namespace ExemploEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmePara = new Filme();
            filmePara.Titulo = "Sharknardo 17";
            filmePara.GeneroFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}", filmePara.Titulo,filmePara.GeneroFilme);
        }
    }
}
