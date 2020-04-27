using JogoDamas.tabuleiro;

namespace JogoDamas.damas
{
    class DamaSimples : Peca
    {
        public DamaSimples(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "O";
        }
    }
}
