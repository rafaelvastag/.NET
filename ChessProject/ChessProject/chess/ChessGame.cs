using board;
using ChessProject.chess;
using System;

namespace chess
{
    class ChessGame
    {
        public Board Board { get; private set; }
        private int Plays;
        private Color ColorCurrentPlayer;
        public bool Finished { get; private set; }

        public ChessGame()
        {
            Board = new Board(8,8);
            Plays = 1;
            ColorCurrentPlayer = Color.White;
            Finished = false;
            PutPartsInBoard();
        }

        private void PutPartsInBoard()
        {
            Board.AddPart(new Rook(Board, Color.Black), new ChessPosition('c', 1).toPosition());
            Board.AddPart(new Rook(Board, Color.Black), new ChessPosition('c', 2).toPosition());
            Board.AddPart(new Rook(Board, Color.Black), new ChessPosition('d', 2).toPosition());
            Board.AddPart(new Rook(Board, Color.Black), new ChessPosition('e', 2).toPosition());
            Board.AddPart(new Rook(Board, Color.Black), new ChessPosition('e', 1).toPosition());
            Board.AddPart(new King(Board, Color.Black), new ChessPosition('d', 1).toPosition());

            Board.AddPart(new Rook(Board, Color.White), new ChessPosition('c', 7).toPosition());
            Board.AddPart(new Rook(Board, Color.White), new ChessPosition('c', 8).toPosition());
            Board.AddPart(new Rook(Board, Color.White), new ChessPosition('d', 7).toPosition());
            Board.AddPart(new Rook(Board, Color.White), new ChessPosition('e', 7).toPosition());
            Board.AddPart(new Rook(Board, Color.White), new ChessPosition('e', 8).toPosition());
            Board.AddPart(new King(Board, Color.White), new ChessPosition('d', 8).toPosition());
        }

        public void DoMovement(Position from, Position to)
        {
            Part Part = Board.RemovePart(from);
            Part.IncreaseMovement();
            Part PartCatch = Board.RemovePart(to);
            Board.AddPart(Part, to);
        }
    }
}
