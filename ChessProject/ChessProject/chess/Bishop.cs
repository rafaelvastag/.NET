using board;

namespace chess
{
    class Bishop : Part
    {
        public Bishop(Board board, Color color) : base(board, color) { }

        public override bool[,] AllowedMoves()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
