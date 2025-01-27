using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._01._25.Utils
{
    public class Player
    {
        public int Position { get; set; }

        public Player()
        {
            Position = 5;
        }

        public void MoveLeft()
        {
            if (Position > 0)
            {
                Position--;
            }
        }

        public void MoveRight()
        {
            if (Position < 9)
            {
                Position++;
            }
        }
    }
}
