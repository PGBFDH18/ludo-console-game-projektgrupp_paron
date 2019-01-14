using System.Collections.Generic;
using System.Drawing;
using System;
using GameEngine;

namespace LudoGame
{
    class Program
    {
        public static Game game;

        static void Main(string[] args)
        {
            #region
            // Lista med valbara färger.
            var pieceColors = new List<PieceColor>
            {
                PieceColor.Red,
                PieceColor.Blue,
                PieceColor.Yellow,
                PieceColor.Green
            };

            // Game setup.
            Console.WriteLine("Välkommen till PäronLudo!");
            Console.WriteLine("Hur många spelare skall spela? (2-4)");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            List<Player> players = new List<Player>(4);

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Player player = new Player();
                //// Skriv ut lista på valbara färger.
                for (int j = 0; j < pieceColors.Count; j++)
                {
                    Console.WriteLine($"[{j + 1}]: " + pieceColors[j]);
                }
                // Val av färg.
                Console.Write($"Spelare {i + 1} välj färg att spela med: ");
                var index = int.Parse(Console.ReadLine());

                // Tilldela startpostitioner till pjäser.                
                // Lägger till 4 pjäser per färg.
                for (int k = 0; k < 4; k++)
                {
                    PieceColor color = pieceColors[index - 1];
                    Piece piece = new Piece(color, k + 1, 0);
                    player.Pieces.Add(piece);
                }
                pieceColors.RemoveAt(index - 1);
                players.Add(player);
            }

            game = new Game(players);

            // För varje spelare...
            foreach (var player in game.Players)
            {
                // För varje pjäs...
                foreach (var piece in player.Pieces)
                {
                    Console.WriteLine(piece.Color + " " + piece.Number + " " + piece.GetPosition());
                }
            }
            #endregion

            foreach (var player in game.Players)
            {
                PlayerTurn(player);
            }


            Console.ReadKey();
        }   
        
        public static void ListPieces()
        {
            throw new NotImplementedException();
        }

        public static void GameSetup()
        {
            throw new NotImplementedException();
        }

        public static void PlayerTurn(Player player)
        {
            //// Presentera var alla pjäsers position.

            //// tryck på en knapp för att kasta tärningen.
            //int dice = Dice.Roll();
            //// presentera värdet på dice.



            //// Välj vilken pjäs som ska flyttas.

            //player.Pieces[x] == 0 AND dice == 1 OR dice == 6
        }
    }
}