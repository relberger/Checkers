using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Piece
    {
        public Piece(Colors color, PieceTypes pieceType)
        {
            Color= color;
            PieceType = pieceType;
        }

        public Colors Color { get; set; }
        public PieceTypes PieceType { get; set; }

        public enum Colors
        {
            BLACK, RED
        }

        public enum PieceTypes
        {
            KING,
            PAWN
        }
    }
    
}
