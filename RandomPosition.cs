﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class RandomPosition
    {
        public static void PlayerPosition()
        {
            Console.WriteLine("Stert the Snake and Ladder Game");
            Console.WriteLine("Single player at start Position 0");
            Random random = new Random();
            int RollDice = random.Next(1,6);
            Console.WriteLine("Player rolls the dice and get: " + RollDice);
        }
    }
}
