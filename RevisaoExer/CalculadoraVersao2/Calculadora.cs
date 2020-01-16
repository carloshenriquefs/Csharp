namespace CalculadoraVersao2
{
    public class Calculadora
    {
        public double PI = 3.14;

        public double Circunferencia(double r)
        {
            return 2 * PI * r;
        }

        public double Volume(double r)
        {
            return 4 / 3 * PI * r * r * r;
        }
    }
}