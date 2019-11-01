using System;

namespace Zoologico
{
    class Chimpanze
    {
        public string Nome { get; set; }

        public Chimpanze(){

        }

        public Chimpanze(string nome)
        {
            this.Nome = nome;
        }

        public bool ChimpanzeMac()
        {
            Console.WriteLine();
            Console.WriteLine(" CHIMPANZE");
            Console.WriteLine("DESCRIÇÃO: Casa em árvore - florestas.");
            return true;
        }
        





        
    }
}
