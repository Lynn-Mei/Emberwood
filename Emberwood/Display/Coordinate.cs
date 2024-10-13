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

        public Coordinate(int x, int y, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X => x;
        public int Y => y;
        public int Z => z;

    }
}
