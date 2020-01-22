using Trabalhador.Enum;

namespace Trabalhador
{
    class Worker
    {
        public string Nome { get; set; }
        public double BaseSalarial { get; set; }
        public WorkerLevel Nivel { get; set; }
        public Departament Departament { get; set; }

        public void AdicionarContrato()
        {

        }
    }
}