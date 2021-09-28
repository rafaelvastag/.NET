using board;

namespace chess
{
    class Rook : Part
    {
        public Rook(Board board, Color color) : base(board, color) { }

        public override bool[,] AllowedMoves()
        {
            bool[,] mat = new bool[Board.Rows, Board.Columns];
            Position pos = new Position(0, 0);

            //UP
            pos.Define(Position.Row - 1, Position.Column);
            while (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.Part(pos) != null && Board.Part(pos).Color != Color)
                {
                    break;
                }
                pos.Row = pos.Row - 1;
            }

            // RIGHT
            pos.Define(Position.Row, Position.Column + 1);
            while (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.Part(pos) != null && Board.Part(pos).Color != Color)
                {
                    break;
                }
                pos.Column = pos.Column + 1;
            }

            //DOWN
            pos.Define(Position.Row + 1, Position.Column);
            while (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.Part(pos) != null && Board.Part(pos).Color != Color)
                {
                    break;
                }
                pos.Row = pos.Row + 1;
            }

            //LEFT
            pos.Define(Position.Row, Position.Column - 1);
            while (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.Part(pos) != null && Board.Part(pos).Color != Color)
                {
                    break;
                }
                pos.Column = pos.Column - 1;
            }

        }

        private bool CanMove(Position pos)
        {
            Part p = Board.Part(pos);
            return null == p || p.Color != Color;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
