using System;

namespace NumeroPalavras
{
    class Program
    {
        //Se os números de 1 a 5 fossem escritos em palavras: um, dois, três, quatro, 
        //cinco, então teríamos utilizado 2 + 4 + 4 + 6 + 5 = 21 letras no total.
        //Se todos os números de 1 até 1000 fossem escritos em palavras, quantas letras 
        //nós teríamos utilizado?
        static void Main(string[] args)
        {
            // for(int i = 1; i >= 1000; i++)
            // {
            //     Console.WriteLine(QuantidadeLetras());
            // }
            string ExtensoNumero = NumeroPalavras.PorExtenso.InFull()

            string palavra = Console.ReadLine();
            Console.WriteLine(QuantidadeLetras(palavra));
        }
            public static int QuantidadeLetras(string palavras)
            {
                int contador = 0;
                for(int i = 0; i < palavras.Length; i++)
                {
                    if(Char.IsLetter(palavras[i]))
                    {
                        contador++;
                    }
                }
                return contador;
            }
    }
}
