using Logic.DataStrucutre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ground
{
    public class GroundGenerator
    {
        private Hashmap<GroundID> land;
        public GroundGenerator() { }

        public void Generate(string locationName)
        {
            Hashmap<GroundID> land = null; 
            if (locationName == "")
            {
                land = new Hashmap<GroundID>(60);
                land.Fill(GroundID.Grass);
            }
        }

        public Hashmap<GroundID> Land => land;
    }
}
