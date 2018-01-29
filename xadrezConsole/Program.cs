using System;
using tabuleiro;

namespace xadrezConsole {
    class Program {
        static void Main(string[] args) {

            Tabuleiro T = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(T);

            Console.ReadLine();

        }
    }
}
