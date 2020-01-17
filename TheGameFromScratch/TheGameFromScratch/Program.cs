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
            GameScreen myGame = new GameScreen(120,30);
            myGame.SetHero(new Hero(0, 0, "Mantas"));

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(rnd.Next(0, 10), rnd.Next(0, 10), "Enemy" + i, i));
            }

            myGame.Render();
            Console.ReadLine();
            myGame.MoveHeroLeft();
            myGame.MoveAllEnemiesDown();
            myGame.Render();

        }
    }
}
