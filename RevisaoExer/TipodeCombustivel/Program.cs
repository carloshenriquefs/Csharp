using System;

namespace TipodeCombustivel
{
    class Program
    {
        //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência 
        //de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido 
        //(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário 
        //informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código 
        //(até que seja válido). O programa será encerrado quando o código informado for o número 4.

        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int combustivel = 0;
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("     | TIPO DE COMBUSTIVEL |");
            Console.WriteLine("=================================");
            Console.WriteLine("      |   [1] - ALCOOL    | ");
            Console.WriteLine("      |   [2] - GASOLINA  |");
            Console.WriteLine("      |   [3] - DIESEL    |");
            Console.WriteLine("      |   [4] - FIM       |");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("| INFORME |");
            Console.WriteLine();
            do{
                Console.Write("COMBUSTIVEL: ");
                combustivel = int.Parse(Console.ReadLine());
                if(combustivel == 1)
                {
                    gasolina++;
                }
                else if(combustivel == 2)
                {
                    alcool++;
                }
                else if(combustivel == 3)
                {
                    diesel++;
                }
                else if(combustivel == 8)
                {
                    Console.WriteLine("MUITO OBRIGADO!");
                }
                else if(combustivel > 8)
                {
                    Console.WriteLine("Tente novamente!!!");
                    Console.Write("COMBUSTIVEL: ");
                    combustivel = int.Parse(Console.ReadLine());
                }
            }while(combustivel != 4);
                    Console.WriteLine("========================");
                    Console.WriteLine("       REGISTROS");   
                    Console.WriteLine("========================");
                    Console.WriteLine("Gasolina "+gasolina);
                    Console.WriteLine("Alcool "+alcool);
                    Console.WriteLine("Diesel "+diesel);
                    Console.WriteLine("========================");
        }
    }
}
