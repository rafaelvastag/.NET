using board;
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
                for (int j = 0; j < board.Columns; j++)
                {
                    if (null != board.Part(i, j))
                    {
                        Console.Write(board.Part(i, j) + " ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}