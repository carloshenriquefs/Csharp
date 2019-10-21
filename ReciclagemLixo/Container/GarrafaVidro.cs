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
    }
}
