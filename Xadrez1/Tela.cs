using Tabuleiro;

namespace Xadrez1
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiros tab)
        {
            for(int i = 0; i< tab.linhas;i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        System.Console.WriteLine("- ");
                    }
                    else
                    {
                        System.Console.WriteLine(tab.peca(i,j) + " ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}