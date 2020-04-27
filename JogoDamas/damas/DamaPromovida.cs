using JogoDamas.tabuleiro;

namespace JogoDamas.damas
{
    class DamaPromovida : Peca
    {
        public DamaPromovida(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "D";
        }
    }
}