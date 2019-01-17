using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Piece
    {
        public enum PieceColor
        {
            Red, Blue, Yellow, Green
        }

        public PieceColor Color { get; set; }
        public int Number { get; set; }
        public int correctionFactor { get; set; }
        private int position;

        public Piece(PieceColor color, int number, int position, int correctionFactor)
        {
            Color = color;
            Number = number;
            this.position = position;
            this.correctionFactor = correctionFactor;
        }

        // Flytta pjäsen 'steps' antal steg.
        public void Move(int steps) => position += steps;

        // Hämta pjäsens "lokala position".
        public int GetPosition() => position;

        // Hämta pjäsens "globala position".
        public int GetAbsolutePosition() =>
            position + correctionFactor > 40 ?  // IF
            position + correctionFactor - 40 :  // THEN
            position + correctionFactor;        // ELSE

        public void Home() => position = 0;

        public bool IsHome() => position == 0;

        public bool InGoal() => position >= 45;

        // Ersatts av instansvariabeln. Överge?
        public static bool IsOnOpponentPosition(Piece myPiece, Piece opponentPiece) =>
            myPiece.GetAbsolutePosition() == opponentPiece.GetAbsolutePosition() && opponentPiece != myPiece;

        // Metod som avgör om spelarens pjäs har samma position som motståndarens position med hänsyn till korrigeringsfaktorn.
        public bool IsOnOpponentPosition(Piece opponentPiece) =>
            GetAbsolutePosition() == opponentPiece.GetAbsolutePosition() && this != opponentPiece;

        // Exempelresultat: 'R3' om pjäsen är Röd och har siffra 3.
        public override string ToString() => $"{Color.ToString()[0]}{Number}";
    }
}
