using System;

namespace JogoDamas.tabuleiro
{
    class TabuleiroExcepition : Exception
    {
        public TabuleiroExcepition(string msg) : base(msg)
        {
        }
    }
}
