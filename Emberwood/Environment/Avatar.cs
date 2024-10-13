using Emberwood.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberwood.Environment
{
    /// <summary>
    /// Master of all elements
    /// </summary>
    public class Avatar
    {
        const int avatarScope = 10; 
        private List<IElement> elements = new List<IElement>();
        public List<IElement> Elements { get; }

        public void UnloadBeyoundScope(Camera c) { 
            foreach (IElement element in elements)
            {
                Coordinate coord = element.TileCoordinate.GetPhysicalCoordinate();
                if (c.IsInScope(coord, avatarScope)) { 
                    Elements.Remove(element);
                }
            }
        }

        public List<IElement> GetInCameraSight(Camera c)
        {
            List<IElement> viewedElements = new List<IElement>();
            foreach (IElement element in elements)
            {
                Coordinate coord = element.TileCoordinate.GetPhysicalCoordinate();
                if (c.IsInScope(coord))
                {
                    viewedElements.Add(element);
                }
            }
            return viewedElements;
        }

    }
}
