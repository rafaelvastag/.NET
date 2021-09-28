using board;

namespace ChessProject.chess
{
    class Bishop : Part
    {
        public Bishop(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "B";
        }
    }
}
