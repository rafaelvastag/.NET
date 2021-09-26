using board;
using ChessProject.chess;
using System;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8,8);
            board.addPart(new Rook(board, Color.Black), new Position(0, 0));
            board.addPart(new Rook(board, Color.Black), new Position(1, 3));
            board.addPart(new King(board, Color.White), new Position(2, 4));

            ScreenHandler.PrintBoard(board);
        }
    }
}
