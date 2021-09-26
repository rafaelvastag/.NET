using board;
using ChessProject.board;

namespace ChessProject.chess
{
    class Pawn : Part
    {
        public Pawn(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "P";
        }
    }
}
