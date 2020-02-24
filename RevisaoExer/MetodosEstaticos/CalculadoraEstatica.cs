namespace MetodosEstaticos
{
    public class CalculadoraEstatica
    {
        //Metodo de Classe ou Metodo statico
        public int Somar(int a, int b)
        {
            return a + b;
        }

        //Metodo de Instância
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        //Metodo de Instância
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //Metodo de Classe ou Metodo statico
        public int Divisao(int a, int b)
        {
            return a / b;
        }
    }
}