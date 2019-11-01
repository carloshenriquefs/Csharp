using System;

namespace Zoologico
{
    class Leao
    {
        public string Nome { get; set; }
        
        public Leao()
        {

        }

        public Leao(string nome)
        {
            this.Nome = nome;
        }

        public bool LeaoMiau()
        {
            Console.WriteLine("  LEÃO");
            Console.WriteLine("DESCRIÇÃO: ");
            return true;
        }





        
    }
}
