using Emberwood.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ground.Tiles
{
    public class VoidTile : TileData
    {
        public VoidTile(Coordinate c) : base(c, TileTypeID.None)
        {
        }
    }
}
