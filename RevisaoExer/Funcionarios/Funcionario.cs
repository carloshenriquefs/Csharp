namespace Funcionarios
{
    public class Funcionarios
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionarios()
        {

        }

        public Funcionarios(int id, string nome, double salario)
        {
            this.ID = id;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void SalarioAumento(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem/100);
        }

        public override string ToString()
        {
            return ID + ", "+ Nome + ", R$ " + Salario;
        }
    }
}