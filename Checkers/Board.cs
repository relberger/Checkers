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
            foreach(Cell cell in board)
            {
                
            }
        }
    }
}
