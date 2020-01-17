using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.Game
{
    class Hero : Unit
    {
        public Hero(int x, int y, string name) : base(x,y, name)
        {
        }

        public void MoveRight()
        {
            X++;
        }
        public void MoveLeft()
        {
            X--;
        }
    }
}
