using System;

namespace MatrizNumeroNegativo {
    class Program {
        //Fazer um programa para ler um número inteiro N e uma Matriz
        //de ordem N contendo números inteiros. Em seguida, mostrar a 
        //diagonal principal e a quantidade de valores negativos da matriz

        static void Main (string[] args) {
            Console.WriteLine ();
            Console.WriteLine ("      [ DIAGONAL ]");
            Console.WriteLine ();

            Console.Write ("Quantas Linhas e Colunas: ");
            int linhasColunas = int.Parse (Console.ReadLine ());

            int [,] math = new int[linhasColunas, linhasColunas];

            for (int i = 0; i < linhasColunas; i++) 
            {
                string[] vetor = Console.ReadLine ().Split (' ');
                for (int j = 0; j < linhasColunas; j++) 
                {
                    math[i,j] = int.Parse(vetor[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Matriz Diagonal: ");
            for(int i = 0; i < linhasColunas; i++)
            {
                Console.Write(math[i,i] + "");
            }

            int contador = 0;
            for(int i = 0; i < linhasColunas; i++)
            {
                for(int j = 0; j < linhasColunas; j++)
                {
                    if(math[i,j] < 0)
                    {
                        contador++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Números negativos: "+contador);

        }
    }
}