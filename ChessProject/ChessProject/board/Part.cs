using board;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessProject.board
{
    class Part
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovimentsDone { get; protected set; }
        public Board Board { get; protected set; }

        public Part(Position position, Color color, Board board)
        {
            Position = position;
            Color = color;
            Board = board;
            MovimentsDone = 0;
        }
    }
}
