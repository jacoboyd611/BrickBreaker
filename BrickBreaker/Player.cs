using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    class Player
    {
        public int x, y, sizeX, sizeY;
        public Rectangle rec;
        int speed = 10;
        public Player(int x_, int y_, int sizeX_, int sizeY_)
        {
            x = x_;
            y = y_;
            sizeX = sizeX_;
            sizeY = sizeY_;
            rec = new Rectangle(x, y, sizeX, sizeY);
        }
        public void Move(bool left, bool right, int width) 
        {
            if (left && x>0) { x -= speed; }
            else if (right && x+sizeX <= width) { x += speed; }
            rec = new Rectangle(x, y, sizeX, sizeY);
        }
    }
}
