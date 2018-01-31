using System;
using tabuleiro;
using xadrez;

namespace xadrezConsole {
    class Program {
        static void Main(string[] args) {
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 1));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 1));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 5));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(7, 7));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 2));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();

        }
    }
}
