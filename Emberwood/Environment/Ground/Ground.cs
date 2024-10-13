using Emberwood.Display;
using Logic.Ground;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Emberwood.Environment.Ground
{
    public class Ground: IElement
    {
        private Earthbender earth;
        private List<Tile> tiles; 

        public Ground() { 
            earth = new Earthbender();
            earth.Generate("");
        }

        private void getTilesFromHashmap()
        {
            for (int i = 0; i < earth.Land.Count; i++) {
                for (int j = 0; j < earth.Land.Count; j++)
                {
                    TileCoordinate tileCoordinate = new TileCoordinate(i, j);
                    tiles.Add(new Tile(tileCoordinate, earth.Land.Get(i, j)));
                }
            }
        }

        public override bool IsGround => true;

        public override void Draw(SpriteBatch _spriteBatch)
        {
            foreach (Tile element in tiles)
            {
                element.Draw(_spriteBatch);
            }
        }
    }
}
