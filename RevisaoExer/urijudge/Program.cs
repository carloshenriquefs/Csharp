using System;

namespace urijudge
{
    class Program
    {
        //Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C 
        //e se D for maior do que A, e a soma de C com D for maior que a soma de 
        //A e B e se C e D, ambos, forem positivos e se a variável A for par escrever 
        //a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º valor: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º valor: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 3º valor: ");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 4º valor: ");
            int D = int.Parse(Console.ReadLine());

            if(B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0){
                Console.WriteLine("Valores Aceitos");
            }
            else
            {
                Console.WriteLine("Valores não Aceitos");
            }
        }
    }
}
