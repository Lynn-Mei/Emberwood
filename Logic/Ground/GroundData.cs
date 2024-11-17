using Emberwood.Display;
using Logic.DataStrucutre;
using Logic.Ground.Generation;
using Logic.Ground.TileEvents;
using Logic.Ground.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ground
{
    public class GroundData : Hashmap
    {
        private Generator generator;
        public GroundData(int seed, int depth = 60) : base(depth)
        {
            this.generator = new FakeGenerator(seed);
        }

        private void Generate(Vector v)
        {
            for (int i = 0; i< depth; i++)
            {
                for (int j = 0; j < depth; j++) {
                    Coordinate c = new Coordinate(i, j, 32, 64, 0);
                    TileTypeID id = this.generator.Generate(c);
                    this.SetTile(c, new EarthTile(c, id));
                }
            }
            //if (!v.IsNull)
            //{

            //}
        }

        public void UpdateTile(ITileEvent tevent, Coordinate c)
        {
            this.SetTile(c, tevent.Execute(this.GetTile(c)));
            //To do : add callback to possibly influence other tiles on event
        }

    }
}
