using System;

namespace CoordenadasDePlano
{
    class Program
    {
        //Leia 2 valores com uma casa decimal (x e y), que devem 
        //representar as coordenadas de um ponto em um plano A seguir,
        //determine qual o quadrante ao qual pertence o ponto, ou se 
        //esta sobre um dos eixos cartesianos ou na origem (x=y=0).
        //Se o ponto estiver na origem, escreva a mensagem "Origem".
        //Se o ponto estiver sobre um dos eixos escreva "Eixo X" ou 
        //Eixo Y", conforme for a situação.
        static void Main(string[] args)
        {
            Console.WriteLine("[ QUADRANTE ]");
            Console.WriteLine();
            Console.Write("Informe os valores: ");
            string [] vetor = Console.ReadLine().Split(' ');
            double eixoX = double.Parse(vetor[0]);
            double eixoY = double.Parse(vetor[1]);

            if(eixoX > 0 && eixoY > 0)
            {
                Console.WriteLine("[ Q1 ]");
            }
            else if(eixoX < 0 && eixoY > 0)
            {
                Console.WriteLine(" [ Q2 ]");
            }
            else if(eixoX < 0 && eixoY < 0)
            {
                Console.WriteLine("[ Q3 ]");
            }
            else if(eixoX > 0 && eixoY < 0)
            {
                Console.WriteLine("[ Q4 ]");
            }
            else if(eixoX == 0 && eixoY == 0)
            {
                Console.WriteLine("Origem!!!");
            }
            else if(eixoX == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(eixoY == 0)
            {
                Console.WriteLine("Eixo Y");
            }


        }
    }
}
