using Emberwood.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ground
{
    public abstract class TileData
    {
        private Coordinate location;
        private TileTypeID tileTypeID;

        public Coordinate Location { get {  return location; } }
        public TileTypeID TileTypeID { get { return tileTypeID; } }
        public TileData(Coordinate c, TileTypeID t) 
        { 
            location = c;
            tileTypeID = t;
        }



    }
}
