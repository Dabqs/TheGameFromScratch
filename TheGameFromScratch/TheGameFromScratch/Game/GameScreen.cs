using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.Units
{
    class GameScreen
    {
        private int width;
        private int height;
        private Hero hero;
        private List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }
        public void MoveHeroRight()
        {
            if (hero.GetX() < width)
            {
            hero.MoveRight();
            }
        }
        public void MoveHeroLeft()
        {
            if (hero.GetX() > 0)
            {
                hero.MoveLeft();
            }
        }
        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }
        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }
        }

        public Enemy GetEnemyByID(int id)
        {
            return enemies.Where(enemy => enemy.GetId() == id).FirstOrDefault();
        }

        public void Render()
        {
            hero.PrintInfo();
            Console.WriteLine();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }
        
    }
}
