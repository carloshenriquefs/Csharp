using System;
using ReciclagemLixo.interfaces;

namespace ReciclagemLixo
{
    class PoteManteigaPlastico : IVermelhoPlastico
    {
        public bool VermelhoPlastico()
        {
            Console.WriteLine("PLÁSTICO - LIXO VERMELHO");
            return true;
            
        }

        bool IVermelhoPlastico.VermLixo()
        {
            throw new NotImplementedException();
        }
    }
}
