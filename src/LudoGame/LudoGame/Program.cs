using System.Collections.Generic;
using System.Drawing;
using System;
using GameEngine;

namespace LudoGame
{
    class Program
    {
        static Dictionary<Piece, int> piecePosition;

        static void Main(string[] args)
        {
            // Lista med valbara färger.
            var pieceColors = new List<ConsoleColor>
            {
                ConsoleColor.Red,
                ConsoleColor.Blue,
                ConsoleColor.Yellow,
                ConsoleColor.Green
            };

            var startPosition = new List<int> { 1, 11, 21, 31 };

            // 
            Console.WriteLine("Välkommen till PäronLudo!");
            Console.WriteLine("Hur många spelare skall spela? (2-4)");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            var pieces = new Dictionary<Piece, int>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                // Skriv ut lista på valbara färger.
                for (int j = 0; j < pieceColors.Count; j++)
                {
                    Console.WriteLine($"[{j + 1}]: " + pieceColors[j]);
                }
                // Val av färg.
                Console.Write("Välj färg att spela med: ");
                var index = int.Parse(Console.ReadLine());

                // Tilldela startpostitioner till pjäser.                
                // Lägger till 4 pjäser per färg.
                for (int m = 1, k = 0; m < 42; m += 10, k++)
                {
                    ConsoleColor color = pieceColors[k];
                    pieceColors.RemoveAt(k);
                    pieces.Add(new Piece(color, k, m), 0);
                }
            }
        }        
    }
}