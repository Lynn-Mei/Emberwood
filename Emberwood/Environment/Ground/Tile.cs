using Emberwood.Display;
using Logic.Ground;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberwood.Environment.Ground
{
    public class Tile : IElement
    {
        private TileCoordinate tilePosition;
        private GroundID tileID;
        private Texture2D tileTexture;

        public Tile(TileCoordinate position, GroundID tileID) 
        {
            this.tilePosition = position;
            this.tileID = tileID;
            this.tileTexture = GameController.Instance.Game.Content.Load<Texture2D>(String.Format("Ground-{0}", tileID));
        }

        public override bool IsGround => true;

        public override void Draw(SpriteBatch _spriteBatch)
        {
            //A implementer
        }
    }
}
