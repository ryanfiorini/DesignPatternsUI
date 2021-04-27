using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Builder
{
    internal class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }

        internal override void BuildDoors()
        {
            vehicle["Doors"] = "0";
        }

        internal override void BuildEngine()
        {
            vehicle["Engine"] = "50 CC";
        }

        internal override void BuildFrame()
        {
            vehicle["Frame"] = "Scooter Frame";
        }

        internal override void BuildWheels()
        {
            vehicle["Wheels"] = "2";
        }
    }
}
