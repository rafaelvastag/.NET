﻿using board;
using ChessProject.board;

namespace ChessProject.chess
{
    class Tower : Part
    {
        public Tower(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
