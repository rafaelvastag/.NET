using board;
using board.exceptions;
using chess;
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
                ChessGame game = new ChessGame();

                while (!game.Finished)
                {
                    Console.Clear();
                    ScreenHandler.PrintBoard(game.Board);

                    Console.WriteLine();

                    Console.Write("Origin: ");
                    Position origin = ScreenHandler.ChessPosition().toPosition();
                    Console.Write("Destiny: ");
                    Position dest = ScreenHandler.ChessPosition().toPosition();

                    game.DoMovement(origin, dest);
                }

            } catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
