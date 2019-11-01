using System;

namespace Zoologico
{
    class TubaraoM
    {
        public string Nome { get; set; }
        
        public TubaraoM()
        {

        }

        public TubaraoM(string nome)
        {
            this.Nome = nome;
        }

        public bool Tubarao()
        {
            // Console.WriteLine();
            Console.WriteLine("       AQUÁRIO");
            Console.WriteLine("DESCRIÇÃO: Água salgada e sem superfície terrestre. ");
            return true;
        }





        
    }
}
