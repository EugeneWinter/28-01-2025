using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._01._25.Utils
{
    public class Player
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Player()
        {
            PositionX = 5;
            PositionY = 5;
        }

        public void MoveLeft()
        {
            PositionX--;
            if (PositionX < 0)
            {
                PositionX = 0;
            }
        }

        public void MoveRight()
        {
            PositionX++;
            if (PositionX > 9)
            {
                PositionX = 9;
            }
        }

        public void MoveUp()
        {
            PositionY--;
            if (PositionY < 0)
            {
                PositionY = 0;
            }
        }

        public void MoveDown()
        {
            PositionY++;
            if (PositionY > 9)
            {
                PositionY = 9;
            }
        }
    }
}
