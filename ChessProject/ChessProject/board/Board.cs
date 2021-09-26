using ChessProject.board;
using ChessProject.board.exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace board
{
    class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Part[,] Parts;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Parts = new Part[rows, columns];
        }

        public void addPart(Part p, Position pos)
        {
            if (hasPartInPosition(pos))
            {
                throw new BoardException("Position already used!");
            }

            p.Position = pos;
            Parts[pos.Row, pos.Column] = p;
        }

        public Part Part(int row, int column)
        {
            return Parts[row, column];
        }

        public Part Part(Position pos)
        {
            return Parts[pos.Row, pos.Column];
        }

        public bool hasPartInPosition(Position pos)
        {
            validatePosition(pos);
            return Part(pos) != null;
        }

        public void validatePosition(Position pos)
        {
            if (!isPositionValid(pos))
            {
                throw new BoardException("Invalid position!");
            }
        }

        public bool isPositionValid(Position pos)
        {
            return !(pos.Row < 0 || pos.Row >= Rows || pos.Column < 0 || pos.Column >= Columns);
        }
    }
}
