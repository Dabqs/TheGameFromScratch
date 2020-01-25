using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class GameWindow :Window
    {
        private int buttonY = 13;
        private int buttonWidth = 18;
        private int buttonHeigth = 5;
        private List<Button> menuButtons = new List<Button>();

        //private Button creditsButton;
        //private Button startButton;
        //private Button quitButton;
        private TextBlock titleTextBlock;

        public GameWindow(int x, int y, int width, int height, char borderChar) : base(0, 0, 120, 30, '%')
        {
            menuButtons.Add(new Button(50, buttonY, buttonWidth, buttonHeigth, "Credits"));
            menuButtons.Add(new Button(20, buttonY, buttonWidth, buttonHeigth, "Start"));
            menuButtons.Add(new Button(80, buttonY, buttonWidth, buttonHeigth, "Quit"));
            //creditsButton = new Button(50, buttonY, buttonWidth, buttonHeigth, "Credits");
            //startButton = new Button(20, buttonY, buttonWidth, buttonHeigth, "Start");
           //quitButton = new Button(80, buttonY, buttonWidth, buttonHeigth, "Quit");
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { 
                "Super duper zaidimas", 
                "Manto Dapkaus kuryba",
                "Made in Vilnius Coding School!"
            });
            menuButtons.Where(button => button.Label.Equals("Start")).FirstOrDefault().SetActive();
        }
        public override void Render()
        {
            base.Render();
            foreach (Button button in menuButtons)
            {
                button.Render();
            }
            titleTextBlock.Render();
            //startButton.Render();
            //creditsButton.Render();
            //quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
