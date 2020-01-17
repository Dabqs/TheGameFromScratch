using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameFromScratch.Game;

namespace TheGameFromScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
            bool needToRender = true;
            GameScreen myGame = new GameScreen(120, 30);
            myGame.SetHero(new Hero(0, 0, "Mantas"));

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(rnd.Next(0, 10), rnd.Next(0, 10), "Enemy" + i, i));
            }

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
