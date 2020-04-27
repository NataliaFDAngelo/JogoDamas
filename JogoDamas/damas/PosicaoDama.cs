using JogoDamas.tabuleiro;

namespace JogoDamas.damas
{
    class PosicaoDama
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoDama(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(10 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
