using System;
using CarroAlugado1.Entities;

namespace CarroAlugado1.Services
{
    public class AluguelServico
    {
        public double PrecoPorHora {get; private set;}

        public double PrecoPorDia { get; private set; }

        private TaxaServicoBrasil _ServicoBrasileiro = new TaxaServicoBrasil();

        public AluguelServico(double precoporhora, double precopordia)
        {
            PrecoPorHora = precoporhora;
            PrecoPorDia = precopordia;
        }
        public void ProcessoFatura(CarroAluguel carroaluguel)
        {
            TimeSpan duracao = carroaluguel.Final.Subtract(carroaluguel.Comeco);

            double pagamentoBasico = 0;
            if(duracao.TotalHours <= 12)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double tax = _ServicoBrasileiro.Taxa(pagamentoBasico);

            carroaluguel.Fatura = new Fatura(pagamentoBasico,tax);
        }
    }
}