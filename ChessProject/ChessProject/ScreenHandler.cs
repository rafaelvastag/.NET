using board;
using ChessProject.chess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessProject
{
    class ScreenHandler
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    if (null != board.Part(i, j))
                    {
                        PrintPart(board.Part(i, j));
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static ChessPosition ChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");

            return new ChessPosition(column, row);
        }

        public static void PrintPart(Part part)
        {
            if (part.Color == Color.White)
            {
                Console.Write(part.ToString() + " ");
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(part.ToString() + " ");
                Console.ForegroundColor = aux;
            }
        }
    }
}