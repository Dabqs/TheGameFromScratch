using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameFromScratch.Game;
using TheGameFromScratch.GUI;
using TheGameFromScratch.Units;

namespace TheGameFromScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            //myGame.StartGame();
            //GameController myGame = new GameController(10,10);

            Console.CursorVisible = false;
            GameWindow gameWindow = new GameWindow(0, 0, 120, 30, '%');
            gameWindow.Render();
            Console.ReadLine();
            CreditWindow creditWindow = new CreditWindow(28,10,60,18,'%');
            creditWindow.Render();

        }
    }
}
