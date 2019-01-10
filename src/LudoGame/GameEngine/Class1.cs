using System;
using System.Collections.Generic;

namespace GameEngine
{
    public class Board
    {
        public Board(Dictionary<Piece, int> pieces)
        {

        }
    }

    public class Piece
    {
        private int number;
        private int position;
        private ConsoleColor color;

        public Piece(ConsoleColor color, int number, int position)
        {
            this.number = number;
            this.position = position;
            this.color = color;
        }

        //public class PiecePosition
        //{
        //    public Piece Piece { get; }
        //    public int Steps { get; set; }
        //    public int Position { get; set; }

        //    public PiecePosition(Piece piece)
        //    {
        //        Piece = piece;
        //    }
        //}
    }

    public class Dice
    {
 

    }
}
