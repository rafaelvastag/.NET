﻿using board;
using ChessProject.board;

namespace ChessProject.chess
{
    class King : Part
    {
        public King(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "K";
        }
    }
}