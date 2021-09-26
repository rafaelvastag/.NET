using ChessProject.board;
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
            p.Position = pos;
            Parts[pos.Row, pos.Column] = p;
        }

        public Part Part(int row, int column)
        {
            return Parts[row, column];
        }
    }
}
