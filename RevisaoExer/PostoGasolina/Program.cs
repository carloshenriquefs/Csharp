using System;

namespace PostoGasolina
{
    class Program
    {
        //Um Posto de combustiveis deseja determinar qual de seus produtos
        //tem a preferência de seus cliente. Escreva um algoritmo para ler o
        //tipo de combustivel abastecido (codificado da seguinte forma: 1.Alcool
        // 2.Gasolina 3.Diesel 4.Fim).Caso o usuario informe um código invalido
        //(fora da faixa de 1 a 4) deve ser solicitado um novo codigo (até que
        // seja válido). O programa será encerrado quando o código informado for
        //o número 4. Deve ser escrito a mensagem: "Muito Obrigado" e a quantidade
        //de clientes que abasteceram cada tipo de combustivel.
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("   [POSTO DE GASOLINA]");
            Console.WriteLine();
            Console.WriteLine("[1] - ÁLCOOL");
            Console.WriteLine("[2] - GASOLINA");
            Console.WriteLine("[3] - DIESEL");
            Console.WriteLine("[4] - FIM");

            Console.Write("Escolha a opção: ");
            int opcao = int.Parse(Console.ReadLine());
            
            while(opcao != 4)
            {
                Console.Write("Escolha de novo: ");
                opcao = int.Parse(Console.ReadLine());
                if(opcao == 1)
                {
                    alcool = alcool + 1;
                }
                else if(opcao == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if(opcao == 3)
                {
                    diesel = diesel + 1;
                }
                else if (opcao > 4)
                {
                    Console.Write("Escolha uma nova opção: ");
                    opcao = int.Parse(Console.ReadLine());
                };
            }
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Alcool: {0}",alcool);
            Console.WriteLine("Gasolina: {0}",gasolina);
            Console.WriteLine("Diesel: {0}",diesel);

        }
    }
}
