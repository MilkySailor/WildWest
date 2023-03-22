using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetiorGame
{
    internal class Player
    {

        public int x, y;
        public int speed = 5;
        public int size = 30;
        

        public Player(int _x, int _y)
        {
            x = _x;
            y = _y;

        }

        public void Move(string direction)
        {
            if (direction == "up" && y > 320)
            {
                y -= speed;
            }
            if (direction == "down" && y < 460)
            {
                y += speed;
            }
            if (direction == "left" && x > 10)
            {
                x -= speed;
            }
            if (direction == "right" && x < 370)
            {
                x += speed;
            }
        }
    }
}
