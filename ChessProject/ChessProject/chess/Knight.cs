using board;

namespace ChessProject.chess
{
    class Knight : Part
    {
        public Knight(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "N";
        }
    }
}
