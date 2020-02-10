using System;

namespace DDD
{
    //Leia um número inteiro que representa um código de DDD para discagem interurbana. 
    //Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("             DDD ");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine(" DDD      |  DESTINATION ");
            Console.WriteLine();
            Console.WriteLine("[61]          BRASILIA");
            Console.WriteLine("[71]          SALVADOR");
            Console.WriteLine("[11]          SAO PAULO");
            Console.WriteLine("[21]          RIO DE JANEIRO");
            Console.WriteLine("[32]          JUIZ DE FORA");
            Console.WriteLine("[19]          CAMPINAS");
            Console.WriteLine("[27]          VITORIA");
            Console.WriteLine("[31]          BELO HORIZONTE");
            Console.WriteLine();
            Console.WriteLine("Escolha uma Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 61:
                Console.WriteLine("BRASILIA!");
                break;

                case 71:
                Console.WriteLine("SALVADOR!");
                break;

                case 11:
                Console.WriteLine("SÃO PAULO!");
                break;

                case 21:
                Console.WriteLine("RIO DE JANEIRO!");
                break;

                case 32:
                Console.WriteLine("JUIZ DE FORA!");
                break;

                case 19:
                Console.WriteLine("CAMPINAS!");
                break;

                case 27:
                Console.WriteLine("VITORIA!");
                break;

                case 31:
                Console.WriteLine("BELO HORIZONTE!");
                break;
            }
            
        }
    }
}
