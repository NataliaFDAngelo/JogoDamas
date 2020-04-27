using System;
using JogoDamas.damas;
using JogoDamas.tabuleiro;

namespace JogoDamas
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(10, 10);

            tab.colocarPeca(new DamaSimples(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new DamaSimples(tab, Cor.Preta), new Posicao(0, 2));
            tab.colocarPeca(new DamaPromovida(tab, Cor.Preta), new Posicao(0, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
