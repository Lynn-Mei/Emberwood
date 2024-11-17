using Emberwood.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ground.Generation
{
    public abstract class Generator
    {
        private int seed;
        public Generator(int seed)
        {
            this.seed = seed;
        }

        public abstract TileTypeID Generate(Coordinate c);
    }
}
