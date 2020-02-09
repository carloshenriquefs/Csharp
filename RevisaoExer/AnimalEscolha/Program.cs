using System;

namespace AnimalEscolha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine("      ANIMAL");
            Console.WriteLine("======================");
            Console.WriteLine();

            Console.WriteLine("     [INFORME]");
            Console.WriteLine();
            Console.Write("| Vertebrado - Invertebrado |");
            string Animal = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Tipo de Animal: ");
            string TipoAnimal = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Opção de alimentação: ");
            string AlimentacaoAnimal = Console.ReadLine();

            if(Animal == "vertebrado".ToUpper() && TipoAnimal == "ave".ToUpper() && AlimentacaoAnimal == "carnivoro".ToUpper())
            {
                Console.WriteLine("Aguia!");
            }
            else if(Animal == "vertebrado".ToUpper() && TipoAnimal == "ave".ToUpper() && AlimentacaoAnimal == "onivoro".ToUpper())
            {
                Console.WriteLine("Pomba!");
            }
            else if(Animal == "vertebrado".ToUpper() && TipoAnimal == "mamifero".ToUpper() && AlimentacaoAnimal == "onivoro".ToUpper())
            {
                Console.WriteLine("Homem!");
            }
            else if(Animal == "vertebrado".ToUpper() && TipoAnimal == "mamifero".ToUpper() && AlimentacaoAnimal == "herbivoro".ToUpper())
            {
                Console.WriteLine("Vaca!");
            }
            else if(Animal == "invertebrado".ToUpper() && TipoAnimal == "inseto".ToUpper() && AlimentacaoAnimal == "hematofago".ToUpper())
            {
                Console.WriteLine("Pulga!");
            }
            else if(Animal == "invertebrado".ToUpper() && TipoAnimal == "inseto".ToUpper() && AlimentacaoAnimal == "herbivoro".ToUpper())
            {
                Console.WriteLine("Largata!");
            }
            else if(Animal == "invertebrado".ToUpper() && TipoAnimal == "anelideo".ToUpper() && AlimentacaoAnimal == "hematofago".ToUpper())
            {
                Console.WriteLine("Sanguessuga!");
            }
            else if(Animal == "invertebrado".ToUpper() && TipoAnimal == "anelideo".ToUpper() && AlimentacaoAnimal == "onivoro".ToUpper())
            {
                Console.WriteLine("Minhoca!");
            }

        }
    }
}
