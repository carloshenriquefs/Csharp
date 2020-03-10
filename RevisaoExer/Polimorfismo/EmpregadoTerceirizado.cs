namespace Polimorfismo
{
    public class EmpregadoTerceirizado : Funcionarios
    {
        public double CobrancaAdicional  { get; set; }

        public EmpregadoTerceirizado()
        {

        }

        public EmpregadoTerceirizado(string nomeF, int horas, double valorPorHoras, double cobrancaAdicional)
        :base(nomeF,horas,valorPorHoras)
        {
            CobrancaAdicional = cobrancaAdicional;
        }


        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * CobrancaAdicional;
        }
    }
}