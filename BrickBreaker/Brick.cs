using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    class Brick
    {
        public int x, y, size;
        public Rectangle rec;
        public Brick(int x_, int y_, int size_)
        {
            x = x_;
            y = y_;
            size = size_;
            rec = new Rectangle(x, y, size, size);
        }
    }
}
