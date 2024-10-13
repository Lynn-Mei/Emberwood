using Emberwood.Display;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberwood.Environment
{
    public abstract class IElement
    {
        private TileCoordinate coordinate;

        public TileCoordinate TileCoordinate { get { return this.coordinate; } }

        public abstract bool IsGround { get; }
        public abstract void Draw(SpriteBatch _spriteBatch); 
    }
}
