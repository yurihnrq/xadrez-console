﻿using tabuleiro;

namespace xadrez {

    class Peao : Peca {

        public Peao(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {
        }

        public override string ToString() {
            return "P";
        }

        private bool exsteInimigo(Posicao pos) {
            Peca p = tabuleiro.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos) {
            return tabuleiro.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linha, tabuleiro.coluna];

            Posicao pos = new Posicao(0, 0);

            if(cor == Cor.Branca) {
                pos.definirValores(posicao.linha - 1, posicao.coluna);
                if (tabuleiro.posicaoValida(pos) && livre(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha - 2, posicao.coluna);
                if (tabuleiro.posicaoValida(pos) && livre(pos) && quantidadeMovimentos == 0) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
                if (tabuleiro.posicaoValida(pos) && exsteInimigo(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
                if (tabuleiro.posicaoValida(pos) && exsteInimigo(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
            }
            else {
                pos.definirValores(posicao.linha + 1, posicao.coluna);
                if (tabuleiro.posicaoValida(pos) && livre(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha + 2, posicao.coluna);
                if (tabuleiro.posicaoValida(pos) && livre(pos) && quantidadeMovimentos == 0) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
                if (tabuleiro.posicaoValida(pos) && exsteInimigo(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
                if (tabuleiro.posicaoValida(pos) && exsteInimigo(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
            }
            return mat;
        }

    }
}