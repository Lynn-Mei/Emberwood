using Emberwood.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberwood.Display
{
    public class Camera
    {
        private Coordinate center;
        private IElement focusedElement = null;
        private int wideScope;
        private int longScope;

        public Camera() 
        { 
            this.center = new Coordinate(0, 0);
            wideScope = 30; //Should be based on screen height and width + size of tiles
            longScope = 40;
        }

        public Camera(IElement element)
        {
            this.focusedElement = element;
            wideScope = 30; //Should be based on screen height and width + size of tiles
            longScope = 40;
        }

        public Coordinate Center { 
            get { 
                Coordinate center = this.center;
                if (focusedElement != null)
                {
                    center = focusedElement.TileCoordinate.GetPhysicalCoordinate();
                }
                return center; 
            } 
        }

        public bool IsInScope(Coordinate c, int avatarScope = 0)
        {
            bool inScope = false;
            if (Center.X - wideScope - avatarScope < c.X && c.X < Center.X + wideScope + avatarScope)
            {
                inScope = true;
            }
            return inScope;
        }


    }
}
