using System;

namespace Zoologico
{
    class Arara
    {
        public string Nome { get; set; }        

        public Arara()
        {

        }

        public Arara(string nome)
        {
            this.Nome = nome;
        }

        public bool AraraAve()
        {
            Console.WriteLine("    ARARA");
            Console.WriteLine("DESCRIÇÃO: Gaiola, muitas árvores altas ");
            return true;
        }




        
    }
}
