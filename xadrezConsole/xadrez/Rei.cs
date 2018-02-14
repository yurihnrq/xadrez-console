﻿using System;
using tabuleiro;

namespace xadrez {
    class Rei : Peca{

        private PartidaDeXadrez partida;

        public Rei(Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor) {
            this.partida = partida;
        }

        private bool podeMover(Posicao pos) {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.cor != cor;
        }

        private bool testeTorreParaRoque(Posicao pos) {
            Peca p = tabuleiro.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.quantidadeMovimentos == 0;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linha, tabuleiro.coluna];
            Posicao pos = new Posicao(0, 0);

            // acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tabuleiro.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }
            // NE
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // SE
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // SO
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // NO
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // #jogadaespecial roque pequeno
            if(quantidadeMovimentos == 0 && !partida.xeque) {
                Posicao posT1 = new Posicao(posicao.linha, posicao.coluna + 3);
                if (testeTorreParaRoque(posT1)) {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna + 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna + 2);
                    if(tabuleiro.peca(p1) == null && tabuleiro.peca(p2) == null) {
                        mat[posicao.linha, posicao.coluna + 2] = true; 
                    }
                }
            }

            // #jogadaespecial roque grande
            if (quantidadeMovimentos == 0 && !partida.xeque) {
                Posicao posT2 = new Posicao(posicao.linha, posicao.coluna - 4);
                if (testeTorreParaRoque(posT2)) {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna - 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna - 2);
                    Posicao p3 = new Posicao(posicao.linha, posicao.coluna - 3);
                    if (tabuleiro.peca(p1) == null && tabuleiro.peca(p2) == null && tabuleiro.peca(p3) == null) {
                        mat[posicao.linha, posicao.coluna - 2] = true;
                    }
                }
            }

            return mat;
        }

        public override string ToString() {
            return "R";
        }

    }
}
