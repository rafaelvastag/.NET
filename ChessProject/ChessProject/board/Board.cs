using board.exceptions;
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

        public void AddPart(Part p, Position pos)
        {
            if (HasPartInPosition(pos))
            {
                throw new BoardException("Position already used!");
            }

            p.Position = pos;
            Parts[pos.Row, pos.Column] = p;
        }

        public Part RemovePart(Position pos)
        {
            if (Part(pos) == null)
            {
                return null;
            }

            Part removedPart = Part(pos);
            removedPart.Position = null;
            Parts[pos.Row, pos.Column] = null;

            return removedPart;
        }

        public Part Part(int row, int column)
        {
            return Parts[row, column];
        }

        public Part Part(Position pos)
        {
            return Parts[pos.Row, pos.Column];
        }

        public bool HasPartInPosition(Position pos)
        {
            ValidatePosition(pos);
            return Part(pos) != null;
        }

        public void ValidatePosition(Position pos)
        {
            if (!IsPositionValid(pos))
            {
                throw new BoardException("Invalid position!");
            }
        }

        public bool IsPositionValid(Position pos)
        {
            return !(pos.Row < 0 || pos.Row >= Rows || pos.Column < 0 || pos.Column >= Columns);
        }
    }
}
