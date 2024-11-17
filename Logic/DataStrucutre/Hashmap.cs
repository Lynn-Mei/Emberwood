using Emberwood.Display;
using Logic.Ground;
using Logic.Ground.Tiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataStrucutre
{
    public abstract class Hashmap
    {
        protected int depth = 0;
        protected Dictionary<Coordinate, TileData> data;
        public int Count => data.Count;

        public Hashmap(int depth) { 
            data = new Dictionary<Coordinate, TileData>();
            this.depth = depth;
        }

        public TileData GetTile(Coordinate c)
        {
            TileData res = new VoidTile(c);
            if (data.ContainsKey(c))
            {
                res = data[c];
            }
            return res;
        }

        public void SetTile(Coordinate c, TileData t) {
            if (data.ContainsKey(c))
            {
                data[c] = t;
            }
            else {
                data.Add(c, t);
            }   
        }

        public void EmptyTile(Coordinate c)
        {
            if (data.ContainsKey(c))
            {
                data[c] = new VoidTile(c);
            }
        }
        public void ClearTile(Coordinate c) {
            if (data.ContainsKey(c))
            {
                data.Remove(c);
            }
        }

    }
}
