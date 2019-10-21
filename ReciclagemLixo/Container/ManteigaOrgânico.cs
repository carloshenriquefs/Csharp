using System;
using ReciclagemLixo.interfaces;

namespace ReciclagemLixo 
{
    class ManteigaOrgânico : IMarronOrganico
    {
        public bool MarromOrganico()
        {
           Console.WriteLine("ORGÂNICO - LIXO CINZA");
           return true;
        }

        bool IMarronOrganico.MarromOrganico()
        {
            throw new NotImplementedException();
        }
    }
}
