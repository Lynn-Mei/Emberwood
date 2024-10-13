using Emberwood.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberwood.Environment
{
    public class TileCoordinate
    {
        private int x;
        private int y;
        private int z;

        public TileCoordinate(int x, int y, int z = 30)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X => x;
        public int Y => y;
        public int Z => z;

        public Coordinate GetPhysicalCoordinate()
        {
            return new Coordinate(x, y, z); //temprorary
        }

    }
}
