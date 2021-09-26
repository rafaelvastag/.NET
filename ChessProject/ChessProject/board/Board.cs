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
        private Part[,] parts;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            parts = new Part[rows, columns];
        }
    }
}
