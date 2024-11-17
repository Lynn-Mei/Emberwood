using Emberwood.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Events
{
    public class CameraMoveEventArgs : EventArgs
    {
        public Coordinate coordinate{ get; private set; }

        private CameraMoveEventArgs() { }

        public CameraMoveEventArgs(Coordinate c)
        {
            Coordinate coordinate = c;
        }
    }
}
