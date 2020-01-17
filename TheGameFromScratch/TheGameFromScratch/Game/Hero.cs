using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.Game
{
    class Hero
    {
        protected int X;
        protected int Y;
        protected string Name;

        public Hero(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public void MoveRight()
        {
            X++;
        }
        public void MoveLeft()
        {
            X--;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Hero {Name} is at [{X};{Y}]");
        }
    }
}
