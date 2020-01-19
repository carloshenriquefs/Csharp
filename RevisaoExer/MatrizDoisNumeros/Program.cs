using System;

namespace MatrizDoisNumeros
{
    class Program
    {
        //Fazer um programa para ler dois números inteiros M e N, e depois
        //ler uma matriz de M linhas por N colunas contendo números inteiros
        //podendo haver repetições. Em seguida, ler um número inteiro X que 
        //pertence à matriz. Para cada ocorrencia de X, mostrar os valores à
        //esquerda, acima, à direita e abaixo de X, quando houver.
        static void Main(string[] args)
        {
            

            string [] vetor = Console.ReadLine().Split(' ');
            int num1 = int.Parse(vetor[0]);
            int num2 = int.Parse(vetor[1]);

            int[,] numeros = new int[num1, num2];

            for(int i = 0; i < num1; i++)
            {
                string [] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < num2; j++)
                {
                    numeros[i,j] = int.Parse(values[j]);
                }
            }

            int numProcurado = int.Parse(Console.ReadLine());

            for(int i = 0; i < num1; i++)
            {
                for(int j = 0; j< num2; j++)
                {
                    if(numeros[i,j] == numProcurado)
                    {
                        Console.WriteLine("Posição: "+i+","+j);
                    }
                }
            }
        }
    }
}
