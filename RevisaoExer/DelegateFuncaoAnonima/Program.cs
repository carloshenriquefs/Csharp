using System;

namespace DelegateFuncaoAnonima
{
    class Program
    {
        delegate string StringOperacao(string s);

        static void Main(string[] args)
        {
            StringOperacao inverter = delegate(string s){
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
            };

            Console.WriteLine("Escreva qualquer coisa: ");
            string frase = Console.ReadLine();
            Console.WriteLine(inverter(frase));

        }
    }
}
