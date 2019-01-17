using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Game
    {
        // Deltagarna ligger här!
        public List<Player> Players { get; set; }

        public Game(List<Player> players)
        {
            Players = players;
        }
    }
}
