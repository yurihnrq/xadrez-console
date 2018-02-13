using System;
using tabuleiro;
using xadrez;

namespace xadrezConsole {
    class Program {
        static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao desitno = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, desitno);
                }
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();

        }
    }
}
