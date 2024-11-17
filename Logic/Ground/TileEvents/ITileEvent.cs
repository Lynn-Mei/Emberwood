using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ground.TileEvents
{
    public interface ITileEvent
    {
        public TileData Execute(TileData t);
    }
}
