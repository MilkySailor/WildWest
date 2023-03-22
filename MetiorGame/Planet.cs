using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MetiorGame
{
    internal class Planet
    {

        public int x, y, ySpeed;
        public int size = 50;

        public Planet(int _x, int _y, int _ySpeed)
        {
            x = _x;
            y = _y;
            
            ySpeed = _ySpeed;
        }
        public void Move(int height)
        {

            y += ySpeed;

            if (y > height - size)
            {
                
            }
        }

        public void Collision(Planet p)
        {
            //Rectangle ballRec = new Rectangle(x, y, size, size);
            //Rectangle ball2Rec = new Rectangle(p.x, p.y, p.size, p.size);

            //if (ballRec.IntersectsWith(ball2Rec))
            //{
            //    ySpeed *= -1;
            //}
        }

        public bool Collision(Player pl)
        {
            Rectangle planetRec = new Rectangle(x, y, size, size);
            Rectangle playerRec = new Rectangle(pl.x, pl.y, pl.size, pl.size);

            if (planetRec.IntersectsWith(playerRec))
            {
                if (ySpeed > 0)
                {
                    y = pl.y - size;
                }
                else
                {
                    y = pl.y + pl.size;
                }

                ySpeed *= -1;
                return true;
            }
            return false;
        }
    }
}
