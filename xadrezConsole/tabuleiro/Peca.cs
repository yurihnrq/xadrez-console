using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tabuleiro {
    abstract class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            quantidadeMovimentos = 0;
        }

        public void incrementarQteMovimentos() {
            quantidadeMovimentos++;
        }

        public void decrementarQteMovimentos() {
            quantidadeMovimentos--;
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tabuleiro.linha; i++) {
                for(int j = 0; j < tabuleiro.coluna; j++) {
                    if(mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
