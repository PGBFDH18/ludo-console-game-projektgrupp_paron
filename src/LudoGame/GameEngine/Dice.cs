﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    /// <summary>
    /// Used for randomizing any integer of a six-sided dice. This class cannot be derived from.
    /// </summary>
    public sealed class Dice
    {
        public static int Roll()
        {
            return new Random().Next(1, 7);
        }
    }
}
