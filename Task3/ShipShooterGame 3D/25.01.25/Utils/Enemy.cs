using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._01._25.Utils
{
    public class Enemy
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Enemy(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}
