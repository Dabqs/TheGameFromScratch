﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameFromScratch.Game;
using TheGameFromScratch.Units;

namespace TheGameFromScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController myGame = new GameController(10,10);
            myGame.StartGame();
        }
    }
}
