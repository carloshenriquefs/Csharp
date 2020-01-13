using System;

namespace AeB_Multiplos
{
    class Program
    {
        //Leia 2 valores inteiros (A e B). Após, o programa deve mostrar
        //uma mensagem "São Multiplos" ou "Não são Multiplos", indicando
        //se os valores lidos são multiplos entre si. Atenção: os números
        //devem poder ser digitados em ordem crecente ou decrescente.
        static void Main(string[] args)
        {
            Console.Write("Informe valores: ");
            string [] valores = Console.ReadLine().Split(' ');
            double num1 = double.Parse(valores[0]);
            double num2 = double.Parse(valores[1]);

            if(num1 % num2 == 0 || num2 % num1 == 0)
            {
            Console.WriteLine("Os valores {0} e {1} - São multiplos!!!",num1,num2);
            }
            else
            {
                Console.WriteLine("Os valores {0} e {1} - Não são multiplos!!!",num1,num2);
            }
        }
    }
}
