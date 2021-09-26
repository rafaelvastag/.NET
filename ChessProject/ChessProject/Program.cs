using board;
using System;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8,8);

            Console.WriteLine(board.Columns);

            ScreenHandler.PrintBoard(board);
        }
    }
}
