namespace Tabuleiro
{
    public class Tabuleiros
    {
        public int linhas { get; set;}
        public int colunas {get; set;}

        private Peca[,] pecas;

        public Tabuleiros(int linha, int colunas){
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linha,colunas];
        }

        public Peca peca(int linha, int coluna){
            return pecas[linha,coluna];
        }
    }
}