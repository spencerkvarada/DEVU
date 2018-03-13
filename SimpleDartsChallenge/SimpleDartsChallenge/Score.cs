﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace SimpleDartsChallenge
{
    public class Score
    {
        public static void ScoreOfGame(Player player, Dart dart)
        {
            int score = 0;

            if (dart.IsThree) score = dart.Score * 3;
            else if (dart.IsTwo) score = dart.Score * 2;
            else score = dart.Score;

            if (dart.IsThree && dart.Score == 0) score = 50;
            else if (dart.Score == 0) score = 25;

            player.Score += score;
        }
    }
}