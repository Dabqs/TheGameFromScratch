using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.Game
{
    class Enemy : Unit
    {
        private int id;

        public Enemy(int x, int y, string name, int id) : base(x, y,name)
        {
            this.id = id;
        }

        public void MoveDown()
        {
            Y++;
        }

        public int GetId()
        {
            return id;
        }

    }
}
