using Emberwood.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ground.Generation
{
    public class FakeGenerator : Generator
    {
        public FakeGenerator(int seed) : base(seed)
        {
        }

        public override TileTypeID Generate(Coordinate c)
        {
            TileTypeID tileType = TileTypeID.Grass;
            if (c.X % 4 == 0)
            {
                tileType = TileTypeID.Grass;
            }
            return tileType;
        }
    }
}
