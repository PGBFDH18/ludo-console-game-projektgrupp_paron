using System;
using System.Collections.Generic;

namespace GameEngine
{

    public class Game
    {
        public List<Player> Players { get; set; }

        public Game(List<Player> players)
        {
            Players = new List<Player>(4); // <- Betyder max 4.
            Players = players;
            
            
            //Pseudokod för presentation av pjäsernas positioner.
            /*
            Om "Piece isHOME = TRUE" , ta inte med correction factor.
            Om FALSE, beräkna med correction factor.
            


            Player player = new Player();
            Player player2 = player;
            player2.CorrecFactor(4);

            int number = 5;
            int numer2 = number;
            numer2 = 10;
            */
        }

        public List<Piece> GetPieces()
        {
            //Players[x].pieces[y]
            return null;
        }


    }

    public class Player
    {
        public int correctionFactor { get; }
        public List<Piece> pieces { get; set; }

        public Player()
        {
            pieces = new List<Piece>(4);
        }
    }

    public enum PieceColor
    {
        Red, Blue, Yellow, Green
    }

    public class Piece
    {
        public PieceColor Color { get; set; }
        public int Number { get; set; }
        private int position;

        public Piece(PieceColor color, int number, int position)
        {
            Color = color;
            this.Number = number;
            this.position = position;
        }

        public void Move(int i) => position += i;

        public int GetPosition() => position;
    }

    public class Dice
    {
        public int Roll()
        {
            return new Random().Next(1, 7);
        }
    }
}