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
        private ConsoleColor color;

        public Piece(ConsoleColor color, int number)
        {
            this.number = number;
            this.color = color;
        }
    }
}
