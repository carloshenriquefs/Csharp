using System;

namespace Trabalhador
{
    public class ContratoHora
    {
        public DateTime Date { get; set; }
        public double ValorPorHoras { get; set; }
        public int Horas { get; set; }

        public ContratoHora()
        {

        }

        public ContratoHora(DateTime date, double valorporhoras, int horas)
        {
            Date = date;
            ValorPorHoras = valorporhoras;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return ValorPorHoras * Horas;
        }
    }
}