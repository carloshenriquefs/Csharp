using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CarroAlugado1.Entities
{
    public class CarroAluguel
    {
        public DateTime Comeco { get; set; }
        public DateTime Final { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public CarroAluguel(DateTime comeco, DateTime final, Veiculo veiculo)
        {
            Comeco = comeco;
            Final = final;
            Veiculo = veiculo;
        }
    }
}