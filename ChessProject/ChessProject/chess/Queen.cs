using board;

namespace ChessProject.chess
{
    class Queen : Part
    {
        public Queen(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "Q";
        }
    }
}
