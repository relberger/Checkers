using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Board
    {
        Cell [,] board = new Cell [8,8];

        public Board()
        {
            initBoard(board);
        }

        public void initBoard(Cell [,] board)
        {
            for(int row = 0; row < board.Length; ++row)
            {
                for(int col = 0; col < board.Length; ++col)
                {
                    theRealInit(board, row, col); 
                }
            }
        }

        public void theRealInit(Cell[,] board, int row, int col)
        {
            if (
                ((row == 0 || row == 2) && col % 2 != 0)
                || ((row == 1) && col % 2 == 0)
                )
            {
                board[row, col].IsEmpty = false;
                board[row, col].Piece = new Piece(Piece.Colors.RED, Piece.PieceTypes.PAWN);
            }
            else if
                (
                    ((row == 5 || row == 7) && col % 2 == 0)
                    || ((row == 6) && col % 2 != 0)
                )
            {
                board[row, col].IsEmpty = false;
                board[row, col].Piece = new Piece(Piece.Colors.BLACK, Piece.PieceTypes.PAWN);
            }
            else
            {
                board[row, col].IsEmpty = true;
                board[row, col].Piece = null;
            }
        }
    }
}
