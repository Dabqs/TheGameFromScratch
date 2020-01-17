using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.Game
{
    class Enemy
    {
        private int id;
        protected int X;
        protected int Y;
        protected string Name;

        public Enemy(int x, int y, string name, int id)
        {
            X = x;
            Y = y;
            Name = name;
            this.id = id;
        }

        public void MoveDown()
        {
            Y++;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Enemy {Name} is at [{X};{Y}] (ID: {id})");
        }

        public int GetId()
        {
            return id;
        }

    }
}
