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
            Hero hero = new Hero(0, 0, "Mantas");

            hero.PrintInfo();
            hero.MoveRight();
            hero.PrintInfo();


            List<Enemy> enemies = new List<Enemy>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy(rnd.Next(0, 10), rnd.Next(0, 10), "Enemy" + i, i));
            }
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
                enemy.MoveDown();
                enemy.PrintInfo();
            }

        }
    }
}
