using board;
using ChessProject.board.exceptions;
using ChessProject.chess;
using System;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Board board = new Board(8, 8);
                board.addPart(new Rook(board, Color.Black), new Position(0, 0));
                board.addPart(new Rook(board, Color.Black), new Position(1, 9));
                board.addPart(new King(board, Color.White), new Position(1, 0));

                ScreenHandler.PrintBoard(board);

            } catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
