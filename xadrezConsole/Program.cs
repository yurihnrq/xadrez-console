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


                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
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
