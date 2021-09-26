using System;
using System.Collections.Generic;
using System.Text;

namespace ChessProject.board.exceptions
{
    class BoardException : Exception
    {
        public BoardException(string msg) : base(msg) { }
    }
}
