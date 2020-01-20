using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class GameWindow :Window
    {
        private Button creditsButton;
        private Button startButton;
        private Button quitButton;
        private TextBlock titleTextBlock;

        public GameWindow(int x, int y, int width, int height, char borderChar) : base(x, y, width, height, borderChar)
        {
            creditsButton = new Button(X, Y, Width, Height, "Credits");
            startButton = new Button(X, Y, Width, Height, "Start");
            quitButton = new Button(X, Y, Width, Height, "Quit");
            titleTextBlock = new TextBlock(X, Y, Width, new List<string> { "Sukure", "Mantas" });
        }
        public void Render()
        {

        }
    }
}
