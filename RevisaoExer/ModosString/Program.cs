using System;

namespace ModosString
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "abcd EFGHI JKLMN ABCD abc DEFG";

            string maiusculo = frase.ToUpper();
            string minusculo = frase.ToLower();
            string espaçamento = frase.Trim();
            int procura = frase.IndexOf("bc");
            int procura1 = frase.LastIndexOf("bc");

            string cortar = frase.Substring(3);
            string cortar1 = frase.Substring(3,5);

            string trocar = frase.Replace("a", "x");
            string trocar1 = frase.Replace("abc", "xyz");

            bool verificar = String.IsNullOrEmpty(frase);
            bool verificar1 = String.IsNullOrWhiteSpace(frase);

            Console.WriteLine("Original: "+frase);
            Console.WriteLine("Maiusculo: "+maiusculo);
            Console.WriteLine("Minusculo: -"+minusculo+ "-");
            Console.WriteLine("Espaçamento: -"+espaçamento+"-");
            Console.WriteLine("Na posição: "+ procura);
            Console.WriteLine("Na posição: "+procura1);
            Console.WriteLine("Substring: (3)"+cortar);
            Console.WriteLine("Substring: (3, 5)"+cortar1);
            Console.WriteLine("Replace ('a' - 'x')"+trocar);
            Console.WriteLine("Replace ('abc' - 'xyz'):"+trocar1);
            Console.WriteLine("Existe True or False: "+ verificar);
            Console.WriteLine("Existe True ou false: "+verificar1);
        }
    }
}
