using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace BrickBreaker
{
    class Ball
    {
        SoundPlayer hitNoise = new SoundPlayer(Properties.Resources.hitNoise);

        public int x, y, size;
        public Rectangle rec;
        int speedX = -5;
        int speedY = -5;

        public Ball(int x_, int y_, int size_)
        {
            x = x_;
            y = y_;
            size = size_;
            rec = new Rectangle(x, y, size, size);
        }

        public void Move(int width) 
        { 
            if (x+size >= width || x <= 0) { speedX *= -1; }
            if (y <= 0) { speedY *= -1; }
            x += speedX; 
            y += speedY;
            rec = new Rectangle(x, y, size, size);
        }
        public bool Collison(Rectangle collision) 
        {
            if (rec.IntersectsWith(collision)) 
            {
                hitNoise.Play();
                //poor collision dection that works sometimes
                if (x > collision.X + size +1) { speedX *= -1; }
                else if (x + size + 1 < collision.X) { speedX *= -1; }
                else { speedY *= -1; }
                return true; 
            }
            else { return false; }
        }
        public void Collison(Player player)
        {
            //overload for player
            if (rec.IntersectsWith(player.rec)) 
            { 
                speedY *= -1;
                hitNoise.Play();
            }
        }
    }
}
