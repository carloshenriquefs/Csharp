using System;

namespace Enum {
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia }

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class Program {
        static void Main (string[] args) {}

            public static void Executar () {
                int id = (int) Genero.Animacao;
                Console.WriteLine (id);

                var filmeParaFamilia = new Filme ();
                filmeParaFamilia.Titulo = "Sharknardo 17";
                filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

                Console.WriteLine ("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
            }
        
    }
}