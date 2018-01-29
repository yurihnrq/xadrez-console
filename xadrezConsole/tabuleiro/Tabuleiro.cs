using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tabuleiro {
    class Tabuleiro {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int coluna) {
            this.linhas = linha;
            this.colunas = coluna;
            pecas = new Peca[linha, coluna];
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca P, Posicao pos) {
            pecas[pos.linha, pos.coluna] = P;
            P.posicao = pos;
        }

    }
}
