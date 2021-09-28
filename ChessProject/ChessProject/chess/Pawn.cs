using board;

namespace chess
{
    class Pawn : Part
    {
        public Pawn(Board board, Color color) : base(board, color) { }

        public override bool[,] AllowedMoves()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
