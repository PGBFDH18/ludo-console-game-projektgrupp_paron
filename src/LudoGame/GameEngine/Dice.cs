using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Dice
    {
        public static int Roll()
        {
            return new Random().Next(1, 7);
        }
    }
}
