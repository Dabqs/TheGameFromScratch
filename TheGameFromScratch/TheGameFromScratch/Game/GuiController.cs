using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameFromScratch.GUI;

namespace TheGameFromScratch.Game
{
    class GuiController
    {
        private GameWindow gameWindow;
        private CreditWindow creditWindow;


        public void ShowMenu()
        {
            gameWindow = new GameWindow(0, 0, 120, 30, '%');
            gameWindow.Render();

        }
        public void ShowCreditWindow()
        {
            creditWindow = new CreditWindow(28, 10, 60, 18, '%');
            creditWindow.Render();
        }

    }
}
