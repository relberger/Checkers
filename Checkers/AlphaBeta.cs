using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class AlphaBeta
    {
        public double AlphaBetaSearch(Board board, int depth, double alpha, double beta, bool player)
        {
            double value = 0.0;

            if (depth == 0 || board.atEdge())
            {
                value = board.heuristic();
            }

            else if (player == true)//max
            {
                bool opponent = false;

                for (int row = 0; row < board.GameBoard.Length; ++row)
                {
                    for (int col = 0; col < board.GameBoard.Length; ++col)
                    {
                        if (board.validJump(row, col))
                        {

                        }
                    }
                }

            return value;
        }
    }
}
