using System;

namespace Polimorfismo1.Entities
{
    public class Employee
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHoras { get; set; }

        public Employee()
        {

        }

        public Employee(string nome, int horas, double valorporhoras)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHoras = valorporhoras;
        }
        public virtual double Pagamento()
        {
            return ValorPorHoras * Horas;
        }

    }
}