using Emberwood.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataStrucutre
{
    public class Vector
    {
        private Coordinate initial;
        private Coordinate current;

        public bool IsNull
        {
            get
            {
                bool res = false;
                if (current.X == initial.X && current.Y == initial.Y && current.Z == initial.Z)
                {
                    res = true;
                }
                return res;
            }
        }

        public Vector(Coordinate i, Coordinate c) 
        { 
            initial = i;
            current = c;
        }

        public Coordinate GetMovement()
        {
            Coordinate movement = new Coordinate();
            movement.X = current.X - initial.X;
            movement.Y = current.Y - initial.Y;
            movement.Z = current.Z - initial.Z;
            return movement;
        } 
    }
}
