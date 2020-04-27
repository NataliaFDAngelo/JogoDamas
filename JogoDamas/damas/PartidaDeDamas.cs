using JogoDamas.tabuleiro;
using JogoDamas;

namespace JogoDamas.damas
{
    class PartidaDeDamas
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeDamas()
        {
            tab = new Tabuleiro(10, 10);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retiraPeca(origem);
            Peca pecaCapturada = tab.retiraPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new DamaSimples(tab, Cor.Preta), new PosicaoDama('a', 10).toPosicao());
            tab.colocarPeca(new DamaSimples(tab, Cor.Branca), new PosicaoDama('c', 1).toPosicao());
            tab.colocarPeca(new DamaSimples(tab, Cor.Branca), new PosicaoDama('e', 1).toPosicao());
            tab.colocarPeca(new DamaSimples(tab, Cor.Branca), new PosicaoDama('d', 2).toPosicao());

        }

    }

}
