using System;
using System.Globalization;

namespace PessoasAltura {
    class Program {
        //Fazer um programa para ler um número inteiro N e a altura
        //de N pessoas. Armazene as N alturas em um vetor. Em seguida,
        //mostrar a altura média dessas pessoas.
        static void Main (string[] args) {
            Console.WriteLine ("[ALTURA PESSOA]");
            Console.WriteLine ();

            Console.WriteLine ("Quantas pessoas? ");
            int qtdPessoas = int.Parse (Console.ReadLine ());
            double[] pessoa = new double[qtdPessoas];

            for (int i = 0; i < qtdPessoas; i++) {
                pessoa[i] = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
            }

            double soma = 0;
            for (int i = 0; i < qtdPessoas; i++) 
            {
                soma = soma + pessoa[i];
            }

            double media = soma / qtdPessoas;

            Console.WriteLine("Media = "+media.ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}