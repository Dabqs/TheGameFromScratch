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
        public GameController(int screenWidth, int screenHeight)
        {
            this.myGame = new GameScreen(screenWidth, screenHeight);
        }
        public void StartGame()
        {
            InitGame();
            StartGameLoop();
        }
        public void InitGame()
        {

            myGame.SetHero(new Hero(0, 0, "Mantas"));

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
                            needToRender = false;
                            break;
                        default:
                            break;
                    }
                }

                myGame.Render();
                System.Threading.Thread.Sleep(250);

            } while (needToRender);
        }
    }
}
