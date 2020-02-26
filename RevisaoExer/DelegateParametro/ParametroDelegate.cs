namespace DelegateParametro
{
    public class ParametroDelegate
    {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }
        public static string Calculadora(Operacao operacao, int x, int y)
        {
            var resultado = operacao(x , y);
            return "Resultado: " + resultado;
        }
    }
}