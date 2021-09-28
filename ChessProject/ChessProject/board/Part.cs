using board;
using System;
using System.Collections.Generic;
using System.Text;

namespace board
{
    abstract class Part
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovimentsDone { get; protected set; }
        public Board Board { get; protected set; }

        public Part(Board board, Color color)
        {
            Position = null;
            Color = color;
            Board = board;
            MovimentsDone = 0;
        }

        public void IncreaseMovement()
        {
            MovimentsDone++;
        }

        public abstract bool[,] AllowedMoves();
    }
}
