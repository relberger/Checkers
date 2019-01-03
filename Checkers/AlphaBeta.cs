using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class AlphaBeta
    {
        public static double AlphaBetaSearch(Board board, int depth, double alpha, double beta, bool player)
        {
            double value = 0.0;
            bool opponent;

            if (depth == 0 || board.atEdge())
            {
                value = board.heuristic();
            }

            else if (player == true) //max
            {
                opponent = false;

                for (int row = 0; row < board.GameBoard.Length; ++row)
                {
                    for (int col = 0; col < board.GameBoard.Length; ++col)
                    {
                        if (board.validJump(row, col))
                        {
                            Board nextMove = board.jump(row, col, player);
                            double valueBasedOnNextMove = AlphaBetaSearch(nextMove, depth - 1, alpha, beta, opponent);

                            if (valueBasedOnNextMove > alpha)
                            {
                                alpha = valueBasedOnNextMove;
                            }
                            if (beta <= alpha)
                            {
                                break;
                            }
                        }
                    }
                    value = alpha;
                }
            }

            else if (player == false) //min
            {
                opponent = true;
                for (int row = 0; row < board.GameBoard.Length; ++row)
                {
                    for (int col = 0; col < board.GameBoard.Length; ++col)
                    {
                        if (board.validJump(row, col))
                        {
                            Board nextMove = board.jump(row, col, player);
                            double valueBasedOnNextMove = AlphaBetaSearch(nextMove, depth - 1, alpha, beta, opponent);

                            if (valueBasedOnNextMove < beta)
                            {
                                beta = valueBasedOnNextMove;
                            }
                            if (beta <= alpha)
                            {
                                break;
                            }
                        }
                    }
                    value = beta;
                }
            }
            return value;
        }
    }
}
