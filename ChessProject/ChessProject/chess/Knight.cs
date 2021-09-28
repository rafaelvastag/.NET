using board;

namespace chess
{
    class Knight : Part
    {
        public Knight(Board board, Color color) : base(board, color) { }

        public override bool[,] AllowedMoves()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
