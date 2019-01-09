using System.Collections.Generic;
using System.Drawing;
using System;
using GameEngine;

namespace LudoGame
{
    class Program
    {
        static List<Player> players;

        static void Main(string[] args)
        {
            players = new List<Player>();
            StartGame();
        }

        static void StartGame()
        { 

        }

        static void GameSetup()
        {
            Console.WriteLine("Välkommen till PäronLudo!");
            Console.WriteLine("Hur många spelare skall spela? (2-4)");
            int numberOfPlayers = int.Parse(Console.ReadLine());

            // Lista med valbara färger.
            var playerColors = new List<ConsoleColor>
            {
                ConsoleColor.Red,
                ConsoleColor.Blue,
                ConsoleColor.Yellow,
                ConsoleColor.Green
            };

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Spelare " + (i + 1) + "välj färg");
                for (int j = 0; j < playerColors.Count; j++)
                {
                    Console.WriteLine($"[{j + 1}]: " + playerColors[j]);
                }
                Console.WriteLine();
                //players.Add(new Player(...));
            }

        }
        
        class Player
        {
            private List<Piece> pieces = new List<Piece>(4);

            public Player(ConsoleColor pieceColor)
            {
                // Loop 4 gånger
                pieces.Add(new Piece(pieceColor));
            }

        }

        class Piece
        {
            private int Number;
            private ConsoleColor color;

            public Piece(ConsoleColor color)
            {
                this.color = color;
            }
        }
        
    }
}