using System;
using System.Collections.Generic;

namespace GameEngine
{
    public class Game
    {
        // Deltagarna ligger här!
        public List<Player> Players { get; set; }

        public Game(List<Player> players)
        {
            Players = new List<Player>(4); // <- Betyder max 4.
            Players = players;
            
            
            //Pseudokod för presentation av pjäsernas positioner.
            /*
            Om "Piece isHOME = TRUE" , ta inte med correction factor.
            Om FALSE, beräkna med correction factor.
            */
        }

        public List<Piece> GetPieces()
        {
            throw new NotImplementedException(); // <- Tas bort!
        }

        // Metod som räknar ut pjäsens position med hänsyn till korrigeringsfaktorn.
    }

    public class Player
    {
        // Spelarens pjäser ligger här!
        public List<Piece> Pieces { get; set; }

        public Player()
        {
            Pieces = new List<Piece>(4);
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
        public int correctionFactor { get; set; }
        private int position;

        public Piece(PieceColor color, int number, int position/*, int correctionFactor*/)
        {
            Color = color;
            Number = number;
            this.position = position;
            //this.correctionFactor = correctionFactor;
        }

        // Flytta pjäsen x antal steg.
        public void Move(int steps) => position += steps;

        // Hämta pjäsens "lokala position".
        public int GetPosition() => position;

        // Hämta pjäsens "globala position".
        public int GetAbsolutePosition() => position + correctionFactor;
    }

    public class Dice
    {
        public int Roll()
        {
            return new Random().Next(1, 7);
        }
    }
}