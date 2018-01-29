using System;
using tabuleiro;
using xadrez;

namespace xadrezConsole {
    class Program {
        static void Main(string[] args) {
            try {
                Tabuleiro T = new Tabuleiro(8, 8);

                T.colocarPeca(new Torre(T, Cor.Preta), new Posicao(0, 0));
                T.colocarPeca(new Rei(T, Cor.Preta), new Posicao(0, 9));
                T.colocarPeca(new Torre(T, Cor.Preta), new Posicao(1, 3));
                T.colocarPeca(new Rei(T, Cor.Preta), new Posicao(2, 4));

                Tela.imprimirTabuleiro(T);
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
