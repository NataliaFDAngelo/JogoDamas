using System;
using System.Security.Cryptography;
using JogoDamas.damas;
using JogoDamas.tabuleiro;

namespace JogoDamas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeDamas partida = new PartidaDeDamas();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoDama().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoDama().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
