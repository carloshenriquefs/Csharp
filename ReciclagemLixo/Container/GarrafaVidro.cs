using System;
using ReciclagemLixo.interfaces;

namespace ReciclagemLixo
{
    class GarrafaVidro : IVerdeVidro
    {
        public bool VerdVidro()
        {
            Console.WriteLine("VIDRO - LIXO VERDE");
            return true;
        }

        public void Adicionar()
        {
            Console.WriteLine("Adicionar Material? [S/N]:");
            string pergunta = Console.ReadLine();
            if(pergunta == "S")
            {
                Console.WriteLine("ADICIONE O MATERIAL:");
                string material = Console.ReadLine();
                Console.Write("Material Adicionado: "+ material);
            }
            else
            {
                Console.WriteLine("TENTE NOVAMENTE!");
            }
            
        }
    }
}
