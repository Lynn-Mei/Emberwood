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
        public DataStrucutre.Vector Vector { get; private set; }

        private CameraMoveEventArgs() { }

        public CameraMoveEventArgs(DataStrucutre.Vector vector)
        {
            Vector = vector;
        }
    }
}
