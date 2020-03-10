namespace Polimorfismo
{
    public class Funcionarios
    {
        public string NomeF { get; set; }

        public int Horas { get; set; }

        public double ValorPorHoras { get; set; }

        public Funcionarios()
        {

        }

        public Funcionarios(string nomeF, int horas, double valorPorHoras)
        {
            NomeF = nomeF;
            Horas = horas;
            ValorPorHoras = valorPorHoras;
        }
        
        public virtual double Pagamento()
        {
            return Horas * ValorPorHoras;
        }
    }
}