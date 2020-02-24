namespace ParametrosVariaveis
{
    public class Parametros
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                System.Console.WriteLine("Olá {0}", pessoa);
            }
        }
    }
}