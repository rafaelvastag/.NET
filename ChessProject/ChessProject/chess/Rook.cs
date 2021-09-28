using board;

namespace ChessProject.chess
{
    class Rook : Part
    {
        public Rook(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
