using System;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("       ZOOLOGICO");
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("[ANIMAIS - EXISTENTES]");
            Console.WriteLine();
            Console.WriteLine("[1] - TUBARÃO MARTELO: ");
            Console.WriteLine("[2] - TUCANO: ");
            Console.WriteLine("[3] - ARARA: ");
            Console.WriteLine("[4] - LEÃO: ");
            Console.WriteLine("[5] - ORANGOTANGO: ");
            Console.WriteLine("[6] - CHIMPANZÉ: ");
            Console.WriteLine("[7] - PINGUIM: ");
            Console.WriteLine("[8] - TARTARUGA: ");
            Console.WriteLine("[9] - GOLFINHO: ");
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.Write("INFORME UMA OPÇÃO: ");
            int OpcaoAnimal = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================");    

            Console.WriteLine();

            if(OpcaoAnimal == 1)
            {
                Console.WriteLine("[1] - TUBARÃO MARTELO: ");
                TubaraoM TubaAnimal = new TubaraoM();
                TubaAnimal.Tubarao();
            }
            else if(OpcaoAnimal== 2)
            {
                Console.WriteLine("[2] - TUCANO: ");
                Tucano TucanoAnimal = new Tucano();
                TucanoAnimal.TucanoAve();
            }
            else if(OpcaoAnimal == 3)
            {
                Console.WriteLine("[3] - ARARA: ");
                Arara AraraAnimal = new Arara();
                AraraAnimal.AraraAve();
            }
            else if(OpcaoAnimal == 4)
            {
                Console.WriteLine("[4] - LEÃO: ");
                Leao LeaoAnimal = new Leao();
                LeaoAnimal.LeaoMiau();
            }
            else if(OpcaoAnimal == 5)
            {
                Console.WriteLine("[5] - ORANGOTANGO: ");
                Orangotango OrangotangoAnimal = new Orangotango();
                OrangotangoAnimal.OrangotangoTango();
            }
            else if(OpcaoAnimal == 6)
            {
                Console.WriteLine("[6] - CHIMPANZÉ: ");
            }
            else if(OpcaoAnimal == 7)
            {
                Console.WriteLine("[7] - PINGUIM: ");
            }
            else if(OpcaoAnimal == 8)
            {
                Console.WriteLine("[8] - TARTARUGA: ");
            }
            else if(OpcaoAnimal == 9)
            {
                Console.WriteLine("[9] - GOLFINHO: ");
            }





        }
    }
}
