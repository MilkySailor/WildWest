using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MetiorGame
{
    internal class Earth
    {


        public int x, y;
        public int size = 50;

        public Earth(int _x, int _y)
        {
            x = _x;
            y = _y;

          
        }
        public void Move(int height)
        {

            y += 3;

            if (y > height - size)
            {

            }
        }
        //public bool Collision(Player pl)
        //{
        //    Rectangle earthRec = new Rectangle(x, y, size, size);
        //    Rectangle playerRec = new Rectangle(pl.x, pl.y, pl.size, pl.size);

        //    if (earthRec.IntersectsWith(playerRec))
        //    {

        //    }
        //}
    }
}
