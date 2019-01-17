using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Player
    {
        // Spelarens pjäser ligger här!
        public List<Piece> Pieces { get; set; }
        private int number;

        public Player(int number)
        {
            Pieces = new List<Piece>(4);
            this.number = number;
        }

        public override string ToString() => $"Spelare {number}";
    }
}
