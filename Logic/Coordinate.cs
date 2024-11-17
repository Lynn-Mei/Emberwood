using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberwood.Display
{
    public class Coordinate
    {
        private int x, y, z;
        private int width, height;

        public Coordinate()
        {
            x = 0;
            y = 0;
            z = 0;
            width = 0; height = 0;
        }

        public Coordinate(int x, int y, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            width = 0; height = 0;
        }

        public Coordinate(int x, int y, int height, int width, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.z = z;
        }

        public int X { get { return x; } set { this.x = value; } }
        public int Y { get { return y; } set { this.y = value; } }
        public int Z { get { return z; } set { this.z = value; } }

        public int Width { get { return width; } set { this.width = value; } }
        public int Height { get { return height; } set { this.height = value; } }
    }
}
