using board;

namespace chess
{
    class Queen : Part
    {
        public Queen(Board board, Color color) : base(board, color) { }

        public override bool[,] AllowedMoves()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
