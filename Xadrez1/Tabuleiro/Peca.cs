namespace Tabuleiro
{
    public class Peca
    {
        public Posicao posicao {get; set;}
        public Cor cor {get; protected set;}
        public int qtdMovimento {get; protected set;}
        public Tabuleiros tab {get; protected set;}

        public Peca(Posicao posicao, Tabuleiros tab, Cor cor){
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimento = 0;
        }
    }
}