using board;

namespace chess
{
    class King : Part
    {
        public King(Board board, Color color) : base(board, color) { }

        public override bool[,] AllowedMoves()
        {
            bool[,] mat = new bool[Board.Rows, Board.Columns];
            Position pos = new Position(0, 0);

            //UP
            pos.Define(Position.Row - 1, Position.Column);
            if(Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //RIGHT_UP
            pos.Define(Position.Row - 1, Position.Column + 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            // RIGHT
            pos.Define(Position.Row, Position.Column + 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //RIGHT_DOWN
            pos.Define(Position.Row + 1, Position.Column + 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //DOWN
            pos.Define(Position.Row + 1, Position.Column);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //LEFT_DOWN
            pos.Define(Position.Row + 1, Position.Column - 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //LEFT
            pos.Define(Position.Row, Position.Column - 1 );
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //LEFT_UP
            pos.Define(Position.Row - 1, Position.Column - 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            return mat;

        }

        private bool CanMove(Position pos)
        {
            Part p = Board.Part(pos);
            return null == p || p.Color != Color;
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
