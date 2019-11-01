using System;

namespace Zoologico
{
    class Tucano
    {
        public string Nome { get; set; }

        public Tucano()
        {

        }

        public Tucano(string nome)
        {
            this.Nome = nome;
        }

        public bool TucanoAve()
        {
            Console.WriteLine("      GAIOLA");
            Console.WriteLine("DESCRIÇÃO: Muitas árvores altas.");
            return true;
        }
        





        
    }
}
