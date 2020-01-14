using System;

namespace SenhaValida
{
    class Program
    {
        //Escreva um programa que repita a leitura de uma senha até que
        //ela seja válida. Para cada leitura de senha incorreta informada,escrever
        //a mensagem "Senha Invalida". Quando a senha for informada corretamente deve
        //ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere
        // que a senha correta é o valor 2002.
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("       SENHA !");
            Console.WriteLine("===================");

            Console.Write("Insira a sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha Incorreta!");
                Console.Write("Digite novamente a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha Correta!");
        }
    }
}
