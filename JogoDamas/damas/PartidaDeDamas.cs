using JogoDamas.tabuleiro;
using JogoDamas;
using System.Security.Cryptography;

namespace JogoDamas.damas
{
    class PartidaDeDamas
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
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

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validaPosicaoOrigem(Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroExcepition("Não existe peça na posição de origem escolhida!");
            }
            if (jogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroExcepition("A peça de origem escolhida não é sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroExcepition("Não há movimentos possíveis para a peça escolhida!");
            }
        }

        public void validaPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroExcepition("Posição de destino inválida!");
            }
        }

        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new DamaSimples(tab, Cor.Preta), new PosicaoDama('c', 9).toPosicao());
            tab.colocarPeca(new DamaSimples(tab, Cor.Preta), new PosicaoDama('e', 9).toPosicao());
            tab.colocarPeca(new DamaSimples(tab, Cor.Preta), new PosicaoDama('d', 10).toPosicao());

            tab.colocarPeca(new DamaSimples(tab, Cor.Branca), new PosicaoDama('c', 1).toPosicao());
            tab.colocarPeca(new DamaSimples(tab, Cor.Branca), new PosicaoDama('e', 1).toPosicao());
            tab.colocarPeca(new DamaSimples(tab, Cor.Branca), new PosicaoDama('d', 2).toPosicao());
            tab.colocarPeca(new DamaSimples(tab, Cor.Branca), new PosicaoDama('f', 2).toPosicao());

        }

    }

}
