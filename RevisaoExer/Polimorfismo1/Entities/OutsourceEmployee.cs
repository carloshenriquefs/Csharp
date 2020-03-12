namespace Polimorfismo1.Entities
{
    public class OutsourceEmployee : Employee
    {
        public double CobrancaAdicional { get; set; }

        public OutsourceEmployee()
        {

        }

        public OutsourceEmployee(string nome, int horas, double valorporhoras, double cobrancaadicional)
        :base(nome,horas,valorporhoras)
        {
            CobrancaAdicional = cobrancaadicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * CobrancaAdicional;
        }
    }
}