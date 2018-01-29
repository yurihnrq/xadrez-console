﻿using System;
using tabuleiro;

namespace xadrezConsole {
    class Tela {

        public static void imprimirTabuleiro(Tabuleiro tabuleiro) {

            for (int i = 0; i < tabuleiro.linha; i++) {
                for (int j = 0; j < tabuleiro.coluna; j++) {

                    if (tabuleiro.peca(i, j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(tabuleiro.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
