using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameFromScratch.Units;

namespace TheGameFromScratch.Game
{
    class GameController
    {
        private GameScreen myGame;

        public void StartGame()
        {
            InitGame();
            StartGameLoop();
        }
        public void InitGame()
        {
            myGame = new GameScreen(30, 20);
            myGame.SetHero(new Hero(5, 5, "Mantas"));

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(rnd.Next(0, 10), rnd.Next(0, 10), "Enemy" + i, i));
            }
        }
        public void StartGameLoop()
        {
            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
            bool needToRender = true;
            do
            {
                Console.Clear();
                while (Console.KeyAvailable)
                {
                    keyinfo = Console.ReadKey(true);
                    switch (keyinfo.Key)
                    {
                        case ConsoleKey.RightArrow:
                            myGame.MoveHeroRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.MoveHeroLeft();
                            break;
                        case ConsoleKey.Escape:
                            GuiController guiController = new GuiController();
                            guiController.ShowMenu();
                            break;
                    }
                }

                myGame.Render();
                System.Threading.Thread.Sleep(250);

            } while (needToRender);
        }
    }
}
