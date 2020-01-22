using System.Collections.Generic;
using Trabalhador.Enum;

namespace Trabalhador
{
    class Worker
    {
        public string Nome { get; set; }
        public double BaseSalarial { get; set; }
        public WorkerLevel Nivel { get; set; }
        public Departament Departament { get; set; }
        public List<ContratoHora> Contratos { get; set; } = new List<ContratoHora>();

        public Worker()
        {

        }

        public Worker(string nome, double basesalarial, WorkerLevel nivel, Departament departament)
        {
            Nome = nome;
            BaseSalarial = basesalarial;
            Nivel = nivel;
            Departament = departament;
        }

        public void AdicionarContrato(ContratoHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHora contrato)
        {   
            Contratos.Remove(contrato);
        }

        public double Ganho(int ano, int mes)
        {
            double soma = BaseSalarial;
            foreach(ContratoHora contrato in Contratos)
            {
                if(contrato.Date.Year == ano && contrato.Date.Month == mes)
                {
                    soma = soma + contrato.ValorTotal();
                }
            }
            return soma;

        }
    }
}