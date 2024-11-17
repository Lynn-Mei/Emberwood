using Emberwood.Display;
using Logic.Ground;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GameData
    {
        private GroundData ground;
        private Camera camera;

        

        public GameData()
        {
            this.ground = new GroundData(0000); 
            this.camera = new Camera();
        }
    }
}
