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

            Console.WriteLine("Original: "+frase);
            Console.WriteLine("Maiusculo: "+maiusculo);
            Console.WriteLine("Minusculo: -"+minusculo+ "-");
            Console.WriteLine("Espaçamento: -"+espaçamento+"-");
            Console.WriteLine("Na posição: "+ procura);
            Console.WriteLine("Na posição: "+procura1);
            Console.WriteLine("Substring: (3)"+cortar);
            Console.WriteLine("Substring: (3, 5)"+cortar1);
        }
    }
}
